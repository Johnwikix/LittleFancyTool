namespace LittleFancyTool.View
{
    partial class SM4Form
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
            decryptBtn = new AntdUI.Button();
            inputTextBox = new AntdUI.Input();
            outputTextBox = new AntdUI.Input();
            inputLabel = new AntdUI.Label();
            outputLabel = new AntdUI.Label();
            paddingModeComboBox = new AntdUI.Select();
            keyTextBox = new AntdUI.Input();
            ivTextBox = new AntdUI.Input();
            key = new AntdUI.Label();
            iv = new AntdUI.Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            encryptMode = new AntdUI.Select();
            genKeyIv = new AntdUI.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.Bottom;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            encryptBtn.Location = new Point(10, 44);
            encryptBtn.Margin = new Padding(2);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(102, 50);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "加密>>";
            encryptBtn.Type = AntdUI.TTypeMini.Primary;
            encryptBtn.Click += encryptButton_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Anchor = AnchorStyles.None;
            decryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            decryptBtn.Location = new Point(10, 101);
            decryptBtn.Margin = new Padding(2);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(102, 50);
            decryptBtn.TabIndex = 1;
            decryptBtn.Text = "解密<<";
            decryptBtn.Type = AntdUI.TTypeMini.Primary;
            decryptBtn.Click += decryptButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.AutoScroll = true;
            inputTextBox.Dock = DockStyle.Fill;
            inputTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            inputTextBox.Location = new Point(5, 55);
            inputTextBox.Margin = new Padding(2);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(362, 315);
            inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.AutoScroll = true;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            outputTextBox.Location = new Point(498, 55);
            outputTextBox.Margin = new Padding(2);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(364, 315);
            outputTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            inputLabel.Font = new Font("Microsoft YaHei UI", 12F);
            inputLabel.Location = new Point(5, 28);
            inputLabel.Margin = new Padding(2);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(55, 23);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            outputLabel.Font = new Font("Microsoft YaHei UI", 12F);
            outputLabel.Location = new Point(498, 28);
            outputLabel.Margin = new Padding(2);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(145, 23);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "输出框（HEX 16）";
            // 
            // paddingModeComboBox
            // 
            paddingModeComboBox.Anchor = AnchorStyles.Top;
            paddingModeComboBox.Font = new Font("Microsoft YaHei UI", 12F);
            paddingModeComboBox.Items.AddRange(new object[] { "PKCS7", "ISO10126", "ZEROBYTE" });
            paddingModeComboBox.ListAutoWidth = true;
            paddingModeComboBox.Location = new Point(10, 159);
            paddingModeComboBox.Margin = new Padding(2);
            paddingModeComboBox.Name = "paddingModeComboBox";
            paddingModeComboBox.SelectedIndex = 0;
            paddingModeComboBox.SelectedValue = "PKCS7";
            paddingModeComboBox.Size = new Size(102, 50);
            paddingModeComboBox.TabIndex = 0;
            paddingModeComboBox.Text = "PKCS7";
            // 
            // keyTextBox
            // 
            keyTextBox.Dock = DockStyle.Fill;
            keyTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            keyTextBox.Location = new Point(5, 423);
            keyTextBox.Margin = new Padding(2);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(362, 70);
            keyTextBox.TabIndex = 6;
            // 
            // ivTextBox
            // 
            ivTextBox.Dock = DockStyle.Fill;
            ivTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            ivTextBox.Location = new Point(498, 423);
            ivTextBox.Margin = new Padding(2);
            ivTextBox.Name = "ivTextBox";
            ivTextBox.Size = new Size(364, 70);
            ivTextBox.TabIndex = 7;
            // 
            // key
            // 
            key.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            key.AutoSizeMode = AntdUI.TAutoSize.Auto;
            key.Font = new Font("Microsoft YaHei UI", 12F);
            key.Location = new Point(5, 396);
            key.Margin = new Padding(2);
            key.Name = "key";
            key.Size = new Size(39, 23);
            key.TabIndex = 8;
            key.Text = "密钥";
            // 
            // iv
            // 
            iv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iv.AutoSizeMode = AntdUI.TAutoSize.Auto;
            iv.Font = new Font("Microsoft YaHei UI", 12F);
            iv.Location = new Point(498, 396);
            iv.Margin = new Padding(2);
            iv.Name = "iv";
            iv.Size = new Size(39, 23);
            iv.TabIndex = 9;
            iv.Text = "偏移";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(inputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(iv, 2, 3);
            tableLayoutPanel1.Controls.Add(ivTextBox, 2, 4);
            tableLayoutPanel1.Controls.Add(key, 0, 3);
            tableLayoutPanel1.Controls.Add(keyTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(outputTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(inputLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(outputLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(genKeyIv, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(19, 21, 19, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(867, 499);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(decryptBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(paddingModeComboBox, 0, 2);
            tableLayoutPanel2.Controls.Add(encryptMode, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(371, 55);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 35, 0, 35);
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(123, 315);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // encryptMode
            // 
            encryptMode.Anchor = AnchorStyles.Top;
            encryptMode.Font = new Font("Microsoft YaHei UI", 12F);
            encryptMode.Items.AddRange(new object[] { "ECB", "CBC" });
            encryptMode.Location = new Point(10, 221);
            encryptMode.Name = "encryptMode";
            encryptMode.SelectedIndex = 0;
            encryptMode.SelectedValue = "ECB";
            encryptMode.Size = new Size(102, 50);
            encryptMode.TabIndex = 2;
            encryptMode.Text = "ECB";
            // 
            // genKeyIv
            // 
            genKeyIv.Anchor = AnchorStyles.Top;
            genKeyIv.Font = new Font("Microsoft YaHei UI", 12F);
            genKeyIv.Location = new Point(381, 423);
            genKeyIv.Margin = new Padding(2);
            genKeyIv.Name = "genKeyIv";
            genKeyIv.Size = new Size(102, 45);
            genKeyIv.TabIndex = 12;
            genKeyIv.Text = "生成密钥iv";
            genKeyIv.Type = AntdUI.TTypeMini.Primary;
            genKeyIv.Click += genKeyIv_Click;
            // 
            // SM4Form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "SM4Form";
            Size = new Size(867, 499);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Button encryptBtn;
        private AntdUI.Button decryptBtn;
        private AntdUI.Input inputTextBox;
        private AntdUI.Input outputTextBox;
        private AntdUI.Label inputLabel;
        private AntdUI.Label outputLabel;
        private AntdUI.Select paddingModeComboBox;
        private AntdUI.Input keyTextBox;
        private AntdUI.Input ivTextBox;
        private AntdUI.Label key;
        private AntdUI.Label iv;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.Button genKeyIv;
        private AntdUI.Select encryptMode;
    }
}