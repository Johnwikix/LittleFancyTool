namespace LittleFancyTool.View
{
    partial class SerialPortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            timeLimitLabel = new AntdUI.Label();
            timeLimitInput = new AntdUI.InputNumber();
            tableLayoutPanel3 = new TableLayoutPanel();
            portSelect = new AntdUI.Select();
            tableLayoutPanel11 = new TableLayoutPanel();
            portLabel = new AntdUI.Label();
            button1 = new AntdUI.Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            connectButton = new AntdUI.Button();
            connectLabel = new AntdUI.Label();
            rs485checkbox = new AntdUI.Checkbox();
            tableLayoutPanel4 = new TableLayoutPanel();
            baudRateLabel = new AntdUI.Label();
            baudRateSelect = new AntdUI.Select();
            tableLayoutPanel5 = new TableLayoutPanel();
            parityLabel = new AntdUI.Label();
            paritySelect = new AntdUI.Select();
            tableLayoutPanel6 = new TableLayoutPanel();
            dataBitsLabel = new AntdUI.Label();
            dataBitsSelect = new AntdUI.Select();
            tableLayoutPanel7 = new TableLayoutPanel();
            StopBitsLabel = new AntdUI.Label();
            stopBitsSelect = new AntdUI.Select();
            statusInput = new AntdUI.Input();
            tableLayoutPanel9 = new TableLayoutPanel();
            receivedInput = new AntdUI.Input();
            tableLayoutPanel12 = new TableLayoutPanel();
            label2 = new AntdUI.Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            sendSelect = new AntdUI.Select();
            label1 = new AntdUI.Label();
            receivedModeSelect = new AntdUI.Select();
            tableLayoutPanel10 = new TableLayoutPanel();
            sendBtn = new AntdUI.Button();
            sendInput = new AntdUI.Input();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel14, 0, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 0, 6);
            tableLayoutPanel2.Controls.Add(statusInput, 0, 7);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(250, 630);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(timeLimitLabel, 0, 0);
            tableLayoutPanel14.Controls.Add(timeLimitInput, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(0, 250);
            tableLayoutPanel14.Margin = new Padding(0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Size = new Size(250, 50);
            tableLayoutPanel14.TabIndex = 5;
            // 
            // timeLimitLabel
            // 
            timeLimitLabel.Anchor = AnchorStyles.Left;
            timeLimitLabel.Font = new Font("Microsoft YaHei UI", 12F);
            timeLimitLabel.LocalizationText = "FrameBreakInterval";
            timeLimitLabel.Location = new Point(3, 6);
            timeLimitLabel.Name = "timeLimitLabel";
            timeLimitLabel.Size = new Size(113, 38);
            timeLimitLabel.TabIndex = 2;
            timeLimitLabel.Text = "断帧间隔(ms)";
            // 
            // timeLimitInput
            // 
            timeLimitInput.Anchor = AnchorStyles.None;
            timeLimitInput.Font = new Font("Microsoft YaHei UI", 10F);
            timeLimitInput.Location = new Point(126, 2);
            timeLimitInput.Margin = new Padding(0);
            timeLimitInput.Name = "timeLimitInput";
            timeLimitInput.Size = new Size(122, 45);
            timeLimitInput.TabIndex = 3;
            timeLimitInput.Text = "50";
            timeLimitInput.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(portSelect, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(250, 50);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // portSelect
            // 
            portSelect.Anchor = AnchorStyles.None;
            portSelect.Font = new Font("Microsoft YaHei UI", 10F);
            portSelect.Location = new Point(126, 2);
            portSelect.Margin = new Padding(0);
            portSelect.Name = "portSelect";
            portSelect.Size = new Size(122, 45);
            portSelect.TabIndex = 0;
            portSelect.Text = "串口号";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Left;
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.4513245F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5486717F));
            tableLayoutPanel11.Controls.Add(portLabel, 0, 0);
            tableLayoutPanel11.Controls.Add(button1, 1, 0);
            tableLayoutPanel11.Location = new Point(0, 6);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(113, 38);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.Left;
            portLabel.Font = new Font("Microsoft YaHei UI", 12F);
            portLabel.LocalizationText = "serialPort";
            portLabel.Location = new Point(3, 3);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(63, 32);
            portLabel.TabIndex = 1;
            portLabel.Text = "串口号";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Microsoft YaHei UI", 12F);
            button1.Ghost = true;
            button1.IconSvg = "UndoOutlined";
            button1.Location = new Point(86, 4);
            button1.Name = "button1";
            button1.Size = new Size(24, 30);
            button1.TabIndex = 2;
            button1.Type = AntdUI.TTypeMini.Primary;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(connectButton, 1, 0);
            tableLayoutPanel8.Controls.Add(connectLabel, 0, 0);
            tableLayoutPanel8.Controls.Add(rs485checkbox, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 300);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(250, 100);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.None;
            connectButton.Font = new Font("Microsoft YaHei UI", 12F);
            connectButton.LocalizationText = "connectButton";
            connectButton.Location = new Point(128, 3);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(119, 44);
            connectButton.TabIndex = 0;
            connectButton.Text = "连接";
            connectButton.Type = AntdUI.TTypeMini.Success;
            connectButton.Click += connectButton_Click;
            // 
            // connectLabel
            // 
            connectLabel.Anchor = AnchorStyles.Left;
            connectLabel.Font = new Font("Microsoft YaHei UI", 12F);
            connectLabel.LocalizationText = "connectLabel";
            connectLabel.Location = new Point(3, 4);
            connectLabel.Name = "connectLabel";
            connectLabel.Size = new Size(113, 41);
            connectLabel.TabIndex = 1;
            connectLabel.Text = "连接";
            // 
            // rs485checkbox
            // 
            rs485checkbox.Anchor = AnchorStyles.None;
            rs485checkbox.Font = new Font("Microsoft YaHei UI", 10F);
            rs485checkbox.Location = new Point(6, 54);
            rs485checkbox.Name = "rs485checkbox";
            rs485checkbox.Size = new Size(113, 41);
            rs485checkbox.TabIndex = 3;
            rs485checkbox.Text = "RTS";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(baudRateLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(baudRateSelect, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 50);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(250, 50);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // baudRateLabel
            // 
            baudRateLabel.Anchor = AnchorStyles.Left;
            baudRateLabel.Font = new Font("Microsoft YaHei UI", 12F);
            baudRateLabel.LocalizationText = "baudRate";
            baudRateLabel.Location = new Point(3, 6);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new Size(113, 38);
            baudRateLabel.TabIndex = 2;
            baudRateLabel.Text = "波特率";
            // 
            // baudRateSelect
            // 
            baudRateSelect.Anchor = AnchorStyles.None;
            baudRateSelect.Font = new Font("Microsoft YaHei UI", 10F);
            baudRateSelect.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            baudRateSelect.Location = new Point(126, 2);
            baudRateSelect.Margin = new Padding(0);
            baudRateSelect.Name = "baudRateSelect";
            baudRateSelect.SelectedIndex = 5;
            baudRateSelect.SelectedValue = "9600";
            baudRateSelect.Size = new Size(122, 45);
            baudRateSelect.TabIndex = 0;
            baudRateSelect.Text = "9600";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(parityLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(paritySelect, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 100);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(250, 50);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // parityLabel
            // 
            parityLabel.Anchor = AnchorStyles.Left;
            parityLabel.Font = new Font("Microsoft YaHei UI", 12F);
            parityLabel.LocalizationText = "parity";
            parityLabel.Location = new Point(3, 6);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new Size(113, 38);
            parityLabel.TabIndex = 2;
            parityLabel.Text = "校验位";
            // 
            // paritySelect
            // 
            paritySelect.Anchor = AnchorStyles.None;
            paritySelect.Font = new Font("Microsoft YaHei UI", 10F);
            paritySelect.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            paritySelect.Location = new Point(126, 2);
            paritySelect.Margin = new Padding(0);
            paritySelect.Name = "paritySelect";
            paritySelect.SelectedIndex = 0;
            paritySelect.SelectedValue = "None";
            paritySelect.Size = new Size(122, 45);
            paritySelect.TabIndex = 1;
            paritySelect.Text = "None";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(dataBitsLabel, 0, 0);
            tableLayoutPanel6.Controls.Add(dataBitsSelect, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 150);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(250, 50);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.Anchor = AnchorStyles.Left;
            dataBitsLabel.Font = new Font("Microsoft YaHei UI", 12F);
            dataBitsLabel.LocalizationText = "dataBits";
            dataBitsLabel.Location = new Point(3, 6);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new Size(113, 38);
            dataBitsLabel.TabIndex = 2;
            dataBitsLabel.Text = "数据位";
            // 
            // dataBitsSelect
            // 
            dataBitsSelect.Anchor = AnchorStyles.None;
            dataBitsSelect.Font = new Font("Microsoft YaHei UI", 10F);
            dataBitsSelect.Items.AddRange(new object[] { "5", "6", "7", "8" });
            dataBitsSelect.Location = new Point(126, 2);
            dataBitsSelect.Margin = new Padding(0);
            dataBitsSelect.Name = "dataBitsSelect";
            dataBitsSelect.SelectedIndex = 3;
            dataBitsSelect.SelectedValue = "8";
            dataBitsSelect.Size = new Size(122, 45);
            dataBitsSelect.TabIndex = 0;
            dataBitsSelect.Text = "8";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(StopBitsLabel, 0, 0);
            tableLayoutPanel7.Controls.Add(stopBitsSelect, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 200);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(250, 50);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // StopBitsLabel
            // 
            StopBitsLabel.Anchor = AnchorStyles.Left;
            StopBitsLabel.Font = new Font("Microsoft YaHei UI", 12F);
            StopBitsLabel.LocalizationText = "StopBits";
            StopBitsLabel.Location = new Point(3, 6);
            StopBitsLabel.Name = "StopBitsLabel";
            StopBitsLabel.Size = new Size(113, 38);
            StopBitsLabel.TabIndex = 2;
            StopBitsLabel.Text = "结束位";
            // 
            // stopBitsSelect
            // 
            stopBitsSelect.Anchor = AnchorStyles.None;
            stopBitsSelect.Font = new Font("Microsoft YaHei UI", 10F);
            stopBitsSelect.Items.AddRange(new object[] { "1", "1.5", "2" });
            stopBitsSelect.Location = new Point(126, 2);
            stopBitsSelect.Margin = new Padding(0);
            stopBitsSelect.Name = "stopBitsSelect";
            stopBitsSelect.SelectedIndex = 0;
            stopBitsSelect.SelectedValue = "1";
            stopBitsSelect.Size = new Size(122, 45);
            stopBitsSelect.TabIndex = 0;
            stopBitsSelect.Text = "1";
            // 
            // statusInput
            // 
            statusInput.AutoScroll = true;
            statusInput.Dock = DockStyle.Fill;
            statusInput.Font = new Font("Microsoft YaHei UI", 10F);
            statusInput.Location = new Point(3, 403);
            statusInput.Multiline = true;
            statusInput.Name = "statusInput";
            statusInput.ReadOnly = true;
            statusInput.Size = new Size(244, 224);
            statusInput.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(receivedInput, 1, 1);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel12, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(253, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(1144, 624);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // receivedInput
            // 
            receivedInput.AutoScroll = true;
            receivedInput.Dock = DockStyle.Fill;
            receivedInput.Font = new Font("Microsoft YaHei UI", 14F);
            receivedInput.Location = new Point(3, 63);
            receivedInput.Multiline = true;
            receivedInput.Name = "receivedInput";
            receivedInput.ReadOnly = true;
            receivedInput.Size = new Size(1138, 558);
            receivedInput.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.AutoSize = true;
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(label2, 1, 0);
            tableLayoutPanel12.Controls.Add(tableLayoutPanel13, 2, 0);
            tableLayoutPanel12.Controls.Add(receivedModeSelect, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(1138, 54);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            label2.Font = new Font("Microsoft YaHei UI", 15F);
            label2.LocalizationText = "ReceivedFormat";
            label2.Location = new Point(111, 13);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 3;
            label2.Text = "接收格式";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.AutoSize = true;
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutPanel13.Controls.Add(sendSelect, 0, 0);
            tableLayoutPanel13.Controls.Add(label1, 1, 0);
            tableLayoutPanel13.Location = new Point(326, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(260, 48);
            tableLayoutPanel13.TabIndex = 4;
            // 
            // sendSelect
            // 
            sendSelect.Items.AddRange(new object[] { "Auto", "UTF8", "ASCII", "GB2312", "HEX" });
            sendSelect.Location = new Point(3, 3);
            sendSelect.Name = "sendSelect";
            sendSelect.SelectedIndex = 1;
            sendSelect.SelectedValue = "UTF8";
            sendSelect.Size = new Size(100, 42);
            sendSelect.TabIndex = 4;
            sendSelect.Text = "UTF8";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            label1.Font = new Font("Microsoft YaHei UI", 15F);
            label1.LocalizationText = "SendFormat";
            label1.Location = new Point(110, 10);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 2;
            label1.Text = "发送格式";
            // 
            // receivedModeSelect
            // 
            receivedModeSelect.Anchor = AnchorStyles.Left;
            receivedModeSelect.Items.AddRange(new object[] { "Auto", "UTF8", "ASCII", "GB2312", "HEX" });
            receivedModeSelect.Location = new Point(3, 4);
            receivedModeSelect.Name = "receivedModeSelect";
            receivedModeSelect.SelectedIndex = 0;
            receivedModeSelect.SelectedValue = "Auto";
            receivedModeSelect.Size = new Size(100, 45);
            receivedModeSelect.TabIndex = 4;
            receivedModeSelect.Text = "Auto";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel10.Controls.Add(sendBtn, 0, 0);
            tableLayoutPanel10.Controls.Add(sendInput, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(253, 633);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(1144, 164);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // sendBtn
            // 
            sendBtn.Dock = DockStyle.Fill;
            sendBtn.Font = new Font("Microsoft YaHei UI", 15F);
            sendBtn.LocalizationText = "send";
            sendBtn.Location = new Point(3, 3);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(164, 158);
            sendBtn.TabIndex = 0;
            sendBtn.Text = "发送";
            sendBtn.Type = AntdUI.TTypeMini.Primary;
            sendBtn.Click += sendBtn_Click;
            // 
            // sendInput
            // 
            sendInput.AutoScroll = true;
            sendInput.Dock = DockStyle.Fill;
            sendInput.Font = new Font("Microsoft YaHei UI", 14F);
            sendInput.Location = new Point(173, 3);
            sendInput.Multiline = true;
            sendInput.Name = "sendInput";
            sendInput.Size = new Size(968, 158);
            sendInput.TabIndex = 0;
            // 
            // SerialPortForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "SerialPortForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private AntdUI.Select portSelect;
        private AntdUI.Label portLabel;
        private AntdUI.Label baudRateLabel;
        private AntdUI.Select baudRateSelect;
        private AntdUI.Label parityLabel;
        private AntdUI.Select paritySelect;
        private AntdUI.Label dataBitsLabel;
        private AntdUI.Select dataBitsSelect;
        private TableLayoutPanel tableLayoutPanel7;
        private AntdUI.Label StopBitsLabel;
        private AntdUI.Select stopBitsSelect;
        private TableLayoutPanel tableLayoutPanel8;
        private AntdUI.Button connectButton;
        private AntdUI.Label connectLabel;
        private TableLayoutPanel tableLayoutPanel9;
        private AntdUI.Input sendInput;
        private AntdUI.Input receivedInput;
        private TableLayoutPanel tableLayoutPanel10;
        private AntdUI.Button sendBtn;
        private AntdUI.Input statusInput;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private TableLayoutPanel tableLayoutPanel11;
        private AntdUI.Button button1;
        private TableLayoutPanel tableLayoutPanel12;
        private AntdUI.Select receivedModeSelect;
        private TableLayoutPanel tableLayoutPanel13;
        private AntdUI.Select sendSelect;
        private AntdUI.Checkbox rs485checkbox;
        private TableLayoutPanel tableLayoutPanel14;
        private AntdUI.Label timeLimitLabel;
        private AntdUI.InputNumber timeLimitInput;
    }
}