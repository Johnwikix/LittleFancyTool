using AntdUI;
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
        private Thread listenThread;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isServerRunning = false;
        private CancellationTokenSource cancellationTokenSource;
        private Socket clientSocket;
        private Thread receiveThread;
        private bool isConnectionOpen = false;
        private CancellationTokenSource receiveCancellationTokenSource;
        public TcpServerForm(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
            this.Load += TcpServerForm_Load;
            this.VisibleChanged += TcpServerForm_VisibleChanged;
            layoutChange();
        }

        private void TcpServerForm_Load(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.FormClosing += TcpServerForm_FormClosing;
            }
        }

        private void TcpServerForm_VisibleChanged(object sender, EventArgs e) {
            stopServer();
            stopConnection();
        }
        private void modeSelect_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            layoutChange();
        }

        private void layoutChange() {
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
                connectLabel.Text = "服务";
                stopConnection();
            }
            if (modeSelect.SelectedIndex == 1)
            {
                connectButton.Text = "连接";
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
                    if (listenThread != null && listenThread.IsAlive)
                    {
                        listenThread.Join();
                    }
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
                    AntdUI.Message.success(window, "服务器已停止", autoClose: 3);
                    isServerRunning = false;
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"关闭服务器时出错: {ex.Message}", autoClose: 3);
                }
            }
        }

        private void stopConnection() {
            if (isConnectionOpen)
            {
                try
                {
                    if (receiveCancellationTokenSource != null && !receiveCancellationTokenSource.IsCancellationRequested)
                    {
                        receiveCancellationTokenSource.Cancel();
                    }

                    if (receiveThread != null && receiveThread.IsAlive)
                    {
                        receiveThread.Join();
                    }

                    if (clientSocket != null && clientSocket.Connected)
                    {
                        clientSocket.Shutdown(SocketShutdown.Both);
                        clientSocket.Close();
                    }
                    AntdUI.Message.success(window,"连接关闭", autoClose: 3);
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"关闭连接时出错: {ex.Message}", autoClose: 3);
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (modeSelect.SelectedIndex == 0) {
                startServer();
            }
            if (modeSelect.SelectedIndex == 1) {
                connect2server();
            }
        }

        private void connect2server() {
            if (!isConnectionOpen)
            {
                try
                {
                    string serverIp = addressInput.Text;
                    int serverPort = int.Parse(portInput.Text);
                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPAddress ipAddress = IPAddress.Parse(serverIp);
                    IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, serverPort);
                    clientSocket.Connect(remoteEndPoint);
                    AntdUI.Message.success(window, "已连接到服务器", autoClose: 3);
                    receiveCancellationTokenSource = new CancellationTokenSource();
                    receiveThread = new Thread(() => ReceiveMessages(receiveCancellationTokenSource.Token));
                    receiveThread.Start();
                    connectButton.Text = "断开";
                    isConnectionOpen = true;
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"连接服务器时出错: {ex.Message}", autoClose: 3);
                }
            }
            else {
                connectButton.Text = "连接";
                stopConnection();
                isConnectionOpen = false;
            }
        }

        private void ReceiveMessages(CancellationToken cancellationToken)
        {
            try
            {
                byte[] receiveData = new byte[1024];
                while (!cancellationToken.IsCancellationRequested && clientSocket.Connected)
                {
                    if (clientSocket.Available > 0)
                    {
                        int bytesReceived = clientSocket.Receive(receiveData);
                        if (bytesReceived > 0)
                        {
                            string response = Encoding.UTF8.GetString(receiveData, 0, bytesReceived);
                            receivedInput1.AppendText($"服务端：{response}\r\n");
                        }
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }                    
                }
            }
            catch (Exception ex)
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    AntdUI.Message.error(window, $"接收消息时出错: {ex.Message}", autoClose: 3);
                }                
            }
        }

        private void startServer() {
            if (!isServerRunning)
            {
                try
                {
                    int port = int.Parse(portInput.Text);
                    IPAddress ipAddress = IPAddress.Parse(addressInput.Text);
                    server = new TcpListener(ipAddress, port);
                    server.Start();
                    cancellationTokenSource = new CancellationTokenSource();
                    listenThread = new Thread(() => ListenForClients(cancellationTokenSource.Token));
                    listenThread.Start();
                    AntdUI.Message.success(window, $"服务器已启动，监听端口 {port}", autoClose: 3);
                    connectButton.Text = "停止服务";
                    isServerRunning = true;
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"启动服务器时出错: {ex.Message}", autoClose: 3);
                }
            }
            else
            {
                try
                {
                    cancellationTokenSource.Cancel();
                    if (listenThread != null && listenThread.IsAlive)
                    {
                        listenThread.Join();
                    }
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
                    AntdUI.Message.success(window, "服务器已停止", autoClose: 3);
                    connectButton.Text = "启动服务";
                    isServerRunning = false;
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"停止服务器时出错: {ex.Message}", autoClose: 3);
                }
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
                        clients.Add(client);
                        AntdUI.Message.success(window, $"新客户端已连接，当前连接数: {clients.Count}", autoClose: 3);
                        Thread clientThread = new Thread(() => HandleClientComm(client, cancellationToken));
                        clientThread.Start();
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"接受客户端连接时出错: {ex.Message}", autoClose: 3);
                }
            }            
        }
        private void HandleClientComm(TcpClient client, CancellationToken cancellationToken)
        {
            NetworkStream clientStream = client.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;
            while (!cancellationToken.IsCancellationRequested)
            {
                bytesRead = 0;
                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }
                if (bytesRead == 0)
                {
                    break;
                }
                string clientMessage = Encoding.UTF8.GetString(message, 0, bytesRead);
                receivedInput1.AppendText($"客户端: {clientMessage}\r\n");
            }
            clients.Remove(client);
            client.Close();
            AntdUI.Message.success(window, $"客户端已断开连接，当前连接数: {clients.Count}", autoClose: 3);
        }

        private void TcpServerForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            stopServer();
            stopConnection();
        }

        private void server2client() {
            if (clients.Count > 0)
            {
                string message = sendInput.Text;
                byte[] buffer = Encoding.UTF8.GetBytes(message);

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
                            AntdUI.Message.error(window, $"发送消息给客户端时出错: {ex.Message}", autoClose: 3);
                        }
                    }
                }
                receivedInput1.AppendText($"服务器: {message}\r\n");
                sendInput.Clear();
            }
            else
            {
                AntdUI.Message.error(window, "客户端未连接", autoClose: 3);
            }
        }

        private void client2server() {
            string message = sendInput.Text;
            byte[] sendData = Encoding.UTF8.GetBytes(message);

            // 发送消息
            clientSocket.Send(sendData);
            receivedInput1.AppendText($"客户端: {message}\r\n");
            sendInput.Clear();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (modeSelect.SelectedIndex == 0) {
                server2client();
            }
            if (modeSelect.SelectedIndex == 1) {
                client2server();
            }
            
        }
    }
}

