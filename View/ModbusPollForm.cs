using LittleFancyTool.Languages;
using Modbus.Device;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO.Ports;

namespace LittleFancyTool.View
{
    public partial class ModbusPollForm : UserControl
    {
        private SerialPort serialPort = new SerialPort();
        private ModbusSerialMaster modbusMaster;
        private AntdUI.Window window;
        private bool isPolling = false;
        private DataTable _registerDataTable;
        private readonly object _dataLock = new object();
        private int txCount = 0;
        private int errCount = 0;

        public ModbusPollForm(AntdUI.Window _window)
        {
            this.window = _window;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            InitializeComponent();
            RefreshPortList();
            _registerDataTable = new DataTable("ModbusData");
            _registerDataTable.Columns.AddRange(new[]
            {
                new DataColumn("address", typeof(string)),
                new DataColumn("value", typeof(ushort)),
                new DataColumn("updateTime", typeof(DateTime))
            });
            slaveDataGridView.DataSource = _registerDataTable;
            ConfigureDataGridView();
            TXStatusLabel.Text = $"TX={txCount} Err={errCount}";
        }

        private void ConfigureDataGridView()
        {
            // 列配置
            slaveDataGridView.AutoGenerateColumns = false;
            slaveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            slaveDataGridView.Columns.Clear();
            slaveDataGridView.ForeColor = Color.Black;

            string systemLanguage = CultureInfo.CurrentCulture.Name;
            if (systemLanguage.StartsWith("zh"))
            {
                slaveDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "address",
                    HeaderText = "寄存器地址",
                    FillWeight = 25
                });

                slaveDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "value",
                    HeaderText = "数值 (DEC)",
                    FillWeight = 20
                });

                slaveDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "updateTime",
                    HeaderText = "最后更新时间",
                    FillWeight = 55
                });
            }
            else
            {
                slaveDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "address",
                    HeaderText = "Reg Address",
                    FillWeight = 25
                });

                slaveDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "value",
                    HeaderText = "Value (DEC)",
                    FillWeight = 20
                });

                slaveDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "updateTime",
                    HeaderText = "Last Update Time",
                    FillWeight = 55
                });
            }           

            DataGridViewColumn dateTimeColumn = slaveDataGridView.Columns[2];
            dateTimeColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
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
                    AntdUI.Message.error(window, $"数据读取失败: {ex.Message}", autoClose: 3);
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
                    AntdUI.Message.error(window, "请选择有效串口", autoClose: 3);
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
                    await pollingAsync(time);                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"连接失败: {ex.Message}", autoClose: 3);
                }
            }
        }

        private async void listenPortAsync()
        {
            if (!ValidateInputs())
                return;

            byte slaveId = byte.Parse(slaveIdInput.Text);
            ushort startAddress = ushort.Parse(addressInput.Text);
            ushort numRegisters = ushort.Parse(numRegistersInput.Text);
            try
            {
                var registers = await modbusMaster.ReadHoldingRegistersAsync(slaveId, startAddress, numRegisters);
                outputInput.AppendText($"读取成功: {string.Join(", ", registers)}\r\n");
                UpdateDataGridView(startAddress, registers);
            }
            catch (OperationCanceledException ex)
            {
                Debug.WriteLine($"操作被取消: {ex.Message}");
            }
            catch (Exception ex)
            {
                errCount++;
                TXStatusLabel.Text = $"TX={txCount} Err={errCount}";
                //AntdUI.Message.error(window, $"port读取失败: {ex.Message}", autoClose: 3);
            }
        }

        private bool ValidateInputs()
        {
            if (modbusMaster == null || !serialPort.IsOpen)
            {
                AntdUI.Message.error(window, "请先打开串口连接", autoClose: 3);
                return false;
            }
            return true;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }

        private void UpdateDataGridView(ushort startAddress, ushort[] registers)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lock (_dataLock)
                {
                    var now = DateTime.Now;
                    if (_registerDataTable.Rows.Count != registers.Length)
                    {
                        _registerDataTable.Rows.Clear();
                        for (int i = 0; i < registers.Length; i++)
                        {
                            var address = startAddress + i;
                            _registerDataTable.Rows.Add(
                                $"0x{address:X4}",
                                registers[i],
                                now
                            );
                        }
                    }
                    else
                    {
                        slaveDataGridView.SuspendLayout();
                        for (int i = 0; i < registers.Length; i++)
                        {
                            var row = _registerDataTable.Rows[i];
                            if ((ushort)row["值"] != registers[i])
                            {
                                row.BeginEdit();
                                row["值"] = registers[i];
                                row["更新时间"] = now;
                                row.EndEdit();
                                slaveDataGridView.Rows[i].Cells[1].Style.BackColor = Color.LightYellow;
                            }
                        }
                        slaveDataGridView.ResumeLayout();
                    }
                }
            });
        }
    }
}
