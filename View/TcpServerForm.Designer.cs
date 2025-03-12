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
            tableLayoutPanel11 = new TableLayoutPanel();
            portLabel = new AntdUI.Label();
            portInput = new AntdUI.InputNumber();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            connectButton = new AntdUI.Button();
            connectLabel = new AntdUI.Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            sendBtn = new AntdUI.Button();
            sendInput = new AntdUI.Input();
            receivedInput1 = new AntdUI.Input();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
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
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(344, 466);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel3.Controls.Add(portInput, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(338, 87);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Left;
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.3496933F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6503067F));
            tableLayoutPanel11.Controls.Add(portLabel, 0, 0);
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(163, 81);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.Left;
            portLabel.Font = new Font("Microsoft YaHei UI", 18F);
            portLabel.Location = new Point(3, 10);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(94, 60);
            portLabel.TabIndex = 1;
            portLabel.Text = "端口";
            // 
            // portInput
            // 
            portInput.Anchor = AnchorStyles.None;
            portInput.Location = new Point(183, 18);
            portInput.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            portInput.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            portInput.Name = "portInput";
            portInput.Size = new Size(140, 50);
            portInput.TabIndex = 2;
            portInput.Text = "2345";
            portInput.Value = new decimal(new int[] { 2345, 0, 0, 0 });
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 96);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(338, 87);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 189);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(338, 87);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 282);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(338, 87);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 375);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(338, 88);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(connectButton, 1, 0);
            tableLayoutPanel8.Controls.Add(connectLabel, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 475);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(344, 164);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.None;
            connectButton.Font = new Font("Microsoft YaHei UI", 16F);
            connectButton.Location = new Point(198, 11);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(120, 60);
            connectButton.TabIndex = 0;
            connectButton.Text = "启动服务";
            connectButton.Type = AntdUI.TTypeMini.Success;
            connectButton.Click += connectButton_Click;
            // 
            // connectLabel
            // 
            connectLabel.Anchor = AnchorStyles.Left;
            connectLabel.Font = new Font("Microsoft YaHei UI", 18F);
            connectLabel.Location = new Point(3, 11);
            connectLabel.Name = "connectLabel";
            connectLabel.Size = new Size(120, 60);
            connectLabel.TabIndex = 1;
            connectLabel.Text = "服务";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel10.Controls.Add(sendBtn, 0, 0);
            tableLayoutPanel10.Controls.Add(sendInput, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(353, 475);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(1044, 164);
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
            sendInput.Size = new Size(868, 158);
            sendInput.TabIndex = 1;
            // 
            // receivedInput1
            // 
            receivedInput1.Dock = DockStyle.Fill;
            receivedInput1.Location = new Point(353, 3);
            receivedInput1.Multiline = true;
            receivedInput1.Name = "receivedInput1";
            receivedInput1.ReadOnly = true;
            receivedInput1.Size = new Size(1044, 466);
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
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel11;
        private AntdUI.Input receivedInput1;
        private AntdUI.InputNumber portInput;
    }
}