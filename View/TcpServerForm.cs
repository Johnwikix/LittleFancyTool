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
        public TcpServerForm(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
            this.Load += TcpServerForm_Load;
            this.VisibleChanged += TcpServerForm_VisibleChanged;

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
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"关闭服务器时出错: {ex.Message}", autoClose: 3);
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isServerRunning)
            {
                try
                {
                    int port = int.Parse(portInput.Text);
                    server = new TcpListener(IPAddress.Any, port);
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
        }

        private void sendBtn_Click(object sender, EventArgs e)
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
    }
}

