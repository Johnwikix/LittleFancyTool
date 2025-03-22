using AntdUI;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using System.IO.Ports;
using System.Text;
using static LittleFancyTool.Utils.ToolMethod;

namespace LittleFancyTool.View
{
    public partial class SerialPortForm : UserControl
    {
        private List<byte> receiveBuffer = new List<byte>();
        private readonly object bufferLock = new object();
        private SerialPort serialPort = new SerialPort();
        private AntdUI.Window window;
        private System.Timers.Timer dataTimeoutTimer;
        private IMessageService messageService = new MessageService();

        public SerialPortForm(AntdUI.Window _window)
        {
            this.window = _window;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
            RefreshPortList();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            pollBox.CheckedChanged += PollBox_CheckedChanged;
            hexSendBox.CheckedChanged += HexSendBox_CheckedChanged;
            receivedInput.TextChanged += (s, e) => receivedInput.ScrollToCaret(); ;
        }

        private void HexSendBox_CheckedChanged(object sender, BoolEventArgs e)
        {
            EncodingMode encodingMode = (EncodingMode)sendSelect.SelectedIndex;
            string sendText = sendInput.Text;
            if (hexSendBox.Checked)
            {
                sendInput.Text = ByteArrayToHexString(GetEncodedData(sendText, encodingMode));
            }
            else
            {
                try
                {
                    sendInput.Text = GetEncoding(encodingMode).GetString(HexStringToBytes(sendText));
                }
                catch (Exception)
                {
                    messageService.InternationalizationMessage("无效的十六进制字符串", null, "error", window);
                    hexSendBox.Checked = true;
                    sendInput.Text = sendText;
                }
            }
        }

        private void PollBox_CheckedChanged(object sender, BoolEventArgs e)
        {
            Task.Run(() =>
            {
                while (pollBox.Checked)
                {
                    if (serialPort.IsOpen)
                    {
                        sendMessage().Wait();
                        Task.Delay((int)pollIntervalInput.Value).Wait();
                    }
                    else
                    {
                        pollBox.Checked = false;
                        messageService.InternationalizationMessage("请先打开串口连接", null, "warn", window);
                    }
                }
            });
        }

        private void InitializeSerialPort()
        {
            serialPort.DataReceived += SerialPort_DataReceived;
            dataTimeoutTimer = new System.Timers.Timer(int.Parse(timeLimitInput.Text));
            dataTimeoutTimer.AutoReset = false;
            dataTimeoutTimer.Elapsed += DataTimeoutTimer_Elapsed;
        }

        private void DataTimeoutTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                byte[] data = null;
                lock (bufferLock)
                {
                    if (receiveBuffer.Count > 0)
                    {
                        data = receiveBuffer.ToArray();
                        receiveBuffer.Clear();
                    }
                }
                if (data != null)
                {
                    AppendDataView("超时", data);
                }
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
            }
        }

        private void RefreshPortList()
        {
            portSelect.Items.Clear();
            portSelect.Items.AddRange(SerialPort.GetPortNames());
            if (portSelect.Items.Count > 0)
                portSelect.SelectedIndex = 0;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                connectButton.Text = "连接";
                connectButton.LocalizationText = "connectButton";
                statusInput.Clear();
                connectButton.Type = AntdUI.TTypeMini.Success;
            }
            else
            {
                if (portSelect.SelectedValue == null)
                {
                    messageService.InternationalizationMessage("请选择有效串口:", null, "warn", window);
                    return;
                }
                try
                {
                    InitializeSerialPort();
                    serialPort.RtsEnable = rs485checkbox.Checked;
                    serialPort.DtrEnable = dtrBox.Checked;
                    serialPort.Handshake = Handshake.None;
                    serialPort.PortName = portSelect.SelectedValue.ToString();
                    serialPort.BaudRate = int.Parse(baudRateSelect.SelectedValue.ToString());
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity),
                        paritySelect.SelectedValue.ToString());
                    serialPort.DataBits = int.Parse(dataBitsSelect.SelectedValue.ToString());
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits),
                        stopBitsSelect.SelectedValue.ToString());
                    serialPort.WriteTimeout = 2000;
                    serialPort.Open();
                    connectButton.Text = "断开";
                    connectButton.LocalizationText = "disconnect";
                    connectButton.Type = AntdUI.TTypeMini.Error;
                    statusInput.Text = $"已连接 {serialPort.PortName}\r\nBaud:{serialPort.BaudRate}\r\n" +
                        $"Parity:{serialPort.Parity}\r\nDataBits:{serialPort.DataBits}\r\n" +
                        $"StopBits:{serialPort.StopBits}";
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("连接失败:", ex.Message, "error", window);
                }
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                sendBtn.Loading = true;
                sendMessage();
            }
            else
            {
                messageService.InternationalizationMessage("请先打开串口连接", null, "warn", window);
            }
        }

        private Task sendMessage()
        {
            return Task.Run(() =>
            {
                try
                {
                    string sendText = sendInput.Text;
                    serialPort.RtsEnable = rs485checkbox.Checked;
                    serialPort.DtrEnable = dtrBox.Checked;
                    byte[] sendData;
                    if (hexSendBox.Checked)
                    {
                        sendData = ToolMethod.HexStringToBytes(sendInput.Text);
                    }
                    else
                    {
                        sendData = ToolMethod.GetEncodedData(sendText + "\r\n", (EncodingMode)sendSelect.SelectedIndex);
                    }
                    serialPort.Write(sendData, 0, sendData.Length);
                    receivedInput.AppendText($"{DateTime.Now:HH:mm:ss} >> {sendText}\r\n");
                    sendBtn.Loading = false;
                }
                catch (Exception ex)
                {
                    sendBtn.Loading = false;
                    messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
                }
            });
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                dataTimeoutTimer.Stop();
                int bytesToRead = serialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                serialPort.Read(buffer, 0, bytesToRead);
                lock (bufferLock)
                {
                    receiveBuffer.AddRange(buffer);
                    byte[] data = null;
                    if (buffer != null && buffer.Length >= 2)
                    {
                        byte lastByte = buffer[buffer.Length - 1];
                        byte secondLastByte = buffer[buffer.Length - 2];
                        if (lastByte == 13 || lastByte == 10)
                        {
                            data = receiveBuffer.ToArray();
                            receiveBuffer.Clear();
                        }
                    }

                    if (data != null)
                    {
                        AppendDataView("接收", data);
                    }
                    if (receiveBuffer.Count > 0)
                    {
                        dataTimeoutTimer.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }
        private void AppendDataView(string prefix, byte[] data)
        {
            if (receivedInput.InvokeRequired)
            {
                receivedInput.Invoke(new Action(() =>
                    AppendDataView(prefix, data)));
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append($"{DateTime.Now:HH:mm:ss} << ");

            int recvMode = receivedModeSelect.SelectedIndex;
            if (hexDisBox.Checked)
            {
                sb.Append(ToolMethod.ByteArrayToHexString(data));
            }
            else
            {
                switch ((EncodingMode)recvMode)
                {
                    case EncodingMode.Auto:
                        sb.Append(DetectBestEncoding(data).GetString(data));
                        break;
                    case EncodingMode.ASCII:
                        sb.Append(Encoding.ASCII.GetString(data));
                        break;
                    case EncodingMode.UTF8:
                        sb.Append(Encoding.UTF8.GetString(data));
                        break;
                    case EncodingMode.GB2312:
                        sb.Append(Encoding.GetEncoding("GB18030").GetString(data));
                        break;
                }
            }
            if (prefix == "超时")
            {
                receivedInput.AppendText(sb.ToString() + "\r\n");
            }
            else
            {
                receivedInput.AppendText(sb.ToString());
            }

        }

        private Encoding DetectBestEncoding(byte[] data)
        {
            string testGB = Encoding.GetEncoding("GB18030").GetString(data.ToArray());
            string testUTF8 = Encoding.UTF8.GetString(data.ToArray());
            if (IsPrintable(testUTF8))
            {
                return Encoding.UTF8;
            }
            if (IsPrintable(testGB))
            {
                return Encoding.GetEncoding("GB18030");
            }
            return Encoding.ASCII;
        }

        private bool IsPrintable(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                    return false;
            }
            return true;
        }

        private void clearDataBtn_Click(object sender, EventArgs e)
        {
            receivedInput.Clear();
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            if (receivedInput.Text != null)
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    DateTime now = DateTime.Now;
                    saveDialog.Filter = "数据|*.txt;";
                    saveDialog.DefaultExt = ".txt";
                    saveDialog.Title = "保存数据";
                    saveDialog.OverwritePrompt = true;
                    string formattedDateTime = now.ToString("yyyy_MM_dd HH_mm_ss");
                    saveDialog.FileName = $"serial_received_data {formattedDateTime}";
                    if (saveDialog.ShowDialog(window) == DialogResult.OK)
                    {
                        Task.Run(() =>
                        {
                            string filePath = saveDialog.FileName;
                            try
                            {
                                File.WriteAllText(filePath, receivedInput.Text);
                                messageService.InternationalizationMessage("数据已保存至：",
                                    saveDialog.FileName,
                                    "success",
                                    window);
                            }
                            catch (Exception ex)
                            {
                                messageService.InternationalizationMessage("数据保存出错：",
                                    ex.Message,
                                    "error",
                                    window);
                            }
                        });
                    }
                }
            }
            else
            {
                messageService.InternationalizationMessage("没有数据可供保存", null, "warn", window);
            }
        }
    }
}
