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
            encryptMode = new AntdUI.Select();
            tableLayoutPanel3 = new TableLayoutPanel();
            outputTypeSelect = new AntdUI.Select();
            tableLayoutPanel4 = new TableLayoutPanel();
            genKeyIv = new AntdUI.Button();
            keyIvTypeSelect = new AntdUI.Select();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.Bottom;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            encryptBtn.LocalizationText = "Encrypt";
            encryptBtn.Location = new Point(5, 8);
            encryptBtn.Margin = new Padding(2);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(120, 50);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "加密>>";
            encryptBtn.Type = AntdUI.TTypeMini.Primary;
            encryptBtn.Click += encryptButton_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Anchor = AnchorStyles.None;
            decryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            decryptBtn.LocalizationText = "Decrypt";
            decryptBtn.Location = new Point(5, 65);
            decryptBtn.Margin = new Padding(2);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(120, 50);
            decryptBtn.TabIndex = 1;
            decryptBtn.Text = "解密<<";
            decryptBtn.Type = AntdUI.TTypeMini.Success;
            decryptBtn.Click += decryptButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.AutoScroll = true;
            inputTextBox.Dock = DockStyle.Fill;
            inputTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            inputTextBox.Location = new Point(5, 86);
            inputTextBox.Margin = new Padding(2);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(628, 428);
            inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.AutoScroll = true;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            outputTextBox.Location = new Point(767, 86);
            outputTextBox.Margin = new Padding(2);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(628, 428);
            outputTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            inputLabel.LocalizationText = "Input";
            inputLabel.Location = new Point(5, 32);
            inputLabel.Margin = new Padding(2);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(83, 50);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            outputLabel.LocalizationText = "Output";
            outputLabel.Location = new Point(2, 22);
            outputLabel.Margin = new Padding(2);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(83, 50);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "输出框";
            // 
            // paddingModeComboBox
            // 
            paddingModeComboBox.Anchor = AnchorStyles.None;
            paddingModeComboBox.Font = new Font("Microsoft YaHei UI", 12F);
            paddingModeComboBox.Items.AddRange(new object[] { "PKCS7", "Zeros", "None" });
            paddingModeComboBox.ListAutoWidth = true;
            paddingModeComboBox.Location = new Point(5, 125);
            paddingModeComboBox.Margin = new Padding(2);
            paddingModeComboBox.Name = "paddingModeComboBox";
            paddingModeComboBox.SelectedIndex = 0;
            paddingModeComboBox.SelectedValue = "PKCS7";
            paddingModeComboBox.Size = new Size(120, 50);
            paddingModeComboBox.TabIndex = 0;
            paddingModeComboBox.Text = "PKCS7";
            // 
            // keyTextBox
            // 
            keyTextBox.Dock = DockStyle.Fill;
            keyTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            keyTextBox.Location = new Point(5, 598);
            keyTextBox.Margin = new Padding(2);
            keyTextBox.Multiline = true;
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(628, 196);
            keyTextBox.TabIndex = 6;
            // 
            // ivTextBox
            // 
            ivTextBox.Dock = DockStyle.Fill;
            ivTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            ivTextBox.Location = new Point(767, 598);
            ivTextBox.Margin = new Padding(2);
            ivTextBox.Multiline = true;
            ivTextBox.Name = "ivTextBox";
            ivTextBox.Size = new Size(628, 196);
            ivTextBox.TabIndex = 7;
            // 
            // key
            // 
            key.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            key.AutoSizeMode = AntdUI.TAutoSize.Auto;
            key.Font = new Font("Microsoft YaHei UI", 15F);
            key.LocalizationText = "Key";
            key.Location = new Point(5, 566);
            key.Margin = new Padding(2);
            key.Name = "key";
            key.Size = new Size(48, 28);
            key.TabIndex = 8;
            key.Text = "密钥";
            // 
            // iv
            // 
            iv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iv.AutoSizeMode = AntdUI.TAutoSize.Auto;
            iv.Font = new Font("Microsoft YaHei UI", 15F);
            iv.LocalizationText = "Iv";
            iv.Location = new Point(767, 566);
            iv.Margin = new Padding(2);
            iv.Name = "iv";
            iv.Size = new Size(48, 28);
            iv.TabIndex = 9;
            iv.Text = "偏移";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(inputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(iv, 2, 3);
            tableLayoutPanel1.Controls.Add(ivTextBox, 2, 4);
            tableLayoutPanel1.Controls.Add(key, 0, 3);
            tableLayoutPanel1.Controls.Add(keyTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(outputTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(inputLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(19, 21, 19, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Size = new Size(1400, 800);
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
            tableLayoutPanel2.Location = new Point(635, 84);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(130, 432);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // encryptMode
            // 
            encryptMode.Anchor = AnchorStyles.Top;
            encryptMode.Font = new Font("Microsoft YaHei UI", 12F);
            encryptMode.Items.AddRange(new object[] { "ECB", "CBC" });
            encryptMode.Location = new Point(5, 183);
            encryptMode.Name = "encryptMode";
            encryptMode.SelectedIndex = 0;
            encryptMode.SelectedValue = "ECB";
            encryptMode.Size = new Size(120, 50);
            encryptMode.TabIndex = 2;
            encryptMode.Text = "ECB";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(outputLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(outputTypeSelect, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Left;
            tableLayoutPanel3.Location = new Point(768, 7);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(250, 74);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // outputTypeSelect
            // 
            outputTypeSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputTypeSelect.Font = new Font("Microsoft YaHei UI", 12F);
            outputTypeSelect.Items.AddRange(new object[] { "base64", "hex" });
            outputTypeSelect.Location = new Point(103, 21);
            outputTypeSelect.Name = "outputTypeSelect";
            outputTypeSelect.SelectedIndex = 0;
            outputTypeSelect.SelectedValue = "base64";
            outputTypeSelect.Size = new Size(120, 50);
            outputTypeSelect.TabIndex = 6;
            outputTypeSelect.Text = "base64";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(genKeyIv, 0, 0);
            tableLayoutPanel4.Controls.Add(keyIvTypeSelect, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(635, 596);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(130, 200);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // genKeyIv
            // 
            genKeyIv.Anchor = AnchorStyles.Bottom;
            genKeyIv.Font = new Font("Microsoft YaHei UI", 12F);
            genKeyIv.LocalizationText = "GenKeyIv";
            genKeyIv.Location = new Point(5, 14);
            genKeyIv.Margin = new Padding(2);
            genKeyIv.Name = "genKeyIv";
            genKeyIv.Size = new Size(120, 50);
            genKeyIv.TabIndex = 12;
            genKeyIv.Text = "生成密钥iv";
            genKeyIv.Type = AntdUI.TTypeMini.Primary;
            genKeyIv.Click += genKeyIv_Click;
            // 
            // keyIvTypeSelect
            // 
            keyIvTypeSelect.Anchor = AnchorStyles.None;
            keyIvTypeSelect.Font = new Font("Microsoft YaHei UI", 12F);
            keyIvTypeSelect.Items.AddRange(new object[] { "text", "hex", "base64" });
            keyIvTypeSelect.Location = new Point(5, 74);
            keyIvTypeSelect.Name = "keyIvTypeSelect";
            keyIvTypeSelect.SelectedIndex = 0;
            keyIvTypeSelect.SelectedValue = "text";
            keyIvTypeSelect.Size = new Size(120, 50);
            keyIvTypeSelect.TabIndex = 13;
            keyIvTypeSelect.Text = "text";
            // 
            // DESForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "DESForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel3;
        private AntdUI.Select outputTypeSelect;
        private TableLayoutPanel tableLayoutPanel4;
        private AntdUI.Select keyIvTypeSelect;
    }
}