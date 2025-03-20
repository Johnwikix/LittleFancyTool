namespace LittleFancyTool.View
{
    partial class ModbusSlaveForm
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
            functionSelect = new AntdUI.Select();
            tableLayoutPanel3 = new TableLayoutPanel();
            portSelect = new AntdUI.Select();
            tableLayoutPanel11 = new TableLayoutPanel();
            portLabel = new AntdUI.Label();
            refreshBtn = new AntdUI.Button();
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
            tableLayoutPanel10 = new TableLayoutPanel();
            incrementTimeInput = new AntdUI.InputNumber();
            incrementTimeLabel = new AntdUI.Label();
            numRegistersLabel = new AntdUI.Label();
            addressLabel = new AntdUI.Label();
            slaveIdLabel = new AntdUI.Label();
            slaveIdInput = new AntdUI.InputNumber();
            addressInput = new AntdUI.InputNumber();
            numRegistersInput = new AntdUI.InputNumber();
            connectLabel = new AntdUI.Label();
            connectButton = new AntdUI.Button();
            slaveTable = new AntdUI.Table();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(functionSelect, 0, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 4);
            tableLayoutPanel2.Controls.Add(statusInput, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(244, 794);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // functionSelect
            // 
            functionSelect.Anchor = AnchorStyles.None;
            functionSelect.Font = new Font("Microsoft YaHei UI", 10F);
            functionSelect.Items.AddRange(new object[] { "01 Coil Status", "02 Input Status", "03 Holding Register", "04 Input Registers" });
            functionSelect.Location = new Point(0, 252);
            functionSelect.Margin = new Padding(0);
            functionSelect.Name = "functionSelect";
            functionSelect.SelectedIndex = 2;
            functionSelect.SelectedValue = "03 Holding Register";
            functionSelect.Size = new Size(244, 45);
            functionSelect.TabIndex = 0;
            functionSelect.Text = "03 Holding Register";
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
            tableLayoutPanel3.Size = new Size(244, 50);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // portSelect
            // 
            portSelect.Anchor = AnchorStyles.None;
            portSelect.Font = new Font("Microsoft YaHei UI", 10F);
            portSelect.Location = new Point(122, 2);
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
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.5901642F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.4098358F));
            tableLayoutPanel11.Controls.Add(portLabel, 0, 0);
            tableLayoutPanel11.Controls.Add(refreshBtn, 1, 0);
            tableLayoutPanel11.Location = new Point(0, 1);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(122, 48);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.Left;
            portLabel.Font = new Font("Microsoft YaHei UI", 12F);
            portLabel.LocalizationText = "serialPort";
            portLabel.Location = new Point(0, 3);
            portLabel.Margin = new Padding(0);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(78, 42);
            portLabel.TabIndex = 1;
            portLabel.Text = "串口号";
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.None;
            refreshBtn.Font = new Font("Microsoft YaHei UI", 12F);
            refreshBtn.Ghost = true;
            refreshBtn.IconSvg = "UndoOutlined";
            refreshBtn.Location = new Point(91, 9);
            refreshBtn.Margin = new Padding(0);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(30, 30);
            refreshBtn.TabIndex = 2;
            refreshBtn.Type = AntdUI.TTypeMini.Primary;
            refreshBtn.Click += refreshBtn_Click;
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
            tableLayoutPanel4.Size = new Size(244, 50);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // baudRateLabel
            // 
            baudRateLabel.Anchor = AnchorStyles.Left;
            baudRateLabel.Font = new Font("Microsoft YaHei UI", 12F);
            baudRateLabel.LocalizationText = "baudRate";
            baudRateLabel.Location = new Point(0, 1);
            baudRateLabel.Margin = new Padding(0);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new Size(120, 48);
            baudRateLabel.TabIndex = 2;
            baudRateLabel.Text = "波特率";
            // 
            // baudRateSelect
            // 
            baudRateSelect.Anchor = AnchorStyles.None;
            baudRateSelect.Font = new Font("Microsoft YaHei UI", 10F);
            baudRateSelect.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            baudRateSelect.Location = new Point(122, 2);
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
            tableLayoutPanel5.Size = new Size(244, 50);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // parityLabel
            // 
            parityLabel.Anchor = AnchorStyles.Left;
            parityLabel.Font = new Font("Microsoft YaHei UI", 12F);
            parityLabel.LocalizationText = "parity";
            parityLabel.Location = new Point(0, 1);
            parityLabel.Margin = new Padding(0);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new Size(120, 48);
            parityLabel.TabIndex = 2;
            parityLabel.Text = "校验位";
            // 
            // paritySelect
            // 
            paritySelect.Anchor = AnchorStyles.None;
            paritySelect.Font = new Font("Microsoft YaHei UI", 10F);
            paritySelect.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            paritySelect.Location = new Point(122, 2);
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
            tableLayoutPanel6.Size = new Size(244, 50);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.Anchor = AnchorStyles.Left;
            dataBitsLabel.Font = new Font("Microsoft YaHei UI", 12F);
            dataBitsLabel.LocalizationText = "dataBits";
            dataBitsLabel.Location = new Point(0, 1);
            dataBitsLabel.Margin = new Padding(0);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new Size(120, 48);
            dataBitsLabel.TabIndex = 2;
            dataBitsLabel.Text = "数据位";
            // 
            // dataBitsSelect
            // 
            dataBitsSelect.Anchor = AnchorStyles.None;
            dataBitsSelect.Font = new Font("Microsoft YaHei UI", 10F);
            dataBitsSelect.Items.AddRange(new object[] { "5", "6", "7", "8" });
            dataBitsSelect.Location = new Point(122, 2);
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
            tableLayoutPanel7.Size = new Size(244, 50);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // StopBitsLabel
            // 
            StopBitsLabel.Anchor = AnchorStyles.Left;
            StopBitsLabel.Font = new Font("Microsoft YaHei UI", 12F);
            StopBitsLabel.LocalizationText = "StopBits";
            StopBitsLabel.Location = new Point(0, 1);
            StopBitsLabel.Margin = new Padding(0);
            StopBitsLabel.Name = "StopBitsLabel";
            StopBitsLabel.Size = new Size(120, 48);
            StopBitsLabel.TabIndex = 2;
            StopBitsLabel.Text = "结束位";
            // 
            // stopBitsSelect
            // 
            stopBitsSelect.Anchor = AnchorStyles.None;
            stopBitsSelect.Font = new Font("Microsoft YaHei UI", 10F);
            stopBitsSelect.Items.AddRange(new object[] { "1", "1.5", "2" });
            stopBitsSelect.Location = new Point(122, 2);
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
            statusInput.Font = new Font("Microsoft YaHei UI", 10F);
            statusInput.Location = new Point(0, 300);
            statusInput.Margin = new Padding(0);
            statusInput.Multiline = true;
            statusInput.Name = "statusInput";
            statusInput.ReadOnly = true;
            statusInput.Size = new Size(244, 250);
            statusInput.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel9.Controls.Add(slaveTable, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(253, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(1144, 794);
            tableLayoutPanel9.TabIndex = 6;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(incrementTimeInput, 1, 3);
            tableLayoutPanel10.Controls.Add(incrementTimeLabel, 0, 3);
            tableLayoutPanel10.Controls.Add(numRegistersLabel, 0, 2);
            tableLayoutPanel10.Controls.Add(addressLabel, 0, 1);
            tableLayoutPanel10.Controls.Add(slaveIdLabel, 0, 0);
            tableLayoutPanel10.Controls.Add(slaveIdInput, 1, 0);
            tableLayoutPanel10.Controls.Add(addressInput, 1, 1);
            tableLayoutPanel10.Controls.Add(numRegistersInput, 1, 2);
            tableLayoutPanel10.Controls.Add(connectLabel, 0, 4);
            tableLayoutPanel10.Controls.Add(connectButton, 1, 4);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 7;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(244, 788);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // incrementTimeInput
            // 
            incrementTimeInput.Anchor = AnchorStyles.None;
            incrementTimeInput.Location = new Point(122, 150);
            incrementTimeInput.Margin = new Padding(0);
            incrementTimeInput.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            incrementTimeInput.Name = "incrementTimeInput";
            incrementTimeInput.Size = new Size(122, 50);
            incrementTimeInput.TabIndex = 8;
            incrementTimeInput.Text = "1000";
            incrementTimeInput.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // incrementTimeLabel
            // 
            incrementTimeLabel.Anchor = AnchorStyles.Left;
            incrementTimeLabel.Font = new Font("Microsoft YaHei UI", 12F);
            incrementTimeLabel.LocalizationText = "incrementTime";
            incrementTimeLabel.Location = new Point(3, 153);
            incrementTimeLabel.Name = "incrementTimeLabel";
            incrementTimeLabel.Size = new Size(116, 44);
            incrementTimeLabel.TabIndex = 7;
            incrementTimeLabel.Text = "自增(ms)";
            // 
            // numRegistersLabel
            // 
            numRegistersLabel.Anchor = AnchorStyles.Left;
            numRegistersLabel.Font = new Font("Microsoft YaHei UI", 12F);
            numRegistersLabel.LocalizationText = "numRegisters";
            numRegistersLabel.Location = new Point(3, 103);
            numRegistersLabel.Name = "numRegistersLabel";
            numRegistersLabel.Size = new Size(116, 44);
            numRegistersLabel.TabIndex = 5;
            numRegistersLabel.Text = "寄存器数量";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Left;
            addressLabel.Font = new Font("Microsoft YaHei UI", 12F);
            addressLabel.LocalizationText = "address";
            addressLabel.Location = new Point(3, 53);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(116, 44);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "地址";
            // 
            // slaveIdLabel
            // 
            slaveIdLabel.Anchor = AnchorStyles.Left;
            slaveIdLabel.Font = new Font("Microsoft YaHei UI", 12F);
            slaveIdLabel.LocalizationText = "slaveId";
            slaveIdLabel.Location = new Point(3, 3);
            slaveIdLabel.Name = "slaveIdLabel";
            slaveIdLabel.Size = new Size(116, 44);
            slaveIdLabel.TabIndex = 3;
            slaveIdLabel.Text = "slaveId";
            // 
            // slaveIdInput
            // 
            slaveIdInput.Anchor = AnchorStyles.None;
            slaveIdInput.Location = new Point(122, 0);
            slaveIdInput.Margin = new Padding(0);
            slaveIdInput.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            slaveIdInput.Name = "slaveIdInput";
            slaveIdInput.Size = new Size(122, 50);
            slaveIdInput.TabIndex = 0;
            slaveIdInput.Text = "1";
            slaveIdInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addressInput
            // 
            addressInput.Anchor = AnchorStyles.None;
            addressInput.Location = new Point(122, 50);
            addressInput.Margin = new Padding(0);
            addressInput.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(122, 50);
            addressInput.TabIndex = 1;
            addressInput.Text = "0";
            // 
            // numRegistersInput
            // 
            numRegistersInput.Anchor = AnchorStyles.None;
            numRegistersInput.Location = new Point(122, 100);
            numRegistersInput.Margin = new Padding(0);
            numRegistersInput.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numRegistersInput.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numRegistersInput.Name = "numRegistersInput";
            numRegistersInput.Size = new Size(122, 50);
            numRegistersInput.TabIndex = 2;
            numRegistersInput.Text = "10";
            numRegistersInput.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // connectLabel
            // 
            connectLabel.Anchor = AnchorStyles.Left;
            connectLabel.Font = new Font("Microsoft YaHei UI", 12F);
            connectLabel.LocalizationText = "connectLabel";
            connectLabel.Location = new Point(3, 203);
            connectLabel.Name = "connectLabel";
            connectLabel.Size = new Size(116, 44);
            connectLabel.TabIndex = 1;
            connectLabel.Text = "连接";
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.None;
            connectButton.Font = new Font("Microsoft YaHei UI", 12F);
            connectButton.LocalizationText = "connectButton";
            connectButton.Location = new Point(122, 200);
            connectButton.Margin = new Padding(0);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(122, 50);
            connectButton.TabIndex = 0;
            connectButton.Text = "连接";
            connectButton.Type = AntdUI.TTypeMini.Success;
            connectButton.Click += connectButton_Click;
            // 
            // slaveTable
            // 
            slaveTable.Dock = DockStyle.Fill;
            slaveTable.Location = new Point(253, 3);
            slaveTable.Name = "slaveTable";
            slaveTable.Size = new Size(884, 788);
            slaveTable.TabIndex = 5;
            // 
            // ModbusSlaveForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "ModbusSlaveForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
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
        private AntdUI.Button connectButton;
        private AntdUI.Label connectLabel;
        private AntdUI.Input statusInput;
        private TableLayoutPanel tableLayoutPanel11;
        private AntdUI.Button refreshBtn;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private AntdUI.InputNumber slaveIdInput;
        private AntdUI.InputNumber addressInput;
        private AntdUI.InputNumber numRegistersInput;
        private AntdUI.Label numRegistersLabel;
        private AntdUI.Label addressLabel;
        private AntdUI.Label slaveIdLabel;
        private AntdUI.Table slaveTable;
        private AntdUI.Select functionSelect;
        private AntdUI.Label incrementTimeLabel;
        private AntdUI.InputNumber incrementTimeInput;
    }
}