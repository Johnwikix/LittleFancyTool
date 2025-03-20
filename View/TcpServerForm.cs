using AntdUI;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View
{
    public partial class TcpServerForm : UserControl
    {
        private AntdUI.Window window;
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isServerRunning = false;
        private CancellationTokenSource cancellationTokenSource;
        private Socket clientSocket;
        private bool isConnectionOpen = false;
        private CancellationTokenSource receiveCancellationTokenSource;
        private IMessageService messageService = new MessageService();
        public TcpServerForm(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
            this.VisibleChanged += TcpServerForm_VisibleChanged;
            layoutChange();
            pollBox.CheckedChanged += PollBox_CheckedChanged;
            hexSendBox.CheckedChanged += HexSendBox_CheckedChanged;
        }

        private void HexSendBox_CheckedChanged(object sender, BoolEventArgs e)
        {
            string sendText = sendInput.Text;
            if (hexSendBox.Checked)
            {
                sendInput.Text = ToolMethod.ByteArrayToHexString(Encoding.UTF8.GetBytes(sendText));
            }
            else
            {
                try {                    
                    sendInput.Text = Encoding.UTF8.GetString(ToolMethod.HexStringToBytes(sendText));
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
                    if (modeSelect.SelectedIndex == 0)
                    {
                        if (isServerRunning)
                        {
                            server2client();
                        }
                        else
                        {
                            messageService.InternationalizationMessage("服务器未启动", null, "error", window);
                            pollBox.Checked = false;
                        }
                    }
                    if (modeSelect.SelectedIndex == 1)
                    {
                        if (isConnectionOpen)
                        {
                            client2server();
                        }
                        else
                        {
                            messageService.InternationalizationMessage("服务未连接", null, "error", window);
                            pollBox.Checked = false;
                        }                        
                    }
                    Task.Delay((int)pollIntervalInput.Value).Wait();
                }
            });
        }

        private void TcpServerForm_VisibleChanged(object sender, EventArgs e)
        {
            stopServer();
            stopConnection();
        }
        private void modeSelect_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            layoutChange();
        }

        private void layoutChange()
        {
            if (modeSelect.SelectedIndex == 0)
            {
                string hostName = Dns.GetHostName();
                IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
                foreach (IPAddress ip in hostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        addressInput.Text = ip.ToString();
                        break;
                    }
                }
                addressInput.ReadOnly = true;
                connectButton.Text = "启动服务";
                connectButton.LocalizationText = "startService";
                connectLabel.Text = "服务";
                stopConnection();
            }
            if (modeSelect.SelectedIndex == 1)
            {
                addressInput.ReadOnly = false;
                connectButton.Text = "连接";
                connectButton.LocalizationText = "connectButton";
                connectLabel.Text = "连接";
                stopServer();
            }
        }

        private void stopServer()
        {
            if (isServerRunning)
            {
                try
                {
                    cancellationTokenSource.Cancel();
                    foreach (TcpClient client in clients)
                    {
                        if (client.Connected)
                        {
                            client.Close();
                        }
                    }
                    clients.Clear();
                    if (server != null && server.Server.IsBound)
                    {
                        server.Stop();
                    }
                    messageService.InternationalizationMessage("服务器已停止", null, "success", window);
                    isServerRunning = false;
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("关闭服务器时出错:", ex.Message, "error", window);
                }
            }
        }

        private void stopConnection()
        {
            if (isConnectionOpen)
            {
                try
                {
                    if (receiveCancellationTokenSource != null && !receiveCancellationTokenSource.IsCancellationRequested)
                    {
                        receiveCancellationTokenSource.Cancel();
                    }

                    if (clientSocket != null && clientSocket.Connected)
                    {
                        clientSocket.Shutdown(SocketShutdown.Both);
                        clientSocket.Close();
                    }
                    messageService.InternationalizationMessage("连接关闭", null, "success", window);
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("连接关闭时出错:", ex.Message, "error", window);
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (modeSelect.SelectedIndex == 0)
            {
                startServer();
            }
            if (modeSelect.SelectedIndex == 1)
            {
                Task.Run(() => connect2server());
            }
        }

        private void connect2server()
        {
            if (!isConnectionOpen)
            {
                try
                {
                    string serverIp = addressInput.Text;
                    connectButton.Loading = true;
                    int serverPort = int.Parse(portInput.Text);
                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPAddress ipAddress = IPAddress.Parse(serverIp);
                    IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, serverPort);
                    clientSocket.Connect(remoteEndPoint);
                    messageService.InternationalizationMessage("已连接到服务器", null, "success", window);
                    receiveCancellationTokenSource = new CancellationTokenSource();
                    Task.Run(() => ReceiveMessages(receiveCancellationTokenSource.Token));
                    connectButton.Text = "断开";
                    connectButton.LocalizationText = "disconnect";
                    isConnectionOpen = true;
                    connectButton.Loading = false;
                }
                catch (Exception ex)
                {
                    connectButton.Loading = false;
                    messageService.InternationalizationMessage("连接服务器时出错:", ex.Message, "error", window);
                }
            }
            else
            {
                connectButton.Text = "连接";
                connectButton.LocalizationText = "connectButton";
                stopConnection();
                isConnectionOpen = false;
            }
        }

        private void ReceiveMessages(CancellationToken cancellationToken)
        {
            try
            {
                byte[] receiveData = new byte[8192];
                while (!cancellationToken.IsCancellationRequested && clientSocket.Connected)
                {
                    if (clientSocket.Available > 0)
                    {
                        int bytesReceived = clientSocket.Receive(receiveData);
                        if (bytesReceived > 0)
                        {
                            if (hexDisBox.Checked)
                            {
                                string response = BitConverter.ToString(receiveData, 0, bytesReceived).Replace("-", " ");
                                receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} << {response}\r\n");
                            }
                            else {
                                string response = Encoding.UTF8.GetString(receiveData, 0, bytesReceived);
                                receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} << {response}\r\n");
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    messageService.InternationalizationMessage("接收消息时出错:", ex.Message, "error", window);
                }
            }
        }

        private void startServer()
        {
            if (!isServerRunning)
            {
                try
                {
                    int port = int.Parse(portInput.Text);
                    IPAddress ipAddress = IPAddress.Parse(addressInput.Text);
                    server = new TcpListener(ipAddress, port);
                    server.Start();
                    cancellationTokenSource = new CancellationTokenSource();
                    Task.Run(() => ListenForClients(cancellationTokenSource.Token));
                    messageService.InternationalizationMessage("服务器已启动，监听端口:", port.ToString(), "success", window);
                    connectButton.Text = "停止服务";
                    connectButton.LocalizationText = "stopService";
                    isServerRunning = true;
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("启动服务器时出错:", ex.Message, "error", window);
                }
            }
            else
            {
                stopServer();
                connectButton.Text = "启动服务";
                connectButton.LocalizationText = "startService";
                isServerRunning = false;
            }

        }

        private void ListenForClients(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    if (server.Pending())
                    {
                        TcpClient client = server.AcceptTcpClient();
                        client.ReceiveBufferSize = 8192;
                        clients.Add(client);
                        messageService.InternationalizationMessage("新客户端已连接，当前连接数:", clients.Count.ToString(), "success", window);
                        Task.Run(() => HandleClientComm(client, cancellationToken));
                    }
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("接受客户端连接时出错:", ex.Message, "error", window);
                }
            }
        }
        private void HandleClientComm(TcpClient client, CancellationToken cancellationToken)
        {
            NetworkStream clientStream = client.GetStream();
            byte[] message = new byte[8192];
            int bytesRead;
            while (!cancellationToken.IsCancellationRequested)
            {
                bytesRead = 0;
                try
                {
                    bytesRead = clientStream.Read(message, 0, 8192);
                }
                catch
                {
                    break;
                }
                if (bytesRead == 0)
                {
                    break;
                }
                if (hexDisBox.Checked)
                {
                    string response = BitConverter.ToString(message, 0, bytesRead).Replace("-", " ");
                    receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} << {response}\r\n");
                }
                else
                {
                    string response = Encoding.UTF8.GetString(message, 0, bytesRead);
                    receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} << {response}\r\n");
                }
            }
            clients.Remove(client);
            client.Close();
            messageService.InternationalizationMessage("客户端已断开连接，当前连接数:", clients.Count.ToString(), "success", window);
        }

        private void TcpServerForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            stopServer();
            stopConnection();
        }

        private void server2client()
        {
            if (clients.Count > 0)
            {
                try {
                    byte[] buffer;
                    if (hexSendBox.Checked)
                    {
                        buffer = ToolMethod.HexStringToBytes(sendInput.Text);
                    }
                    else
                    {
                        buffer = Encoding.UTF8.GetBytes(sendInput.Text);
                    }

                    foreach (TcpClient client in clients)
                    {
                        if (client.Connected)
                        {
                            try
                            {
                                NetworkStream stream = client.GetStream();
                                stream.Write(buffer, 0, buffer.Length);
                            }
                            catch (Exception ex)
                            {
                                messageService.InternationalizationMessage("发送消息给客户端时出错:", ex.Message, "error", window);
                            }
                        }
                    }
                    receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} >> {sendInput.Text}\r\n");
                } catch(Exception ex) {
                    messageService.InternationalizationMessage("发送消息时出错:", ex.Message, "error", window);
                }
                
            }
            else
            {
                pollBox.Checked = false;
                messageService.InternationalizationMessage("客户端未连接", null, "error", window);
            }
        }

        private void client2server()
        {
            byte[] sendData;
            try
            {
                if (hexSendBox.Checked)
                {
                    sendData = ToolMethod.HexStringToBytes(sendInput.Text);
                }
                else
                {
                    sendData = Encoding.UTF8.GetBytes(sendInput.Text);
                }
                if (isConnectionOpen)
                {
                    clientSocket.Send(sendData);
                    receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} >> {sendInput.Text}\r\n");
                }
                else
                {
                    pollBox.Checked = false;
                    messageService.InternationalizationMessage("服务未连接", null, "error", window);
                }
            }
            catch (Exception ex) {
                messageService.InternationalizationMessage("发送消息时出错:", ex.Message, "error", window);
            }                
            
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (modeSelect.SelectedIndex == 0)
                {
                    server2client();
                }
                if (modeSelect.SelectedIndex == 1)
                {
                    client2server();
                }
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("发送消息时出错:", ex.Message, "error", window);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            receivedInput1.Clear();
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            if (receivedInput1.Text != null)
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    DateTime now = DateTime.Now;
                    saveDialog.Filter = "数据|*.txt;";
                    saveDialog.DefaultExt = ".txt";
                    saveDialog.Title = "保存数据";
                    saveDialog.OverwritePrompt = true;
                    string formattedDateTime = now.ToString("yyyy_MM_dd HH_mm_ss");
                    saveDialog.FileName = $"tcp_received_data {formattedDateTime}";
                    if (saveDialog.ShowDialog(window) == DialogResult.OK)
                    {
                        Task.Run(() =>
                        {
                            string filePath = saveDialog.FileName;
                            try
                            {
                                File.WriteAllText(filePath, receivedInput1.Text);
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

