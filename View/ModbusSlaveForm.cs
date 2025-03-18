using AntdUI;
using LittleFancyTool.Models;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using LittleFancyTool.View.SubView;
using Microsoft.VisualBasic.ApplicationServices;
using Modbus.Device;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View
{
    public partial class ModbusSlaveForm : UserControl
    {
        private AntdUI.Window window;
        private SerialPort serialPort = new SerialPort();
        private ModbusSerialMaster modbusMaster;
        private IMessageService messageService = new MessageService();
        private List<SlaveTable> dataList = [];
        private List<SlaveTable> paddingList = [];
        private List<SlaveTable> combinedList= [];
        private SlaveTable slaveTableObj;
        public ModbusSlaveForm(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
            InitializeSerialPort();
            RefreshPortList();
            InitialTableData();
            numRegistersInput.TextChanged += valueChange;
            addressInput.TextChanged += startAddrChange;
            slaveTable.CellButtonClick += Table_base_CellButtonClick;
        }

        private void startAddrChange(object sender, EventArgs e)
        {
            slaveTable.DataSource = PaddingChange();
        }

        private List<SlaveTable> PaddingChange() {
            int padding = (int)addressInput.Value;
            paddingList = new List<SlaveTable>(padding);
            for (int i = 0; i < padding; i++)
            {
                paddingList.Add(new SlaveTable($"0x{i:X4}", "", false));
            }
            combinedList = paddingList.Concat(dataList).ToList();
            for (int i = 0; i < combinedList.Count; i++)
            {
                combinedList[i].address = $"0x{(i):X4}";
            }
            return combinedList;
        }

        private void valueChange(object sender, EventArgs e)
        {
            Debug.WriteLine("valueChange");
            if (numRegistersInput.Value > dataList.Count)            {
               
                int startId = dataList.Count;
                for (int i = 0; i < numRegistersInput.Value - dataList.Count; i++)
                {
                     string address = $"0x{(startId + i):X4}";
                     dataList.Add(new SlaveTable(address, "0", false));               
                }                
            }
            else {
                int count = dataList.Count - (int)numRegistersInput.Value;
                if (count > dataList.Count)
                {
                    count = dataList.Count;
                }
                for (int i = 0; i < count; i++)
                {
                    dataList.RemoveAt(dataList.Count - 1);
                }
            }
            combinedList = paddingList.Concat(dataList).ToList();
            for (int i = 0; i < combinedList.Count; i++)
            {
                combinedList[i].address = $"0x{(i):X4}";
            }
            slaveTable.DataSource = combinedList;
        }

        private void InitialTableData()
        {
            slaveTable.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("address", "寄存器地址").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("valueDec", "数值(DEC)").SetLocalizationTitleID("Table.Column."),
                new AntdUI.ColumnSwitch("Enabled", "是否启用自增/自变", ColumnAlign.Left){
                    //支持点击回调
                    Call= (value,record, i_row, i_col) =>{
                        return value;
                    }
                }.SetFixed().SetWidth("auto").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("btns", "操作").SetLocalizationTitleID("Table.Column."),
            };
            int regNum = int.Parse(numRegistersInput.Text);
            slaveTable.DataSource = paddingList.Concat(GetPageData(regNum)).ToList();
        }

        private List<SlaveTable> GetPageData(int regNum)
        {            
            dataList = new List<SlaveTable>(regNum);
            for (int i = 0; i < regNum; i++) {
                dataList.Add(new SlaveTable($"0x{i:X4}", "0", false));
            }
            return dataList;
        }
        private void InitializeSerialPort()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void RefreshPortList()
        {
            portSelect.Items.Clear();
            portSelect.Items.AddRange(SerialPort.GetPortNames());
            if (portSelect.Items.Count > 0)
                portSelect.SelectedIndex = 0;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }

        private void Table_base_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            var buttontext = e.Btn.Text;
            if (e.Record is SlaveTable table)
            {
                slaveTableObj = table;
                switch (buttontext)
                {
                    case "编辑":
                        var form = new SlaveTableEdit(window, table) { Size = new Size(500, 300) };
                        AntdUI.Drawer.open(new AntdUI.Drawer.Config(window, form));
                        break;
                }
            }
        }

        private void updateDateTable() {
            foreach (var table in dataList) {
                if (functionSelect.Text == "01 Coil Status" || functionSelect.Text == "02 Input Status") {
                    if (table.Enabled)
                    {
                        bool boolValue = ushort.Parse(table.valueDec) > 0;
                        ushort value = (ushort)(!boolValue ? 1 : 0);
                        table.valueDec = value.ToString();
                    }
                }
                if (functionSelect.Text == "03 Holding Register" || functionSelect.Text == "04 Input Registers") {
                    if (table.Enabled)
                    {
                        table.valueDec = (int.Parse(table.valueDec) + 1).ToString();
                    }
                }                
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytesToRead = serialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                serialPort.Read(buffer, 0, bytesToRead);
                // 处理 Modbus 请求
                byte[] response = ProcessModbusRequest(buffer);
                if (response != null)
                {
                    serialPort.Write(response, 0, response.Length);
                }
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("数据接收错误:", ex.Message, "error", window);
            }
        }
        private void OpenSerialPort() {
            serialPort.RtsEnable = false;
            serialPort.Handshake = Handshake.None;
            serialPort.PortName = portSelect.SelectedValue.ToString();
            serialPort.BaudRate = int.Parse(baudRateSelect.SelectedValue.ToString());
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity),
                paritySelect.SelectedValue.ToString());
            serialPort.DataBits = int.Parse(dataBitsSelect.SelectedValue.ToString());
            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits),
                stopBitsSelect.SelectedValue.ToString());
            serialPort.WriteTimeout = 500;
            serialPort.Open();
            statusInput.Text = $"已连接 {serialPort.PortName}\r\nBaud:{serialPort.BaudRate}\r\n" +
                $"Parity:{serialPort.Parity}\r\nDataBits:{serialPort.DataBits}\r\n" +
                $"StopBits:{serialPort.StopBits}";
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                connectButton.Text = "连接";
                statusInput.Clear();
                connectButton.Type = AntdUI.TTypeMini.Success;
                connectButton.LocalizationText = "connectButton";
            }
            else
            {
                if (portSelect.SelectedValue == null)
                {
                    messageService.InternationalizationMessage("请选择有效串口:", null, "error", window);
                    return;
                }
                try
                {
                    OpenSerialPort();
                    connectButton.Text = "断开";
                    connectButton.LocalizationText = "disconnect";
                    connectButton.Type = AntdUI.TTypeMini.Error;
                    Task.Run(async () => {
                        while (serialPort.IsOpen) {
                            updateDateTable();
                            await Task.Delay((int)incrementTimeInput.Value);
                        }                       
                    });
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("连接失败:", ex.Message, "error", window);
                }
            }
        }

        private byte[] ProcessModbusRequest(byte[] request)
        {
            if (request.Length < 8) // 最小 Modbus 请求长度
            {
                return null;
            }
            byte slaveAddress = request[0];
            byte functionCode = request[1];
            ushort startAddress = (ushort)((request[2] << 8) | request[3]);
            ushort quantity = (ushort)((request[4] << 8) | request[5]);
            if (slaveAddress!= ushort.Parse(slaveIdInput.Text)) {
                return [slaveAddress, (byte)(functionCode + 0x80), 0x02];
            }
            if (startAddress < ushort.Parse(addressInput.Text))
            {
                return [slaveAddress, (byte)(functionCode + 0x80), 0x02];
            }
            if (quantity > ushort.Parse(numRegistersInput.Text)) {
                return [slaveAddress, (byte)(functionCode + 0x80), 0x02];
            }
            IModbusSlaveService modbusSlaveService = new ModbusSlaveService();

            switch (functionCode)
            {
                case 0x01: // 读取线圈状态
                    return modbusSlaveService.ProcessReadCoils(slaveAddress, startAddress, quantity, combinedList);
                case 0x02: // 读取离散输入状态
                    return modbusSlaveService.ProcessReadDiscreteInputs(slaveAddress, startAddress, quantity, combinedList);
                case 0x03: // 读取保持寄存器
                    return modbusSlaveService.ProcessReadHoldingRegisters(slaveAddress, startAddress, quantity, combinedList);
                case 0x04: // 读取输入寄存器
                    return modbusSlaveService.ProcessReadInputRegisters(slaveAddress, startAddress, quantity, combinedList);
                default:
                    // 不支持的功能码，返回异常响应
                    return [slaveAddress, (byte)(functionCode + 0x80), 0x01];
            }
        }
    }
}
