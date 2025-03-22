namespace LittleFancyTool.View
{
    partial class TcpServerForm
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
            tableLayoutPanel11 = new TableLayoutPanel();
            hexSendBox = new AntdUI.Checkbox();
            hexDisBox = new AntdUI.Checkbox();
            tableLayoutPanel3 = new TableLayoutPanel();
            modeLabel = new AntdUI.Label();
            modeSelect = new AntdUI.Select();
            tableLayoutPanel4 = new TableLayoutPanel();
            addressLabel = new AntdUI.Label();
            addressInput = new AntdUI.Input();
            tableLayoutPanel5 = new TableLayoutPanel();
            portInput = new AntdUI.InputNumber();
            portLabel = new AntdUI.Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            connectButton = new AntdUI.Button();
            connectLabel = new AntdUI.Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            pollIntervalInput = new AntdUI.InputNumber();
            pollBox = new AntdUI.Checkbox();
            socketClientTable = new AntdUI.Table();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            sendBtn = new AntdUI.Button();
            sendInput = new AntdUI.Input();
            tableLayoutPanel9 = new TableLayoutPanel();
            receivedInput1 = new AntdUI.Input();
            tableLayoutPanel13 = new TableLayoutPanel();
            formatSelect = new AntdUI.Select();
            label1 = new AntdUI.Label();
            clearDataBtn = new AntdUI.Button();
            saveDataBtn = new AntdUI.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel11, 0, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 5);
            tableLayoutPanel2.Controls.Add(socketClientTable, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(244, 624);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(hexSendBox, 1, 0);
            tableLayoutPanel11.Controls.Add(hexDisBox, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 200);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(244, 50);
            tableLayoutPanel11.TabIndex = 6;
            // 
            // hexSendBox
            // 
            hexSendBox.Anchor = AnchorStyles.Left;
            hexSendBox.AutoSizeMode = AntdUI.TAutoSize.Auto;
            hexSendBox.Font = new Font("Microsoft YaHei UI", 10F);
            hexSendBox.LocalizationText = "hexSend";
            hexSendBox.Location = new Point(122, 5);
            hexSendBox.Margin = new Padding(0);
            hexSendBox.Name = "hexSendBox";
            hexSendBox.Size = new Size(98, 39);
            hexSendBox.TabIndex = 9;
            hexSendBox.Text = "HEX发送";
            // 
            // hexDisBox
            // 
            hexDisBox.Anchor = AnchorStyles.Left;
            hexDisBox.AutoSizeMode = AntdUI.TAutoSize.Auto;
            hexDisBox.Font = new Font("Microsoft YaHei UI", 10F);
            hexDisBox.LocalizationText = "hexDisplay";
            hexDisBox.Location = new Point(0, 5);
            hexDisBox.Margin = new Padding(0);
            hexDisBox.Name = "hexDisBox";
            hexDisBox.Size = new Size(98, 39);
            hexDisBox.TabIndex = 8;
            hexDisBox.Text = "HEX显示";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(modeLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(modeSelect, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(244, 50);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // modeLabel
            // 
            modeLabel.Anchor = AnchorStyles.Left;
            modeLabel.Font = new Font("Microsoft YaHei UI", 12F);
            modeLabel.LocalizationText = "mode";
            modeLabel.Location = new Point(3, 3);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(94, 44);
            modeLabel.TabIndex = 1;
            modeLabel.Text = "模式";
            // 
            // modeSelect
            // 
            modeSelect.Anchor = AnchorStyles.None;
            modeSelect.Font = new Font("Microsoft YaHei UI", 10F);
            modeSelect.Items.AddRange(new object[] { "server", "client" });
            modeSelect.Location = new Point(122, 2);
            modeSelect.Margin = new Padding(0);
            modeSelect.Name = "modeSelect";
            modeSelect.SelectedIndex = 0;
            modeSelect.SelectedValue = "server";
            modeSelect.Size = new Size(122, 45);
            modeSelect.TabIndex = 0;
            modeSelect.Text = "server";
            modeSelect.SelectedIndexChanged += modeSelect_SelectedIndexChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(addressLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(addressInput, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 50);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(244, 50);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Left;
            addressLabel.Font = new Font("Microsoft YaHei UI", 12F);
            addressLabel.LocalizationText = "address";
            addressLabel.Location = new Point(3, 3);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(94, 44);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "地址";
            // 
            // addressInput
            // 
            addressInput.Anchor = AnchorStyles.None;
            addressInput.Font = new Font("Microsoft YaHei UI", 10F);
            addressInput.Location = new Point(122, 2);
            addressInput.Margin = new Padding(0);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(122, 45);
            addressInput.TabIndex = 1;
            addressInput.Text = "127.0.0.1";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(portInput, 1, 0);
            tableLayoutPanel5.Controls.Add(portLabel, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 100);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(244, 50);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // portInput
            // 
            portInput.Anchor = AnchorStyles.None;
            portInput.Font = new Font("Microsoft YaHei UI", 10F);
            portInput.Location = new Point(122, 2);
            portInput.Margin = new Padding(0);
            portInput.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            portInput.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            portInput.Name = "portInput";
            portInput.Size = new Size(122, 45);
            portInput.TabIndex = 2;
            portInput.Text = "2345";
            portInput.Value = new decimal(new int[] { 2345, 0, 0, 0 });
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.Left;
            portLabel.Font = new Font("Microsoft YaHei UI", 12F);
            portLabel.LocalizationText = "port";
            portLabel.Location = new Point(3, 3);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(94, 44);
            portLabel.TabIndex = 1;
            portLabel.Text = "端口";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(connectButton, 1, 0);
            tableLayoutPanel6.Controls.Add(connectLabel, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 150);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(244, 50);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.None;
            connectButton.Font = new Font("Microsoft YaHei UI", 12F);
            connectButton.LocalizationText = "startService";
            connectButton.Location = new Point(122, 2);
            connectButton.Margin = new Padding(0);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(122, 45);
            connectButton.TabIndex = 0;
            connectButton.Tag = "";
            connectButton.Text = "启动服务";
            connectButton.Type = AntdUI.TTypeMini.Success;
            connectButton.Click += connectButton_Click;
            // 
            // connectLabel
            // 
            connectLabel.Anchor = AnchorStyles.Left;
            connectLabel.Font = new Font("Microsoft YaHei UI", 12F);
            connectLabel.LocalizationText = "service";
            connectLabel.Location = new Point(3, 3);
            connectLabel.Name = "connectLabel";
            connectLabel.Size = new Size(94, 44);
            connectLabel.TabIndex = 1;
            connectLabel.Text = "服务";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(pollIntervalInput, 1, 0);
            tableLayoutPanel7.Controls.Add(pollBox, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 250);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(244, 50);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // pollIntervalInput
            // 
            pollIntervalInput.Anchor = AnchorStyles.None;
            pollIntervalInput.Location = new Point(122, 2);
            pollIntervalInput.Margin = new Padding(0);
            pollIntervalInput.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            pollIntervalInput.Name = "pollIntervalInput";
            pollIntervalInput.Size = new Size(122, 45);
            pollIntervalInput.TabIndex = 5;
            pollIntervalInput.Text = "1000";
            pollIntervalInput.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // pollBox
            // 
            pollBox.Anchor = AnchorStyles.Left;
            pollBox.Font = new Font("Microsoft YaHei UI", 10F);
            pollBox.LocalizationText = "pollSend";
            pollBox.Location = new Point(0, 4);
            pollBox.Margin = new Padding(0);
            pollBox.Name = "pollBox";
            pollBox.Size = new Size(113, 41);
            pollBox.TabIndex = 4;
            pollBox.Text = "间隔发送(ms)";
            // 
            // socketClientTable
            // 
            socketClientTable.Dock = DockStyle.Fill;
            socketClientTable.Location = new Point(3, 303);
            socketClientTable.Name = "socketClientTable";
            socketClientTable.Size = new Size(238, 313);
            socketClientTable.TabIndex = 8;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 633);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(244, 164);
            tableLayoutPanel8.TabIndex = 1;
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
            sendInput.Font = new Font("Microsoft YaHei UI", 12F);
            sendInput.Location = new Point(173, 3);
            sendInput.Multiline = true;
            sendInput.Name = "sendInput";
            sendInput.Size = new Size(968, 158);
            sendInput.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(receivedInput1, 0, 1);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(250, 0);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(1150, 630);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // receivedInput1
            // 
            receivedInput1.AutoScroll = true;
            receivedInput1.Dock = DockStyle.Fill;
            receivedInput1.Font = new Font("Microsoft YaHei UI", 12F);
            receivedInput1.Location = new Point(3, 55);
            receivedInput1.Multiline = true;
            receivedInput1.Name = "receivedInput1";
            receivedInput1.ReadOnly = true;
            receivedInput1.Size = new Size(1144, 572);
            receivedInput1.TabIndex = 4;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 7;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel13.Controls.Add(formatSelect, 1, 0);
            tableLayoutPanel13.Controls.Add(label1, 0, 0);
            tableLayoutPanel13.Controls.Add(clearDataBtn, 6, 0);
            tableLayoutPanel13.Controls.Add(saveDataBtn, 5, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(0, 0);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(1150, 52);
            tableLayoutPanel13.TabIndex = 5;
            // 
            // formatSelect
            // 
            formatSelect.Anchor = AnchorStyles.None;
            formatSelect.Font = new Font("Microsoft YaHei UI", 10F);
            formatSelect.Items.AddRange(new object[] { "Auto", "UTF8", "ASCII", "GB2312" });
            formatSelect.LocalizationText = "";
            formatSelect.Location = new Point(129, 3);
            formatSelect.Margin = new Padding(0);
            formatSelect.Name = "formatSelect";
            formatSelect.SelectedIndex = 0;
            formatSelect.SelectedValue = "Auto";
            formatSelect.Size = new Size(122, 45);
            formatSelect.TabIndex = 3;
            formatSelect.Text = "Auto";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.LocalizationText = "formatSelect";
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(94, 44);
            label1.TabIndex = 2;
            label1.Text = "收发格式";
            // 
            // clearDataBtn
            // 
            clearDataBtn.Anchor = AnchorStyles.None;
            clearDataBtn.Font = new Font("Microsoft YaHei UI", 12F);
            clearDataBtn.IconSvg = "DeleteOutlined";
            clearDataBtn.LocalizationText = "clearData";
            clearDataBtn.Location = new Point(1024, 3);
            clearDataBtn.Margin = new Padding(0);
            clearDataBtn.Name = "clearDataBtn";
            clearDataBtn.Size = new Size(122, 45);
            clearDataBtn.TabIndex = 0;
            clearDataBtn.Tag = "";
            clearDataBtn.Text = "清空数据";
            clearDataBtn.Type = AntdUI.TTypeMini.Success;
            clearDataBtn.Click += button1_Click;
            // 
            // saveDataBtn
            // 
            saveDataBtn.Anchor = AnchorStyles.None;
            saveDataBtn.Font = new Font("Microsoft YaHei UI", 12F);
            saveDataBtn.IconSvg = "SaveOutlined";
            saveDataBtn.LocalizationText = "saveData";
            saveDataBtn.Location = new Point(894, 3);
            saveDataBtn.Margin = new Padding(0);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(122, 45);
            saveDataBtn.TabIndex = 1;
            saveDataBtn.Tag = "";
            saveDataBtn.Text = "保存数据";
            saveDataBtn.Type = AntdUI.TTypeMini.Primary;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // TcpServerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "TcpServerForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private AntdUI.Label portLabel;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private AntdUI.Button connectButton;
        private AntdUI.Label connectLabel;
        private TableLayoutPanel tableLayoutPanel10;
        private AntdUI.Button sendBtn;
        private AntdUI.Input sendInput;
        private AntdUI.Input receivedInput1;
        private AntdUI.InputNumber portInput;
        private AntdUI.Label addressLabel;
        private AntdUI.Input addressInput;
        private AntdUI.Label modeLabel;
        private AntdUI.Select modeSelect;
        private AntdUI.Checkbox pollBox;
        private AntdUI.InputNumber pollIntervalInput;
        private AntdUI.Button saveDataBtn;
        private AntdUI.Button clearDataBtn;
        private TableLayoutPanel tableLayoutPanel11;
        private AntdUI.Checkbox hexDisBox;
        private AntdUI.Checkbox hexSendBox;
        private AntdUI.Table socketClientTable;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel13;
        private AntdUI.Select formatSelect;
        private AntdUI.Label label1;
    }
}