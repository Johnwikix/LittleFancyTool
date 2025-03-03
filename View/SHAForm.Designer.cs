namespace LittleFancyTool.View
{
    partial class SHAForm
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
            encryptBtn = new AntdUI.Button();
            inputTextBox = new AntdUI.Input();
            outputTextBox = new AntdUI.Input();
            inputLabel = new AntdUI.Label();
            outputLabel = new AntdUI.Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            mode = new AntdUI.Select();
            upperLowerCase = new AntdUI.Select();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.Bottom;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 16F);
            encryptBtn.Location = new Point(3, 54);
            encryptBtn.Margin = new Padding(2);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(140, 60);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "加密>>";
            encryptBtn.Type = AntdUI.TTypeMini.Primary;
            encryptBtn.Click += encryptButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.AutoScroll = true;
            inputTextBox.Dock = DockStyle.Fill;
            inputTextBox.Font = new Font("Microsoft YaHei UI", 16F);
            inputTextBox.Location = new Point(5, 85);
            inputTextBox.Margin = new Padding(2);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(618, 392);
            inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.AutoScroll = true;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Font = new Font("Microsoft YaHei UI", 16F);
            outputTextBox.Location = new Point(777, 85);
            outputTextBox.Margin = new Padding(2);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(618, 392);
            outputTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            inputLabel.Font = new Font("Microsoft YaHei UI", 18F);
            inputLabel.Location = new Point(5, 47);
            inputLabel.Margin = new Padding(2);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(83, 34);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            outputLabel.Font = new Font("Microsoft YaHei UI", 18F);
            outputLabel.Location = new Point(777, 47);
            outputLabel.Margin = new Padding(2);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(83, 34);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "输出框";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(outputLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(inputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(outputTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(inputLabel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(mode, 0, 1);
            tableLayoutPanel2.Controls.Add(upperLowerCase, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(627, 85);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(146, 392);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // mode
            // 
            mode.Anchor = AnchorStyles.None;
            mode.Font = new Font("Microsoft YaHei UI", 16F);
            mode.Items.AddRange(new object[] { "SHA1", "SHA256", "SHA384", "SHA512" });
            mode.Location = new Point(3, 126);
            mode.Margin = new Padding(2);
            mode.Name = "mode";
            mode.Size = new Size(140, 60);
            mode.TabIndex = 1;
            mode.Text = "算法";
            // 
            // upperLowerCase
            // 
            upperLowerCase.Anchor = AnchorStyles.Top;
            upperLowerCase.Font = new Font("Microsoft YaHei UI", 16F);
            upperLowerCase.Items.AddRange(new object[] { "UPPER", "lower" });
            upperLowerCase.Location = new Point(3, 198);
            upperLowerCase.Margin = new Padding(2);
            upperLowerCase.Name = "upperLowerCase";
            upperLowerCase.Size = new Size(140, 60);
            upperLowerCase.TabIndex = 2;
            upperLowerCase.Text = "大小写";
            // 
            // SHAForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "SHAForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button encryptBtn;
        //private AntdUI.Button decryptBtn;
        private AntdUI.Input inputTextBox;
        private AntdUI.Input outputTextBox;
        private AntdUI.Label inputLabel;
        private AntdUI.Label outputLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.Select mode;
        private AntdUI.Select upperLowerCase;
    }
}