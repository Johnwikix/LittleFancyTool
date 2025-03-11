using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LittleFancyTool.View
{
    public partial class ModbusPollForm : UserControl
    {
        private SerialPort serialPort = new SerialPort();
        private ModbusSerialMaster modbusMaster;
        private AntdUI.Window window;
        private bool isPolling = false;
        public ModbusPollForm(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
            RefreshPortList();
        }

        private async Task pollingAsync(int time)
        {
            while (isPolling)
            {
                try
                {
                    await listenPort();
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"发生错误: {ex.Message}", autoClose: 3);
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

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                connectButton.Text = "连接";
                statusInput.Clear();
                connectButton.Type = AntdUI.TTypeMini.Success;
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
                    modbusMaster = ModbusSerialMaster.CreateRtu(serialPort);
                    serialPort.Open();
                    connectButton.Text = "断开";
                    connectButton.Type = AntdUI.TTypeMini.Error;
                    statusInput.Text = $"已连接 {serialPort.PortName} [Baud:{serialPort.BaudRate} " +
                        $"Parity:{serialPort.Parity} DataBits:{serialPort.DataBits} " +
                        $"StopBits:{serialPort.StopBits}]";
                    isPolling = true;
                    int time = int.Parse(scanTimeInput.Text);
                    _ = pollingAsync(time);
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"连接失败: {ex.Message}", autoClose: 3);
                }
            }
        }

        private Task listenPort()
        {
            return Task.Run(() => {
                if (!ValidateInputs())
                    return;

                byte slaveId = byte.Parse(slaveIdInput.Text);
                ushort startAddress = ushort.Parse(addressInput.Text);
                ushort numRegisters = ushort.Parse(numRegistersInput.Text);
                try
                {
                    var registers = modbusMaster.ReadHoldingRegisters(slaveId, startAddress, numRegisters);
                    outputInput.AppendText($"读取成功: {string.Join(", ", registers)}\r\n");
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, $"port读取失败: {ex.Message}", autoClose: 3);
                }
            });
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
    }
}
