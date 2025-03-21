using AntdUI;
using LittleFancyTool.Models;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View
{
    public partial class TcpServerForm : UserControl
    {
        private AntdUI.Window window;
        private bool isServerRunning = false;
        private Socket? currentSocketClient;
        private bool isConnectionOpen = false;
        private CancellationTokenSource? receiveCancellationTokenSource;
        private IMessageService messageService = new MessageService();
        private Socket? serverSocket;
        private List<Socket> clientSockets = new List<Socket>();
        private CancellationTokenSource? listenCts;
        private List<SocketClient> clientList = new List<SocketClient>();


        public TcpServerForm(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
            this.VisibleChanged += TcpServerForm_VisibleChanged;
            layoutChange();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            InitialClientTableData();
            pollBox.CheckedChanged += PollBox_CheckedChanged;
            hexSendBox.CheckedChanged += HexSendBox_CheckedChanged;
            receivedInput1.TextChanged += (s, e) => receivedInput1.ScrollToCaret();
        }

        private void InitialClientTableData()
        {
            socketClientTable.Visible = false;
            socketClientTable.Columns = new AntdUI.ColumnCollection {
                new Column("address", "客户端地址").SetLocalizationTitleID("Table.Column."),
                new ColumnSwitch("Enabled", "回复", ColumnAlign.Left){
                    //支持点击回调
                    Call= (value,record, i_row, i_col) =>{
                        return value;
                    }
                }.SetFixed().SetWidth("auto").SetLocalizationTitleID("Table.Column.Res."),
            };
            socketClientTable.DataSource = clientList;
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
                try
                {
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
                            SocketsServer2Client();
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

        private void TcpServerForm_VisibleChanged(object? sender, EventArgs e)
        {
            StopSocketServer();
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
                socketClientTable.Visible = true;
                stopConnection();
            }
            if (modeSelect.SelectedIndex == 1)
            {
                addressInput.ReadOnly = false;
                connectButton.Text = "连接";
                connectButton.LocalizationText = "connectButton";
                connectLabel.Text = "连接";
                socketClientTable.Visible = false;
                StopSocketServer();
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

                    if (currentSocketClient != null && currentSocketClient.Connected)
                    {
                        currentSocketClient.Shutdown(SocketShutdown.Both);
                        currentSocketClient.Close();
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
                SocketsStartServer();
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
                    connectButton.Enabled = false;
                    int serverPort = int.Parse(portInput.Text);
                    currentSocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPAddress ipAddress = IPAddress.Parse(serverIp);
                    IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, serverPort);
                    currentSocketClient.Connect(remoteEndPoint);
                    messageService.InternationalizationMessage("已连接到服务器", null, "success", window);
                    receiveCancellationTokenSource = new CancellationTokenSource();
                    Task.Run(() => ReceiveMessages(receiveCancellationTokenSource.Token));
                    connectButton.Text = "断开";
                    connectButton.Type = AntdUI.TTypeMini.Error;
                    connectButton.LocalizationText = "disconnect";
                    isConnectionOpen = true;
                    connectButton.Loading = false;
                    connectButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    connectButton.Loading = false;
                    connectButton.Enabled = true;
                    messageService.InternationalizationMessage("连接服务器时出错:", ex.Message, "error", window);
                }
            }
            else
            {
                connectButton.Text = "连接";
                connectButton.LocalizationText = "connectButton";
                connectButton.Type = AntdUI.TTypeMini.Success;
                stopConnection();
                isConnectionOpen = false;
            }
        }

        private void ReceiveMessages(CancellationToken cancellationToken)
        {
            try
            {
                byte[] receiveData = new byte[8192];
                while (!cancellationToken.IsCancellationRequested && currentSocketClient.Connected)
                {
                    int bytesReceived = currentSocketClient.Receive(receiveData);
                    if (bytesReceived == 0)
                    {
                        // 远程主机已关闭连接
                        messageService.InternationalizationMessage("远程主机已关闭连接", null, "info", window);
                        currentSocketClient.Close();
                        connectButton.Text = "连接";
                        connectButton.LocalizationText = "connectButton";
                        connectButton.Type = AntdUI.TTypeMini.Success;
                        isConnectionOpen = false;
                        break;
                    }
                    if (bytesReceived > 0)
                    {
                        if (hexDisBox.Checked)
                        {
                            string response = BitConverter.ToString(receiveData, 0, bytesReceived).Replace("-", " ");
                            receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} << {response}\r\n");
                        }
                        else
                        {
                            string response = Encoding.UTF8.GetString(receiveData, 0, bytesReceived);
                            receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} << {response}\r\n");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    currentSocketClient.Close();
                    connectButton.Text = "连接";
                    connectButton.LocalizationText = "connectButton";
                    connectButton.Type = AntdUI.TTypeMini.Success;
                    isConnectionOpen = false;
                    messageService.InternationalizationMessage("接收消息时出错:", ex.Message, "error", window);
                }
            }
            finally
            {
                currentSocketClient.Close();
            }
        }

        private void SocketsStartServer()
        {
            if (!isServerRunning)
            {
                try
                {
                    int port = int.Parse(portInput.Text);
                    serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPAddress ipAddress = IPAddress.Parse(addressInput.Text);
                    IPEndPoint localEndPoint = new IPEndPoint(ipAddress, port);
                    serverSocket.Bind(localEndPoint);
                    serverSocket.Listen(10);
                    listenCts = new CancellationTokenSource();
                    Task.Run(() => ListenForClientsAsync(listenCts.Token));
                    messageService.InternationalizationMessage("服务器已启动，监听端口:", port.ToString(), "success", window);
                    connectButton.Text = "停止服务";
                    connectButton.Type = AntdUI.TTypeMini.Error;
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
                StopSocketServer();
                connectButton.Text = "启动服务";
                connectButton.Type = AntdUI.TTypeMini.Success;
                connectButton.LocalizationText = "startService";
                isServerRunning = false;
            }
        }

        private void ListenForClientsAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    Socket client = serverSocket.Accept();
                    clientSockets.Add(client);
                    clientList.Add(new SocketClient(client.RemoteEndPoint.ToString(), true));
                    socketClientTable.Visible = true;
                    socketClientTable.DataSource = clientList;
                    messageService.InternationalizationMessage("新客户端已连接，当前连接数:", clientSockets.Count.ToString(), "success", window);
                    Task.Run(() => HandleClientAsync(client, cancellationToken));
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (SocketException)
                {
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("接受客户端连接时出错:", ex.Message, "success", window);
                    break;
                }
            }
        }

        private void HandleClientAsync(Socket clientSocket, CancellationToken cancellationToken)
        {
            try
            {
                byte[] buffer = new byte[8192];
                while (!cancellationToken.IsCancellationRequested)
                {
                    int bytesRead = clientSocket.Receive(buffer);
                    if (bytesRead == 0)
                    {
                        clientSockets.Remove(clientSocket);
                        messageService.InternationalizationMessage("客户端已断开连接:", clientSocket.RemoteEndPoint.ToString(), "info", window);
                        clientList.Remove(clientList.Find(x => x.address == clientSocket.RemoteEndPoint.ToString()));
                        if (clientList.Count == 0)
                        {
                            socketClientTable.Visible = false;
                        }
                        socketClientTable.DataSource = clientList;
                        break;
                    }
                    if (bytesRead > 0)
                    {
                        if (hexDisBox.Checked)
                        {
                            string response = BitConverter.ToString(buffer, 0, bytesRead).Replace("-", " ");
                            receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} << {response}\r\n");
                        }
                        else
                        {
                            string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} << {response}\r\n");
                        }

                        // 广播消息给所有客户端
                        //foreach (Socket c in clientSockets)
                        //{
                        //    if (c != clientSocket && c.Connected)
                        //    {
                        //        byte[] msgBytes = buffer.ToArray();
                        //        await Task.Run(() => c.Send(msgBytes), cancellationToken);
                        //    }
                        //}
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // 任务被取消
            }
            catch (SocketException)
            {
                // 客户端断开连接
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("处理客户端消息时出错:", ex.Message, "error", window);
            }
            finally
            {
                clientSockets.Remove(clientSocket);
                clientSocket.Close();
            }
        }

        private void SocketsServer2Client()
        {
            if (clientSockets.Count > 0)
            {
                try
                {
                    byte[] buffer;
                    if (hexSendBox.Checked)
                    {
                        buffer = ToolMethod.HexStringToBytes(sendInput.Text);
                    }
                    else
                    {
                        buffer = Encoding.UTF8.GetBytes(sendInput.Text);
                    }

                    byte[] msgBytes = buffer.ToArray();
                    int count = 0;

                    foreach (SocketClient client in clientList)
                    {
                        if (client.Enabled)
                        {
                            Socket clientSocket = clientSockets.Find(x => x.RemoteEndPoint.ToString() == client.address);
                            if (clientSocket.Connected)
                            {
                                clientSocket.Send(msgBytes);
                            }
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} >> {sendInput.Text}\r\n");
                    }
                    else
                    {
                        messageService.InternationalizationMessage("没有选中的客户端连接", null, "warn", window);
                    }

                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("发送消息给客户端时出错:", ex.Message, "error", window);
                }
            }
            else
            {
                pollBox.Checked = false;
                messageService.InternationalizationMessage("客户端未连接", null, "error", window);
            }
        }

        private void StopSocketServer()
        {
            if (isServerRunning)
            {
                try
                {
                    if (listenCts != null && !listenCts.IsCancellationRequested)
                    {
                        listenCts.Cancel();
                    }
                    foreach (Socket clientSocket in clientSockets)
                    {
                        if (clientSocket.Connected)
                        {
                            clientSocket.Close();
                        }
                    }
                    clientSockets.Clear();

                    if (serverSocket != null && serverSocket.IsBound)
                    {
                        serverSocket.Close();
                    }
                    clientList.Clear();
                    socketClientTable.DataSource = clientList;
                    messageService.InternationalizationMessage("服务器已停止", null, "success", window);
                    isServerRunning = false;
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("关闭服务器时出错:", ex.Message, "error", window);
                }
            }
        }


        private void TcpServerForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            StopSocketServer();
            stopConnection();
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
                    currentSocketClient.Send(sendData);
                    receivedInput1.AppendText($"{DateTime.Now:HH:mm:ss} >> {sendInput.Text}\r\n");
                }
                else
                {
                    pollBox.Checked = false;
                    messageService.InternationalizationMessage("服务未连接", null, "error", window);
                }
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("发送消息时出错:", ex.Message, "error", window);
            }

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (modeSelect.SelectedIndex == 0)
                {
                    SocketsServer2Client();
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

