﻿using LittleFancyTool.Models;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using Modbus.Device;
using System.Diagnostics;
using System.IO.Ports;

namespace LittleFancyTool.View
{
    public partial class ModbusPollForm : UserControl
    {
        private SerialPort serialPort = new SerialPort();
        private ModbusSerialMaster? modbusMaster;
        private AntdUI.Window window;
        private bool isPolling = false;
        private readonly object _dataLock = new object();
        private int txCount = 0;
        private int errCount = 0;
        private IMessageService messageService = new MessageService();

        public ModbusPollForm(AntdUI.Window _window)
        {
            this.window = _window;
            //双缓冲
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            InitializeComponent();
            RefreshPortList();
            InitialTableData();
            TXStatusLabel.Text = $"TX={txCount} Err={errCount}";
            outputInput.TextChanged += (s, e) => outputInput.ScrollToCaret();
        }

        private void InitialTableData()
        {

            slaveTable.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("address", "寄存器地址").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("valueDec", "数值(DEC)").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("lastUpdate", "最后更新时间").SetLocalizationTitleID("Table.Column."),
            };
            int regNum = (int)numRegistersInput.Value;
            slaveTable.DataSource = GetPageData(regNum);
        }

        private object GetPageData(int regNum)
        {
            var list = new List<PollTable>(regNum);
            list.Add(new PollTable("0x0000", "0", DateTime.Now));
            return list;
        }

        private async Task pollingAsync(int time)
        {
            while (isPolling)
            {
                try
                {
                    ++txCount;
                    TXStatusLabel.Text = $"TX={txCount} Err={errCount}";
                    listenPortAsync();
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("数据读取失败:", ex.Message, "error", window);
                }
                await Task.Delay(time);
            }
        }

        private void RefreshPortList()
        {
            portSelect.Items.Clear();
            portSelect.Items.AddRange(SerialPort.GetPortNames());
            if (portSelect.Items.Count > 0)
                portSelect.SelectedIndex = 0;
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                connectButton.Text = "连接";
                statusInput.Clear();
                connectButton.Type = AntdUI.TTypeMini.Success;
                connectButton.LocalizationText = "connectButton";
                isPolling = false;
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
                    connectButton.Text = "断开";
                    connectButton.LocalizationText = "disconnect";
                    connectButton.Type = AntdUI.TTypeMini.Error;
                    statusInput.Text = $"已连接 {serialPort.PortName}\r\nBaud:{serialPort.BaudRate}\r\n" +
                        $"Parity:{serialPort.Parity}\r\nDataBits:{serialPort.DataBits}\r\n" +
                        $"StopBits:{serialPort.StopBits}";
                    isPolling = true;
                    int time = int.Parse(scanTimeInput.Text);
                    modbusMaster = ModbusSerialMaster.CreateRtu(serialPort);
                    modbusMaster.Transport.ReadTimeout = 100;
                    await pollingAsync(time);
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("连接失败:", ex.Message, "error", window);
                }
            }
        }

        private async void listenPortAsync()
        {
            if (!ValidateInputs())
                return;
            byte slaveId = (byte)slaveIdInput.Value;
            try
            {
                var registers = await ReadModbusDataAsync(slaveId, (ushort)addressInput.Value, (ushort)numRegistersInput.Value);
                outputInput.AppendText($"registers: {string.Join(", ", registers)}\r\n");
                UpdateDataTable((ushort)addressInput.Value, registers, (ushort)numRegistersInput.Value);
            }
            catch (OperationCanceledException ex)
            {
                Debug.WriteLine($"操作被取消: {ex.Message}");
            }
            catch (Exception ex)
            {
                errCount++;
                TXStatusLabel.Text = $"TX={txCount} Err={errCount}";
                if (ex.Message.Contains("Exception Code:"))
                {
                    int index = ex.Message.IndexOf("Exception Code:") + "Exception Code:".Length;
                    string remaining = ex.Message.Substring(index).TrimStart();
                    int nextSpaceIndex = remaining.IndexOf(' ');
                    if (nextSpaceIndex != -1)
                    {
                        string value = remaining.Substring(0, nextSpaceIndex);
                        messageService.InternationalizationMessage(ToolMethod.GetErrorInfo(int.Parse(value)), null, "error", window);

                    }
                }
            }
        }

        private async Task<ushort[]> ReadModbusDataAsync(byte slaveId, ushort startAddress, ushort numRegisters)
        {
            if (functionSelect.SelectedValue.ToString() == "01 Read Coils")
            {
                var coils = await modbusMaster.ReadCoilsAsync(slaveId, startAddress, numRegisters);
                return Array.ConvertAll(coils, b => (ushort)(b ? 1 : 0));
            }
            if (functionSelect.SelectedValue.ToString() == "02 Read Discrete Inputs")
            {
                var inputs = await modbusMaster.ReadInputsAsync(slaveId, startAddress, numRegisters);
                return Array.ConvertAll(inputs, b => (ushort)(b ? 1 : 0));
            }
            if (functionSelect.SelectedValue.ToString() == "03 Read Holding Registers")
            {
                if (numRegisters > 125)
                {
                    numRegisters = 125;
                    numRegistersInput.Value = 125;
                    messageService.InternationalizationMessage("最大读取寄存器数量为125", null, "error", window);
                }
                return await modbusMaster.ReadHoldingRegistersAsync(slaveId, startAddress, numRegisters);
            }
            if (functionSelect.SelectedValue.ToString() == "04 Read Input Registers")
            {
                if (numRegisters > 125)
                {
                    numRegisters = 125;
                    numRegistersInput.Value = 125;
                    messageService.InternationalizationMessage("最大读取寄存器数量为125", null, "error", window);
                }
                return await modbusMaster.ReadInputRegistersAsync(slaveId, startAddress, numRegisters);
            }
            return null;
        }

        private bool ValidateInputs()
        {
            if (modbusMaster == null || !serialPort.IsOpen)
            {
                messageService.InternationalizationMessage("请先打开串口连接", null, "error", window);
                return false;
            }
            return true;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }

        private void UpdateDataTable(ushort startAddress, ushort[] registers, ushort regNum)
        {
            _ = this.Invoke((MethodInvoker)delegate
            {
                lock (_dataLock)
                {
                    var now = DateTime.Now;
                    List<PollTable> oldList = slaveTable.DataSource as List<PollTable>;
                    var list = new List<PollTable>(regNum);
                    if (oldList == null || oldList.Count != regNum)
                    {
                        for (int i = 0; i < regNum; i++)
                        {
                            var address = startAddress + i;
                            list.Add(new PollTable($"0x{address:X4}", registers[i].ToString(), now));
                        }
                        slaveTable.DataSource = list;
                    }
                    else
                    {
                        for (int i = 0; i < regNum; i++)
                        {
                            var address = startAddress + i;
                            oldList[i].address = $"0x{address:X4}";
                            if (oldList[i].valueDec != registers[i].ToString())
                            {
                                oldList[i].valueDec = registers[i].ToString();
                                oldList[i].lastUpdate = now;
                            }
                        }
                        slaveTable.DataSource = oldList;
                    }
                }
            });
        }
    }
}
