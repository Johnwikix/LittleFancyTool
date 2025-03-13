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
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            sendBtn = new AntdUI.Button();
            sendInput = new AntdUI.Input();
            receivedInput1 = new AntdUI.Input();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 1);
            tableLayoutPanel1.Controls.Add(receivedInput1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 0;
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
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(294, 466);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(modeLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(modeSelect, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(288, 54);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // modeLabel
            // 
            modeLabel.Anchor = AnchorStyles.Left;
            modeLabel.Font = new Font("Microsoft YaHei UI", 15F);
            modeLabel.Location = new Point(3, 3);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(94, 48);
            modeLabel.TabIndex = 1;
            modeLabel.Text = "模式";
            // 
            // modeSelect
            // 
            modeSelect.Anchor = AnchorStyles.Left;
            modeSelect.Font = new Font("Microsoft YaHei UI", 12F);
            modeSelect.Items.AddRange(new object[] { "server", "client" });
            modeSelect.Location = new Point(103, 4);
            modeSelect.Name = "modeSelect";
            modeSelect.SelectedIndex = 0;
            modeSelect.SelectedValue = "server";
            modeSelect.Size = new Size(150, 45);
            modeSelect.TabIndex = 0;
            modeSelect.Text = "server";
            modeSelect.SelectedIndexChanged += modeSelect_SelectedIndexChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(addressLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(addressInput, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 63);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(288, 54);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Left;
            addressLabel.Font = new Font("Microsoft YaHei UI", 15F);
            addressLabel.Location = new Point(3, 3);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(94, 48);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "地址";
            // 
            // addressInput
            // 
            addressInput.Anchor = AnchorStyles.Left;
            addressInput.Font = new Font("Microsoft YaHei UI", 12F);
            addressInput.Location = new Point(103, 4);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(150, 45);
            addressInput.TabIndex = 1;
            addressInput.Text = "127.0.0.1";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(portInput, 1, 0);
            tableLayoutPanel5.Controls.Add(portLabel, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 123);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(288, 54);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // portInput
            // 
            portInput.Anchor = AnchorStyles.Left;
            portInput.Font = new Font("Microsoft YaHei UI", 12F);
            portInput.Location = new Point(103, 4);
            portInput.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            portInput.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            portInput.Name = "portInput";
            portInput.Size = new Size(150, 45);
            portInput.TabIndex = 2;
            portInput.Text = "2345";
            portInput.Value = new decimal(new int[] { 2345, 0, 0, 0 });
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.Left;
            portLabel.Font = new Font("Microsoft YaHei UI", 15F);
            portLabel.Location = new Point(3, 3);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(94, 48);
            portLabel.TabIndex = 1;
            portLabel.Text = "端口";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(connectButton, 1, 0);
            tableLayoutPanel6.Controls.Add(connectLabel, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 183);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(288, 54);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.Left;
            connectButton.Font = new Font("Microsoft YaHei UI", 14F);
            connectButton.Location = new Point(103, 4);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(150, 45);
            connectButton.TabIndex = 0;
            connectButton.Text = "启动服务";
            connectButton.Type = AntdUI.TTypeMini.Success;
            connectButton.Click += connectButton_Click;
            // 
            // connectLabel
            // 
            connectLabel.Anchor = AnchorStyles.Left;
            connectLabel.Font = new Font("Microsoft YaHei UI", 15F);
            connectLabel.Location = new Point(3, 3);
            connectLabel.Name = "connectLabel";
            connectLabel.Size = new Size(94, 48);
            connectLabel.TabIndex = 1;
            connectLabel.Text = "服务";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 243);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(288, 54);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 475);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(294, 164);
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
            tableLayoutPanel10.Location = new Point(303, 475);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(1094, 164);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // sendBtn
            // 
            sendBtn.Dock = DockStyle.Fill;
            sendBtn.Font = new Font("Microsoft YaHei UI", 18F);
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
            sendInput.Location = new Point(173, 3);
            sendInput.Multiline = true;
            sendInput.Name = "sendInput";
            sendInput.Size = new Size(918, 158);
            sendInput.TabIndex = 1;
            // 
            // receivedInput1
            // 
            receivedInput1.Dock = DockStyle.Fill;
            receivedInput1.Location = new Point(303, 3);
            receivedInput1.Multiline = true;
            receivedInput1.Name = "receivedInput1";
            receivedInput1.ReadOnly = true;
            receivedInput1.Size = new Size(1094, 466);
            receivedInput1.TabIndex = 4;
            // 
            // TcpServerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "TcpServerForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
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
    }
}