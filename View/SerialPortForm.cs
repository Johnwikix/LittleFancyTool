using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LittleFancyTool.View
{
    public partial class SerialPortForm : UserControl
    {
        private List<byte> receiveBuffer = new List<byte>();
        private SerialPort serialPort = new SerialPort();
        private AntdUI.Window window;
        private enum EncodingMode
        {
            Auto,
            UTF8,
            ASCII,
            GB2312,
            Hex,
        }
        public SerialPortForm(AntdUI.Window _window)
        {
            this.window = _window;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
            InitializeSerialPort();
            RefreshPortList();
        }

        private void InitializeSerialPort()
        {
            serialPort.DataReceived += SerialPort_DataReceived;
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
                statusInput.Clear();
                connectButton.Type = AntdUI.TTypeMini.Success;
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
                    if (rs485checkbox.Checked)
                    {
                        serialPort.RtsEnable = true; 
                        serialPort.Handshake = Handshake.RequestToSend;
                    }
                    else {
                        serialPort.RtsEnable = true;
                        serialPort.Handshake = Handshake.None;
                    }
                    // 配置串口参数
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
                    connectButton.Type = AntdUI.TTypeMini.Error;
                    statusInput.Text = $"已连接 {serialPort.PortName} [Baud:{serialPort.BaudRate} " +
                        $"Parity:{serialPort.Parity} DataBits:{serialPort.DataBits} " +
                        $"StopBits:{serialPort.StopBits}]";
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"连接失败: {ex.Message}", autoClose: 3);
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
        }

        private Task sendMessage()
        {
            return Task.Run(() => {
                try
                {
                    byte[] sendData = GetEncodedData(sendInput.Text + "\r\n",
                    (EncodingMode)sendSelect.SelectedIndex);
                    serialPort.Write(sendData, 0, sendData.Length);
                    sendHisInput.Text = sendInput.Text;
                    sendInput.Clear();
                    sendBtn.Loading = false;
                }
                catch (Exception ex)
                {
                    sendBtn.Loading = false;
                    AntdUI.Message.error(window, ex.Message+ "可能对方设备不支持 RTS/CTS 握手协议。", autoClose: 3);
                }
            });
        }

        private Encoding GetGBEncoding()
        {
            try
            {
                return Encoding.GetEncoding("GB18030");
            }
            catch (ArgumentException)
            {
                return Encoding.Default;
            }
        }

        private byte[] GetEncodedData(string input, EncodingMode mode)
        {
            switch (mode)
            {
                case EncodingMode.Auto:
                    return Encoding.Default.GetBytes(input);
                case EncodingMode.ASCII:
                    return Encoding.ASCII.GetBytes(input);
                case EncodingMode.UTF8:
                    return Encoding.UTF8.GetBytes(input);
                case EncodingMode.GB2312:
                    Encoding gbEncoder = GetGBEncoding();
                    return gbEncoder.GetBytes(input);
                default:
                    throw new ArgumentException("不支持的编码类型");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytesToRead = serialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                serialPort.Read(buffer, 0, bytesToRead);
                receiveBuffer.AddRange(buffer);
                byte[] data = null;
                if (buffer != null && buffer.Length >= 2)
                {
                    byte lastByte = buffer[buffer.Length - 1];
                    byte secondLastByte = buffer[buffer.Length - 2];
                    if (lastByte == 13 || lastByte ==10)
                    {
                        data = receiveBuffer.ToArray();
                        receiveBuffer.Clear();
                    }
                }
                if (data != null)
                {
                    AppendDataView("接收", data);
                }
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(window, ex.Message, autoClose: 3);
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
            sb.AppendLine($"{DateTime.Now:HH:mm:ss} - {prefix}数据:");

            int recvMode = receivedModeSelect.SelectedIndex;

            switch ((EncodingMode)recvMode)
            {
                case EncodingMode.Auto:
                    sb.AppendLine(DetectBestEncoding(data).GetString(data));
                    break;
                case EncodingMode.Hex:
                    sb.AppendLine(ByteArrayToHexString(data));
                    break;
                case EncodingMode.ASCII:
                    sb.AppendLine(Encoding.ASCII.GetString(data));
                    break;
                case EncodingMode.UTF8:
                    sb.AppendLine(Encoding.UTF8.GetString(data));
                    break;
                case EncodingMode.GB2312:
                    sb.AppendLine(Encoding.GetEncoding("GB18030").GetString(data));
                    break;
            }


            receivedInput.AppendText(sb.ToString() + Environment.NewLine);
        }

        private Encoding DetectBestEncoding(byte[] data)
        {
            string testGB = Encoding.GetEncoding("GB18030").GetString(data.ToArray());
            if (IsPrintable(testGB))
            {
                return Encoding.GetEncoding("GB18030");
            }
            string testUTF8 = Encoding.UTF8.GetString(data.ToArray());
            if (IsPrintable(testUTF8))
            {
                return Encoding.UTF8;
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

        private string ByteArrayToHexString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", " ");
        }
    }
}
