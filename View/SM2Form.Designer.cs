namespace LittleFancyTool.View
{
    partial class SM2Form
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
            paddingModeComboBox = new AntdUI.Select();
            inputTextBox = new AntdUI.Input();
            outputTextBox = new AntdUI.Input();
            publicKeyTextBox = new AntdUI.Input();
            privateKeyTextBox = new AntdUI.Input();
            genKeyBtn = new AntdUI.Button();
            inputLabel = new AntdUI.Label();
            outputLabel = new AntdUI.Label();
            publicKeyLabel = new AntdUI.Label();
            privateKeyLabel = new AntdUI.Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
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
            encryptBtn.Click += EncryptButton_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Anchor = AnchorStyles.None;
            decryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            decryptBtn.LocalizationText = "Decrypt";
            decryptBtn.Location = new Point(3, 65);
            decryptBtn.Margin = new Padding(2);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(120, 50);
            decryptBtn.TabIndex = 1;
            decryptBtn.Text = "解密<<";
            decryptBtn.Type = AntdUI.TTypeMini.Success;
            decryptBtn.Click += DecryptButton_Click;
            // 
            // paddingModeComboBox
            // 
            paddingModeComboBox.Anchor = AnchorStyles.Top;
            paddingModeComboBox.Font = new Font("Microsoft YaHei UI", 12F);
            paddingModeComboBox.Items.AddRange(new object[] { "C1C2C3", "C1C3C2" });
            paddingModeComboBox.ListAutoWidth = true;
            paddingModeComboBox.Location = new Point(3, 122);
            paddingModeComboBox.Margin = new Padding(2);
            paddingModeComboBox.Name = "paddingModeComboBox";
            paddingModeComboBox.SelectedIndex = 0;
            paddingModeComboBox.SelectedValue = "C1C2C3";
            paddingModeComboBox.Size = new Size(120, 50);
            paddingModeComboBox.TabIndex = 2;
            paddingModeComboBox.Text = "C1C2C3";
            // 
            // inputTextBox
            // 
            inputTextBox.AutoScroll = true;
            inputTextBox.Dock = DockStyle.Fill;
            inputTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            inputTextBox.Location = new Point(5, 86);
            inputTextBox.Margin = new Padding(2);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(628, 428);
            inputTextBox.TabIndex = 3;
            // 
            // outputTextBox
            // 
            outputTextBox.AutoScroll = true;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            outputTextBox.Location = new Point(767, 86);
            outputTextBox.Margin = new Padding(2);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(628, 428);
            outputTextBox.TabIndex = 4;
            // 
            // publicKeyTextBox
            // 
            publicKeyTextBox.AutoScroll = true;
            publicKeyTextBox.Dock = DockStyle.Fill;
            publicKeyTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            publicKeyTextBox.Location = new Point(5, 598);
            publicKeyTextBox.Margin = new Padding(2);
            publicKeyTextBox.Multiline = true;
            publicKeyTextBox.Name = "publicKeyTextBox";
            publicKeyTextBox.Size = new Size(628, 196);
            publicKeyTextBox.TabIndex = 5;
            // 
            // privateKeyTextBox
            // 
            privateKeyTextBox.AutoScroll = true;
            privateKeyTextBox.Dock = DockStyle.Fill;
            privateKeyTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            privateKeyTextBox.Location = new Point(767, 598);
            privateKeyTextBox.Margin = new Padding(2);
            privateKeyTextBox.Multiline = true;
            privateKeyTextBox.Name = "privateKeyTextBox";
            privateKeyTextBox.Size = new Size(628, 196);
            privateKeyTextBox.TabIndex = 6;
            // 
            // genKeyBtn
            // 
            genKeyBtn.Anchor = AnchorStyles.Bottom;
            genKeyBtn.Font = new Font("Microsoft YaHei UI", 12F);
            genKeyBtn.LocalizationText = "GenKey";
            genKeyBtn.Location = new Point(3, 8);
            genKeyBtn.Margin = new Padding(2);
            genKeyBtn.Name = "genKeyBtn";
            genKeyBtn.Size = new Size(120, 50);
            genKeyBtn.TabIndex = 7;
            genKeyBtn.Text = "生成密钥";
            genKeyBtn.Type = AntdUI.TTypeMini.Primary;
            genKeyBtn.Click += GenerateKeyPairButton_Click;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            inputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            inputLabel.LocalizationText = "Input";
            inputLabel.Location = new Point(5, 54);
            inputLabel.Margin = new Padding(2);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(69, 28);
            inputLabel.TabIndex = 10;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            outputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            outputLabel.LocalizationText = "Output";
            outputLabel.Location = new Point(767, 54);
            outputLabel.Margin = new Padding(2);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(69, 28);
            outputLabel.TabIndex = 11;
            outputLabel.Text = "输出框";
            // 
            // publicKeyLabel
            // 
            publicKeyLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            publicKeyLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            publicKeyLabel.Font = new Font("Microsoft YaHei UI", 15F);
            publicKeyLabel.LocalizationText = "publicKey";
            publicKeyLabel.Location = new Point(5, 566);
            publicKeyLabel.Margin = new Padding(2);
            publicKeyLabel.Name = "publicKeyLabel";
            publicKeyLabel.Size = new Size(48, 28);
            publicKeyLabel.TabIndex = 12;
            publicKeyLabel.Text = "公钥";
            // 
            // privateKeyLabel
            // 
            privateKeyLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            privateKeyLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            privateKeyLabel.Font = new Font("Microsoft YaHei UI", 15F);
            privateKeyLabel.LocalizationText = "privateKey";
            privateKeyLabel.Location = new Point(767, 566);
            privateKeyLabel.Margin = new Padding(2);
            privateKeyLabel.Name = "privateKeyLabel";
            privateKeyLabel.Size = new Size(48, 28);
            privateKeyLabel.TabIndex = 13;
            privateKeyLabel.Text = "私钥";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(inputLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(privateKeyLabel, 2, 3);
            tableLayoutPanel1.Controls.Add(inputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(outputLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(publicKeyLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(publicKeyTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(privateKeyTextBox, 2, 4);
            tableLayoutPanel1.Controls.Add(outputTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(decryptBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(paddingModeComboBox, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(637, 86);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel2.Size = new Size(126, 428);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(genKeyBtn, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(637, 598);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(126, 196);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // SM2Form
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "SM2Form";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button encryptBtn;
        private AntdUI.Button decryptBtn;
        private AntdUI.Select paddingModeComboBox;
        private AntdUI.Input inputTextBox;
        private AntdUI.Input outputTextBox;
        private AntdUI.Input publicKeyTextBox;
        private AntdUI.Input privateKeyTextBox;
        private AntdUI.Button genKeyBtn;
        private AntdUI.Label inputLabel;
        private AntdUI.Label outputLabel;
        private AntdUI.Label publicKeyLabel;
        private AntdUI.Label privateKeyLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}