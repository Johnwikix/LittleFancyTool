using AntdUI;
using LittleFancyTool.Models;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.View.SubView;
using Modbus.Data;
using Modbus.Device;
using System.Diagnostics;
using System.IO.Ports;

namespace LittleFancyTool.View
{
    public partial class ModbusSlaveForm : UserControl
    {
        private AntdUI.Window window;
        private SerialPort serialPort = new SerialPort();
        private ModbusSlave modbusSerialSlave;
        private IMessageService messageService = new MessageService();
        private List<SlaveTable> dataList = [];
        private List<SlaveTable> paddingList = [];
        private List<SlaveTable> combinedList = [];
        private SlaveTable slaveTableObj;
        public ModbusSlaveForm(AntdUI.Window _window)
        {
            this.window = _window;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
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

        private List<SlaveTable> PaddingChange()
        {
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
            if (numRegistersInput.Value > dataList.Count)
            {

                int startId = dataList.Count;
                for (int i = 0; i < numRegistersInput.Value - dataList.Count; i++)
                {
                    string address = $"0x{(startId + i):X4}";
                    dataList.Add(new SlaveTable(address, "0", false));
                }
            }
            else
            {
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
                new Column("address", "寄存器地址").SetLocalizationTitleID("Table.Column."),
                new Column("valueDec", "数值(DEC)").SetLocalizationTitleID("Table.Column."),
                new ColumnSwitch("Enabled", "是否启用自增/自变", ColumnAlign.Left){
                    //支持点击回调
                    Call= (value,record, i_row, i_col) =>{
                        return value;
                    }
                }.SetFixed().SetWidth("auto").SetLocalizationTitleID("Table.Column."),
                new Column("btns", "操作").SetLocalizationTitleID("Table.Column."),
            };
            int regNum = int.Parse(numRegistersInput.Text);
            combinedList = paddingList.Concat(GetPageData(regNum)).ToList();
            slaveTable.DataSource = combinedList;
        }

        private List<SlaveTable> GetPageData(int regNum)
        {
            dataList = new List<SlaveTable>(regNum);
            for (int i = 0; i < regNum; i++)
            {
                dataList.Add(new SlaveTable($"0x{i:X4}", "0", false));
            }
            return dataList;
        }
        private void InitializeSerialPort()
        {
            serialPort = new SerialPort();
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
                    case "Edit":
                        var form = new SlaveTableEdit(window, table) { Size = new Size(500, 300) };
                        AntdUI.Drawer.open(new AntdUI.Drawer.Config(window, form));
                        break;
                }
            }
        }

        private void updateDateTable()
        {
            foreach (var table in dataList)
            {
                if (functionSelect.Text == "01 Coil Status" || functionSelect.Text == "02 Input Status")
                {
                    if (table.Enabled)
                    {
                        bool boolValue = ushort.Parse(table.valueDec) > 0;
                        ushort value = (ushort)(!boolValue ? 1 : 0);
                        table.valueDec = value.ToString();
                    }
                }
                if (functionSelect.Text == "03 Holding Register" || functionSelect.Text == "04 Input Registers")
                {
                    if (table.Enabled)
                    {
                        table.valueDec = (int.Parse(table.valueDec) + 1).ToString();
                    }
                }
            }
        }
        private void OpenSerialPort()
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
            statusInput.Text = $"已连接 {serialPort.PortName}\r\nBaud:{serialPort.BaudRate}\r\n" +
                $"Parity:{serialPort.Parity}\r\nDataBits:{serialPort.DataBits}\r\n" +
                $"StopBits:{serialPort.StopBits}";
            modbusSerialSlave = ModbusSerialSlave.CreateRtu((byte)slaveIdInput.Value, serialPort);
            RunSlave();
            Task.Run(() =>
            {
                try
                {
                    modbusSerialSlave.Listen();
                }
                catch (OperationCanceledException ex)
                {
                    Debug.WriteLine($"操作被取消: {ex.Message}");
                }
            });
        }

        private void DataStore_DataStoreReadFrom(object? sender, DataStoreEventArgs e)
        {
            if (e.StartAddress < addressInput.Value)
            {
                throw new Modbus.InvalidModbusRequestException("illegal startAddr", 0x02);
            }
        }

        private void RunSlave()
        {
            try
            {
                modbusSerialSlave.DataStore = DataStoreFactory.CreateDefaultDataStore(
                        (ushort)combinedList.Count,
                        (ushort)combinedList.Count,
                        (ushort)combinedList.Count,
                        (ushort)combinedList.Count);
                modbusSerialSlave.DataStore.DataStoreReadFrom += DataStore_DataStoreReadFrom;
                ushort quantity = (ushort)numRegistersInput.Value;
                ushort startAddr = (ushort)addressInput.Value;
                for (int i = startAddr; i < combinedList.Count; i++)
                {

                    ushort listAddr = Convert.ToUInt16(combinedList[i].address.Replace("0x", ""), 16);
                    ushort offset = (ushort)(listAddr - startAddr);
                    ushort value = 0;
                    string valueDec = combinedList[i].valueDec;
                    if (valueDec != "")
                    {
                        value = ushort.Parse(valueDec);
                    }
                    if (functionSelect.Text == "01 Coil Status")
                    {
                        modbusSerialSlave.DataStore.CoilDiscretes[i + 1] = value > 0 ? true : false;
                    }
                    if (functionSelect.Text == "02 Input Status")
                    {
                        modbusSerialSlave.DataStore.InputDiscretes[i + 1] = value > 0 ? true : false;
                    }
                    if (functionSelect.Text == "03 Holding Register")
                    {
                        modbusSerialSlave.DataStore.HoldingRegisters[i + 1] = value;
                    }
                    if (functionSelect.Text == "04 Input Registers")
                    {
                        modbusSerialSlave.DataStore.InputRegisters[i + 1] = value;
                    }
                }
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("连接失败:", ex.Message, "error", window);
            }
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
                    Task.Run(async () =>
                    {
                        while (serialPort.IsOpen)
                        {
                            updateDateTable();
                            RunSlave();
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
    }
}
