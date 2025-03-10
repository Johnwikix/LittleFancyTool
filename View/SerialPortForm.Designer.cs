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
            statusInput = new AntdUI.Input();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            portSelect = new AntdUI.Select();
            tableLayoutPanel11 = new TableLayoutPanel();
            portLabel = new AntdUI.Label();
            button1 = new AntdUI.Button();
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
            tableLayoutPanel8 = new TableLayoutPanel();
            connectButton = new AntdUI.Button();
            connectLabel = new AntdUI.Label();
            rs485checkbox = new AntdUI.Checkbox();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel13 = new TableLayoutPanel();
            sendSelect = new AntdUI.Select();
            label1 = new AntdUI.Label();
            sendInput = new AntdUI.Input();
            receivedInput = new AntdUI.Input();
            tableLayoutPanel12 = new TableLayoutPanel();
            label2 = new AntdUI.Label();
            receivedModeSelect = new AntdUI.Select();
            tableLayoutPanel10 = new TableLayoutPanel();
            sendBtn = new AntdUI.Button();
            sendHisInput = new AntdUI.Input();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(statusInput, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // statusInput
            // 
            statusInput.AutoScroll = true;
            statusInput.Dock = DockStyle.Fill;
            statusInput.Location = new Point(3, 643);
            statusInput.Multiline = true;
            statusInput.Name = "statusInput";
            statusInput.ReadOnly = true;
            statusInput.Size = new Size(344, 154);
            statusInput.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(344, 474);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(portSelect, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(338, 88);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // portSelect
            // 
            portSelect.Anchor = AnchorStyles.None;
            portSelect.Font = new Font("Microsoft YaHei UI", 16F);
            portSelect.Location = new Point(183, 19);
            portSelect.Name = "portSelect";
            portSelect.Size = new Size(140, 50);
            portSelect.TabIndex = 0;
            portSelect.Text = "串口号";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Left;
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.3496933F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6503067F));
            tableLayoutPanel11.Controls.Add(portLabel, 0, 0);
            tableLayoutPanel11.Controls.Add(button1, 1, 0);
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(163, 82);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.Left;
            portLabel.Font = new Font("Microsoft YaHei UI", 18F);
            portLabel.Location = new Point(3, 11);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(94, 60);
            portLabel.TabIndex = 1;
            portLabel.Text = "串口号";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Microsoft YaHei UI", 16F);
            button1.Ghost = true;
            button1.IconSvg = "UndoOutlined";
            button1.Location = new Point(116, 26);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 2;
            button1.Type = AntdUI.TTypeMini.Primary;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(baudRateLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(baudRateSelect, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 97);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(338, 88);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // baudRateLabel
            // 
            baudRateLabel.Anchor = AnchorStyles.Left;
            baudRateLabel.Font = new Font("Microsoft YaHei UI", 18F);
            baudRateLabel.Location = new Point(3, 14);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new Size(120, 60);
            baudRateLabel.TabIndex = 2;
            baudRateLabel.Text = "波特率";
            // 
            // baudRateSelect
            // 
            baudRateSelect.Anchor = AnchorStyles.None;
            baudRateSelect.Font = new Font("Microsoft YaHei UI", 16F);
            baudRateSelect.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            baudRateSelect.Location = new Point(183, 19);
            baudRateSelect.Name = "baudRateSelect";
            baudRateSelect.SelectedIndex = 5;
            baudRateSelect.SelectedValue = "9600";
            baudRateSelect.Size = new Size(140, 50);
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
            tableLayoutPanel5.Location = new Point(3, 191);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(338, 88);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // parityLabel
            // 
            parityLabel.Anchor = AnchorStyles.Left;
            parityLabel.Font = new Font("Microsoft YaHei UI", 18F);
            parityLabel.Location = new Point(3, 14);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new Size(120, 60);
            parityLabel.TabIndex = 2;
            parityLabel.Text = "校验位";
            // 
            // paritySelect
            // 
            paritySelect.Anchor = AnchorStyles.None;
            paritySelect.Font = new Font("Microsoft YaHei UI", 16F);
            paritySelect.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            paritySelect.Location = new Point(183, 19);
            paritySelect.Name = "paritySelect";
            paritySelect.SelectedIndex = 0;
            paritySelect.SelectedValue = "None";
            paritySelect.Size = new Size(140, 50);
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
            tableLayoutPanel6.Location = new Point(3, 285);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(338, 88);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.Anchor = AnchorStyles.Left;
            dataBitsLabel.Font = new Font("Microsoft YaHei UI", 18F);
            dataBitsLabel.Location = new Point(3, 14);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new Size(120, 60);
            dataBitsLabel.TabIndex = 2;
            dataBitsLabel.Text = "数据位";
            // 
            // dataBitsSelect
            // 
            dataBitsSelect.Anchor = AnchorStyles.None;
            dataBitsSelect.Font = new Font("Microsoft YaHei UI", 16F);
            dataBitsSelect.Items.AddRange(new object[] { "5", "6", "7", "8" });
            dataBitsSelect.Location = new Point(183, 19);
            dataBitsSelect.Name = "dataBitsSelect";
            dataBitsSelect.SelectedIndex = 3;
            dataBitsSelect.SelectedValue = "8";
            dataBitsSelect.Size = new Size(140, 50);
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
            tableLayoutPanel7.Location = new Point(3, 379);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(338, 92);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // StopBitsLabel
            // 
            StopBitsLabel.Anchor = AnchorStyles.Left;
            StopBitsLabel.Font = new Font("Microsoft YaHei UI", 18F);
            StopBitsLabel.Location = new Point(3, 16);
            StopBitsLabel.Name = "StopBitsLabel";
            StopBitsLabel.Size = new Size(120, 60);
            StopBitsLabel.TabIndex = 2;
            StopBitsLabel.Text = "结束位";
            // 
            // stopBitsSelect
            // 
            stopBitsSelect.Anchor = AnchorStyles.None;
            stopBitsSelect.Font = new Font("Microsoft YaHei UI", 16F);
            stopBitsSelect.Items.AddRange(new object[] { "1", "1.5", "2" });
            stopBitsSelect.Location = new Point(183, 21);
            stopBitsSelect.Name = "stopBitsSelect";
            stopBitsSelect.SelectedIndex = 0;
            stopBitsSelect.SelectedValue = "1";
            stopBitsSelect.Size = new Size(140, 50);
            stopBitsSelect.TabIndex = 0;
            stopBitsSelect.Text = "1";
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
            tableLayoutPanel8.Location = new Point(3, 483);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(344, 154);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.None;
            connectButton.Font = new Font("Microsoft YaHei UI", 16F);
            connectButton.Location = new Point(198, 8);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(120, 60);
            connectButton.TabIndex = 0;
            connectButton.Text = "连接";
            connectButton.Type = AntdUI.TTypeMini.Success;
            connectButton.Click += connectButton_Click;
            // 
            // connectLabel
            // 
            connectLabel.Anchor = AnchorStyles.Left;
            connectLabel.Font = new Font("Microsoft YaHei UI", 18F);
            connectLabel.Location = new Point(3, 8);
            connectLabel.Name = "connectLabel";
            connectLabel.Size = new Size(120, 60);
            connectLabel.TabIndex = 1;
            connectLabel.Text = "连接";
            // 
            // rs485checkbox
            // 
            rs485checkbox.Anchor = AnchorStyles.Left;
            rs485checkbox.Font = new Font("Microsoft YaHei UI", 12F);
            rs485checkbox.Location = new Point(3, 85);
            rs485checkbox.Name = "rs485checkbox";
            rs485checkbox.Size = new Size(120, 60);
            rs485checkbox.TabIndex = 3;
            rs485checkbox.Text = "RTS";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel9.Controls.Add(sendInput, 0, 1);
            tableLayoutPanel9.Controls.Add(receivedInput, 1, 1);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel12, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(353, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(1044, 474);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.81457F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.18543F));
            tableLayoutPanel13.Controls.Add(sendSelect, 1, 0);
            tableLayoutPanel13.Controls.Add(label1, 0, 0);
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(302, 64);
            tableLayoutPanel13.TabIndex = 4;
            // 
            // sendSelect
            // 
            sendSelect.Items.AddRange(new object[] { "Auto", "UTF8", "ASCII", "GB2312", "HEX" });
            sendSelect.Location = new Point(87, 3);
            sendSelect.Name = "sendSelect";
            sendSelect.SelectedIndex = 3;
            sendSelect.SelectedValue = "GB2312";
            sendSelect.Size = new Size(125, 56);
            sendSelect.TabIndex = 4;
            sendSelect.Text = "GB2312";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Font = new Font("Microsoft YaHei UI", 18F);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(78, 58);
            label1.TabIndex = 2;
            label1.Text = "发送";
            // 
            // sendInput
            // 
            sendInput.AutoScroll = true;
            sendInput.Dock = DockStyle.Fill;
            sendInput.Font = new Font("Microsoft YaHei UI", 16F);
            sendInput.Location = new Point(3, 73);
            sendInput.Multiline = true;
            sendInput.Name = "sendInput";
            sendInput.Size = new Size(516, 398);
            sendInput.TabIndex = 0;
            // 
            // receivedInput
            // 
            receivedInput.AutoScroll = true;
            receivedInput.Dock = DockStyle.Fill;
            receivedInput.Font = new Font("Microsoft YaHei UI", 16F);
            receivedInput.Location = new Point(525, 73);
            receivedInput.Multiline = true;
            receivedInput.Name = "receivedInput";
            receivedInput.ReadOnly = true;
            receivedInput.Size = new Size(516, 398);
            receivedInput.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.81457F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.18543F));
            tableLayoutPanel12.Controls.Add(label2, 0, 0);
            tableLayoutPanel12.Controls.Add(receivedModeSelect, 1, 0);
            tableLayoutPanel12.Location = new Point(525, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(302, 64);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Microsoft YaHei UI", 18F);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(78, 58);
            label2.TabIndex = 3;
            label2.Text = "接收";
            // 
            // receivedModeSelect
            // 
            receivedModeSelect.Items.AddRange(new object[] { "自动检测", "UTF8", "ASCII", "GB2312", "HEX" });
            receivedModeSelect.Location = new Point(87, 3);
            receivedModeSelect.Name = "receivedModeSelect";
            receivedModeSelect.SelectedIndex = 0;
            receivedModeSelect.SelectedValue = "自动检测";
            receivedModeSelect.Size = new Size(125, 56);
            receivedModeSelect.TabIndex = 4;
            receivedModeSelect.Text = "自动检测";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel10.Controls.Add(sendBtn, 0, 0);
            tableLayoutPanel10.Controls.Add(sendHisInput, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(353, 483);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(1044, 154);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // sendBtn
            // 
            sendBtn.Anchor = AnchorStyles.Top;
            sendBtn.Font = new Font("Microsoft YaHei UI", 18F);
            sendBtn.Location = new Point(10, 3);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(150, 60);
            sendBtn.TabIndex = 0;
            sendBtn.Text = "发送";
            sendBtn.Type = AntdUI.TTypeMini.Primary;
            sendBtn.Click += sendBtn_Click;
            // 
            // sendHisInput
            // 
            sendHisInput.AutoScroll = true;
            sendHisInput.Dock = DockStyle.Fill;
            sendHisInput.Location = new Point(173, 3);
            sendHisInput.Multiline = true;
            sendHisInput.Name = "sendHisInput";
            sendHisInput.ReadOnly = true;
            sendHisInput.Size = new Size(868, 148);
            sendHisInput.TabIndex = 1;
            // 
            // SerialPortForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "SerialPortForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
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
        private AntdUI.Input sendHisInput;
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
    }
}