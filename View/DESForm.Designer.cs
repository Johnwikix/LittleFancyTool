namespace LittleFancyTool.View
{
    partial class DESForm
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
            genKeyIv = new AntdUI.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.Bottom;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            encryptBtn.Location = new Point(17, 100);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(160, 70);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "加密>>";
            encryptBtn.Type = AntdUI.TTypeMini.Primary;
            encryptBtn.Click += encryptButton_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Anchor = AnchorStyles.None;
            decryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            decryptBtn.Location = new Point(17, 199);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(160, 70);
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
            inputTextBox.Location = new Point(8, 81);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(577, 471);
            inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.AutoScroll = true;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            outputTextBox.Location = new Point(791, 81);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(579, 471);
            outputTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            inputLabel.Font = new Font("Microsoft YaHei UI", 12F);
            inputLabel.Location = new Point(8, 41);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(83, 34);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            outputLabel.Font = new Font("Microsoft YaHei UI", 12F);
            outputLabel.Location = new Point(791, 41);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(83, 34);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "输出框";
            // 
            // paddingModeComboBox
            // 
            paddingModeComboBox.Anchor = AnchorStyles.Top;
            paddingModeComboBox.Font = new Font("Microsoft YaHei UI", 12F);
            paddingModeComboBox.Items.AddRange(new object[] { "PKCS7", "Zeros", "None" });
            paddingModeComboBox.ListAutoWidth = true;
            paddingModeComboBox.Location = new Point(17, 299);
            paddingModeComboBox.Name = "paddingModeComboBox";
            paddingModeComboBox.Size = new Size(160, 70);
            paddingModeComboBox.TabIndex = 0;
            // 
            // keyTextBox
            // 
            keyTextBox.Dock = DockStyle.Fill;
            keyTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            keyTextBox.Location = new Point(8, 631);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(577, 105);
            keyTextBox.TabIndex = 6;
            // 
            // ivTextBox
            // 
            ivTextBox.Dock = DockStyle.Fill;
            ivTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            ivTextBox.Location = new Point(791, 631);
            ivTextBox.Name = "ivTextBox";
            ivTextBox.Size = new Size(579, 105);
            ivTextBox.TabIndex = 7;
            // 
            // key
            // 
            key.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            key.AutoSizeMode = AntdUI.TAutoSize.Auto;
            key.Font = new Font("Microsoft YaHei UI", 12F);
            key.Location = new Point(8, 591);
            key.Name = "key";
            key.Size = new Size(58, 34);
            key.TabIndex = 8;
            key.Text = "密钥";
            // 
            // iv
            // 
            iv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iv.AutoSizeMode = AntdUI.TAutoSize.Auto;
            iv.Font = new Font("Microsoft YaHei UI", 12F);
            iv.Location = new Point(791, 591);
            iv.Name = "iv";
            iv.Size = new Size(58, 34);
            iv.TabIndex = 9;
            iv.Text = "偏移";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
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
            tableLayoutPanel1.Margin = new Padding(30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(1378, 744);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(decryptBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(paddingModeComboBox, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(591, 81);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 50, 0, 50);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(194, 471);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // genKeyIv
            // 
            genKeyIv.Anchor = AnchorStyles.None;
            genKeyIv.Font = new Font("Microsoft YaHei UI", 12F);
            genKeyIv.Location = new Point(608, 650);
            genKeyIv.Name = "genKeyIv";
            genKeyIv.Size = new Size(160, 67);
            genKeyIv.TabIndex = 12;
            genKeyIv.Text = "生成密钥iv";
            genKeyIv.Type = AntdUI.TTypeMini.Primary;
            genKeyIv.Click += genKeyIv_Click;
            // 
            // DESForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DESForm";
            Size = new Size(1378, 744);
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
        //private AntdUI.Select keyLengthComboBox;
    }
}