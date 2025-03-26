using AntdUI;
using LittleFancyTool.Models;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using LittleFancyTool.View.SubView;
using Modbus.Device;
using System;
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
        private PollTable pollTableObj;
        private List<PollTable> dataList = [];
        private List<PollTable> paddingList = [];
        private List<PollTable> combinedList = [];

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
            functionSelect.SelectedIndexChanged += functionSelect_SelectedIndexChanged;
            numRegistersInput.TextChanged += valueChange;
            addressInput.TextChanged += startAddrChange;
            slaveTable.CellButtonClick += Table_base_CellButtonClick;
        }

        private void startAddrChange(object? sender, EventArgs e)
        {
            slaveTable.DataSource = PaddingChange();
        }

        private List<PollTable> PaddingChange()
        {
            int padding = (int)addressInput.Value;
            paddingList = new List<PollTable>(padding);
            for (int i = 0; i < padding; i++)
            {
                paddingList.Add(new PollTable($"0x{i:X4}", "", DateTime.Now));
            }
            combinedList = paddingList.Concat(dataList).ToList();
            for (int i = 0; i < combinedList.Count; i++)
            {
                combinedList[i].address = $"0x{(i):X4}";
            }
            return combinedList;
        }

        private void valueChange(object? sender, EventArgs e)
        {
            if (numRegistersInput.Value > dataList.Count)
            {
                int startId = dataList.Count;
                for (int i = 0; i < numRegistersInput.Value - dataList.Count; i++)
                {
                    string address = $"0x{(startId + i):X4}";
                    dataList.Add(new PollTable(address, "0", DateTime.Now));
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

        private void functionSelect_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            numRegistersInput.Enabled = true;
            if (functionSelect.SelectedIndex > 3)
            {
                slaveTable.ClearMergedRegion();
                slaveTable.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("address", "寄存器地址").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("valueDec", "数值(DEC)").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("lastUpdate", "最后更新时间").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("btns", "操作").SetLocalizationTitleID("Table.Column."),
                };
                if (functionSelect.SelectedIndex == 4 || functionSelect.SelectedIndex == 5) {
                    GetPageData(1);
                    numRegistersInput.Value = 1;
                    numRegistersInput.Enabled = false;
                    combinedList = paddingList.Concat(dataList).ToList();
                    slaveTable.DataSource = combinedList;
                }
                if (functionSelect.SelectedIndex > 5)
                {
                    GetPageData((int)numRegistersInput.Value);
                    combinedList = paddingList.Concat(dataList).ToList();
                    slaveTable.DataSource = combinedList;
                }
            }
            else
            {
                slaveTable.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("address", "寄存器地址").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("valueDec", "数值(DEC)").SetLocalizationTitleID("Table.Column."),
                new AntdUI.Column("lastUpdate", "最后更新时间").SetLocalizationTitleID("Table.Column."),
                };
            }
        }

        private void Table_base_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            bool isCoils = false;
            if (functionSelect.SelectedIndex == 4 || functionSelect.SelectedIndex == 6) {
                isCoils = true;
            }
            var buttontext = e.Btn.Text;
            if (e.Record is PollTable pollTable)
            {
                pollTableObj = pollTable;
                switch (buttontext)
                {
                    case "Edit":
                        var form = new PollTableEdit(window, pollTableObj, isCoils) { Size = new Size(500, 300) };
                        AntdUI.Drawer.open(new AntdUI.Drawer.Config(window, form));
                        break;
                }
            }
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
            dataList = new List<PollTable>(regNum);
            for (int i = 0; i < regNum; i++) {
                dataList.Add(new PollTable($"0x{i:X4}", "0", DateTime.Now));
            }            
            return dataList;
        }

        private async Task pollingAsync(int time)
        {
            while (isPolling)
            {
                try
                {
                    ++txCount;
                    TXStatusLabel.Text = $"TX={txCount} Err={errCount}";
                    if (functionSelect.SelectedIndex <= 3)
                    {
                        listenPortAsync();
                    }
                    else
                    {
                        WriteDataAsync();
                    }
                }
                catch (Exception ex)
                {
                    errCount++;
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

        private void WriteDataAsync()
        {
            List<PollTable> data = dataList;
            try
            {
                if (functionSelect.SelectedIndex == 4)
                {
                    modbusMaster.WriteSingleCoil((byte)slaveIdInput.Value, (ushort)addressInput.Value, data[0].valueDec == "1" ? true : false);
                }
                if (functionSelect.SelectedIndex == 5)
                {
                    modbusMaster.WriteSingleRegister((byte)slaveIdInput.Value, (ushort)addressInput.Value, ushort.Parse(data[0].valueDec));
                }                
                if (functionSelect.SelectedIndex == 6){
                    bool[] coils = new bool[data.Count];
                    for (int i = 0; i < data.Count; i++)
                    {  
                        coils[i] = data[i].valueDec == "1" ? true : false;                               
                    }
                    modbusMaster.WriteMultipleCoils((byte)slaveIdInput.Value, (ushort)addressInput.Value, coils);
                }
                if (functionSelect.SelectedIndex == 7)
                {
                    ushort[] registers = new ushort[data.Count];
                    for (int i = 0; i < data.Count; i++)
                    {    
                        registers[i] = ushort.Parse(data[i].valueDec);                                     
                    }
                    modbusMaster.WriteMultipleRegisters((byte)slaveIdInput.Value, (ushort)addressInput.Value, registers);
                }
            }
            catch (Exception ex)
            {
                errCount++;
                Debug.WriteLine(ex.Message);
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
                        dataList = list;
                        combinedList = paddingList.Concat(dataList).ToList();
                        slaveTable.DataSource = combinedList;
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
                        dataList = oldList;
                        combinedList = paddingList.Concat(dataList).ToList();
                        slaveTable.DataSource = combinedList;
                    }
                }
            });
        }
    }
}
