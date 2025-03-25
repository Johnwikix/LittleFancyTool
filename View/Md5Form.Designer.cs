namespace LittleFancyTool.View
{
    partial class Md5Form
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
            outputLengthSelect = new AntdUI.Select();
            upperLowerSelect = new AntdUI.Select();
            tableLayoutPanel3 = new TableLayoutPanel();
            addFileBtn = new AntdUI.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.Bottom;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            encryptBtn.LocalizationText = "Encrypt";
            encryptBtn.Location = new Point(3, 8);
            encryptBtn.Margin = new Padding(2);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(120, 50);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "加密>>";
            encryptBtn.Type = AntdUI.TTypeMini.Primary;
            encryptBtn.Click += encryptButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.AutoScroll = true;
            inputTextBox.Dock = DockStyle.Fill;
            inputTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            inputTextBox.Location = new Point(5, 66);
            inputTextBox.Margin = new Padding(2);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(628, 728);
            inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.AutoScroll = true;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            outputTextBox.Location = new Point(767, 66);
            outputTextBox.Margin = new Padding(2);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(628, 728);
            outputTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            inputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            inputLabel.LocalizationText = "Input";
            inputLabel.Location = new Point(2, 30);
            inputLabel.Margin = new Padding(2);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(69, 28);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            outputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            outputLabel.LocalizationText = "Output";
            outputLabel.Location = new Point(767, 34);
            outputLabel.Margin = new Padding(2);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(69, 28);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "输出框";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(outputLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(inputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(outputTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(outputLengthSelect, 0, 1);
            tableLayoutPanel2.Controls.Add(upperLowerSelect, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(637, 66);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(126, 728);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // outputLengthSelect
            // 
            outputLengthSelect.Anchor = AnchorStyles.None;
            outputLengthSelect.Font = new Font("Microsoft YaHei UI", 12F);
            outputLengthSelect.Items.AddRange(new object[] { "32", "16" });
            outputLengthSelect.Location = new Point(3, 65);
            outputLengthSelect.Margin = new Padding(2);
            outputLengthSelect.Name = "outputLengthSelect";
            outputLengthSelect.SelectedIndex = 0;
            outputLengthSelect.SelectedValue = "32";
            outputLengthSelect.Size = new Size(120, 50);
            outputLengthSelect.TabIndex = 1;
            outputLengthSelect.Text = "32";
            // 
            // upperLowerSelect
            // 
            upperLowerSelect.Anchor = AnchorStyles.Top;
            upperLowerSelect.Font = new Font("Microsoft YaHei UI", 12F);
            upperLowerSelect.Items.AddRange(new object[] { "UPPER", "lower" });
            upperLowerSelect.Location = new Point(3, 122);
            upperLowerSelect.Margin = new Padding(2);
            upperLowerSelect.Name = "upperLowerSelect";
            upperLowerSelect.SelectedIndex = 0;
            upperLowerSelect.SelectedValue = "UPPER";
            upperLowerSelect.Size = new Size(120, 50);
            upperLowerSelect.TabIndex = 2;
            upperLowerSelect.Text = "UPPER";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(inputLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(addFileBtn, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 4);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(632, 60);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // addFileBtn
            // 
            addFileBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addFileBtn.Font = new Font("Microsoft YaHei UI", 14F);
            addFileBtn.Ghost = true;
            addFileBtn.IconSvg = "FileAddOutlined";
            addFileBtn.Location = new Point(99, 27);
            addFileBtn.Name = "addFileBtn";
            addFileBtn.Size = new Size(30, 30);
            addFileBtn.TabIndex = 5;
            addFileBtn.Type = AntdUI.TTypeMini.Primary;
            addFileBtn.Click += button1_Click;
            // 
            // Md5Form
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "Md5Form";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private AntdUI.Select outputLengthSelect;
        private AntdUI.Select upperLowerSelect;
        private TableLayoutPanel tableLayoutPanel3;
        private AntdUI.Button addFileBtn;
    }
}