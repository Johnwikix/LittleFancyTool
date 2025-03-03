using CryptoTool.Algorithms;

namespace CryptoTool.View
{
    partial class RSAForm
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
            rsaEncryptBtn = new AntdUI.Button();
            rsaDecryptBtn = new AntdUI.Button();
            rsaPaddingModeComboBox = new AntdUI.Select();
            rsaInputTextBox = new AntdUI.Input();
            rsaOutputTextBox = new AntdUI.Input();
            rsaPublicKeyTextBox = new AntdUI.Input();
            rsaPrivateKeyTextBox = new AntdUI.Input();
            rsaGenKeyBtn = new AntdUI.Button();
            rsaKeyLengthComboBox = new AntdUI.Select();
            rsaKeyFormatComboBox = new AntdUI.Select();
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
            // rsaEncryptBtn
            // 
            rsaEncryptBtn.Anchor = AnchorStyles.Bottom;
            rsaEncryptBtn.Font = new Font("Microsoft YaHei UI", 16F);
            rsaEncryptBtn.Location = new Point(3, 53);
            rsaEncryptBtn.Margin = new Padding(2);
            rsaEncryptBtn.Name = "rsaEncryptBtn";
            rsaEncryptBtn.Size = new Size(140, 60);
            rsaEncryptBtn.TabIndex = 0;
            rsaEncryptBtn.Text = "加密>>";
            rsaEncryptBtn.Type = AntdUI.TTypeMini.Primary;
            rsaEncryptBtn.Click += rsaEncryptButton_Click;
            // 
            // rsaDecryptBtn
            // 
            rsaDecryptBtn.Anchor = AnchorStyles.None;
            rsaDecryptBtn.Font = new Font("Microsoft YaHei UI", 16F);
            rsaDecryptBtn.Location = new Point(3, 125);
            rsaDecryptBtn.Margin = new Padding(2);
            rsaDecryptBtn.Name = "rsaDecryptBtn";
            rsaDecryptBtn.Size = new Size(140, 60);
            rsaDecryptBtn.TabIndex = 1;
            rsaDecryptBtn.Text = "解密<<";
            rsaDecryptBtn.Type = AntdUI.TTypeMini.Primary;
            rsaDecryptBtn.Click += rsaDecryptButton_Click;
            // 
            // rsaPaddingModeComboBox
            // 
            rsaPaddingModeComboBox.Anchor = AnchorStyles.Top;
            rsaPaddingModeComboBox.Font = new Font("Microsoft YaHei UI", 16F);
            rsaPaddingModeComboBox.Items.AddRange(new object[] { "Pkcs1", "OaepSHA1", "OaepSHA256", "OaepSHA384", "OaepSHA512" });
            rsaPaddingModeComboBox.ListAutoWidth = true;
            rsaPaddingModeComboBox.Location = new Point(3, 197);
            rsaPaddingModeComboBox.Margin = new Padding(2);
            rsaPaddingModeComboBox.Name = "rsaPaddingModeComboBox";
            rsaPaddingModeComboBox.Size = new Size(140, 60);
            rsaPaddingModeComboBox.TabIndex = 2;
            // 
            // rsaInputTextBox
            // 
            rsaInputTextBox.AutoScroll = true;
            rsaInputTextBox.Dock = DockStyle.Fill;
            rsaInputTextBox.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rsaInputTextBox.Location = new Point(5, 85);
            rsaInputTextBox.Margin = new Padding(2);
            rsaInputTextBox.Multiline = true;
            rsaInputTextBox.Name = "rsaInputTextBox";
            rsaInputTextBox.Size = new Size(618, 312);
            rsaInputTextBox.TabIndex = 3;
            // 
            // rsaOutputTextBox
            // 
            rsaOutputTextBox.AutoScroll = true;
            rsaOutputTextBox.Dock = DockStyle.Fill;
            rsaOutputTextBox.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rsaOutputTextBox.Location = new Point(777, 85);
            rsaOutputTextBox.Margin = new Padding(2);
            rsaOutputTextBox.Multiline = true;
            rsaOutputTextBox.Name = "rsaOutputTextBox";
            rsaOutputTextBox.Size = new Size(618, 312);
            rsaOutputTextBox.TabIndex = 4;
            // 
            // rsaPublicKeyTextBox
            // 
            rsaPublicKeyTextBox.AutoScroll = true;
            rsaPublicKeyTextBox.Dock = DockStyle.Fill;
            rsaPublicKeyTextBox.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rsaPublicKeyTextBox.Location = new Point(5, 480);
            rsaPublicKeyTextBox.Margin = new Padding(2);
            rsaPublicKeyTextBox.Multiline = true;
            rsaPublicKeyTextBox.Name = "rsaPublicKeyTextBox";
            rsaPublicKeyTextBox.Size = new Size(618, 314);
            rsaPublicKeyTextBox.TabIndex = 5;
            // 
            // rsaPrivateKeyTextBox
            // 
            rsaPrivateKeyTextBox.AutoScroll = true;
            rsaPrivateKeyTextBox.Dock = DockStyle.Fill;
            rsaPrivateKeyTextBox.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rsaPrivateKeyTextBox.Location = new Point(777, 480);
            rsaPrivateKeyTextBox.Margin = new Padding(2);
            rsaPrivateKeyTextBox.Multiline = true;
            rsaPrivateKeyTextBox.Name = "rsaPrivateKeyTextBox";
            rsaPrivateKeyTextBox.Size = new Size(618, 314);
            rsaPrivateKeyTextBox.TabIndex = 6;
            // 
            // rsaGenKeyBtn
            // 
            rsaGenKeyBtn.Anchor = AnchorStyles.Bottom;
            rsaGenKeyBtn.Font = new Font("Microsoft YaHei UI", 16F);
            rsaGenKeyBtn.Location = new Point(3, 54);
            rsaGenKeyBtn.Margin = new Padding(2);
            rsaGenKeyBtn.Name = "rsaGenKeyBtn";
            rsaGenKeyBtn.Size = new Size(140, 60);
            rsaGenKeyBtn.TabIndex = 7;
            rsaGenKeyBtn.Text = "生成密钥";
            rsaGenKeyBtn.Type = AntdUI.TTypeMini.Primary;
            rsaGenKeyBtn.Click += rsaGenerateKeyPairButton_Click;
            // 
            // rsaKeyLengthComboBox
            // 
            rsaKeyLengthComboBox.Anchor = AnchorStyles.None;
            rsaKeyLengthComboBox.Font = new Font("Microsoft YaHei UI", 16F);
            rsaKeyLengthComboBox.Items.AddRange(new object[] { "512", "1024", "2048", "4096" });
            rsaKeyLengthComboBox.ListAutoWidth = true;
            rsaKeyLengthComboBox.Location = new Point(3, 126);
            rsaKeyLengthComboBox.Margin = new Padding(2);
            rsaKeyLengthComboBox.Name = "rsaKeyLengthComboBox";
            rsaKeyLengthComboBox.Size = new Size(140, 60);
            rsaKeyLengthComboBox.TabIndex = 8;
            // 
            // rsaKeyFormatComboBox
            // 
            rsaKeyFormatComboBox.Anchor = AnchorStyles.Top;
            rsaKeyFormatComboBox.Font = new Font("Microsoft YaHei UI", 16F);
            rsaKeyFormatComboBox.Items.AddRange(new object[] { "PKCS#8", "PKCS#1" });
            rsaKeyFormatComboBox.ListAutoWidth = true;
            rsaKeyFormatComboBox.Location = new Point(3, 198);
            rsaKeyFormatComboBox.Margin = new Padding(2);
            rsaKeyFormatComboBox.Name = "rsaKeyFormatComboBox";
            rsaKeyFormatComboBox.Size = new Size(140, 60);
            rsaKeyFormatComboBox.TabIndex = 9;
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
            inputLabel.TabIndex = 10;
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
            outputLabel.TabIndex = 11;
            outputLabel.Text = "输出框";
            // 
            // publicKeyLabel
            // 
            publicKeyLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            publicKeyLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            publicKeyLabel.Font = new Font("Microsoft YaHei UI", 18F);
            publicKeyLabel.Location = new Point(5, 442);
            publicKeyLabel.Margin = new Padding(2);
            publicKeyLabel.Name = "publicKeyLabel";
            publicKeyLabel.Size = new Size(58, 34);
            publicKeyLabel.TabIndex = 12;
            publicKeyLabel.Text = "公钥";
            // 
            // privateKeyLabel
            // 
            privateKeyLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            privateKeyLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            privateKeyLabel.Font = new Font("Microsoft YaHei UI", 18F);
            privateKeyLabel.Location = new Point(777, 442);
            privateKeyLabel.Margin = new Padding(2);
            privateKeyLabel.Name = "privateKeyLabel";
            privateKeyLabel.Size = new Size(58, 34);
            privateKeyLabel.TabIndex = 13;
            privateKeyLabel.Text = "私钥";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(inputLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(privateKeyLabel, 2, 3);
            tableLayoutPanel1.Controls.Add(rsaInputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(outputLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(publicKeyLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(rsaPublicKeyTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(rsaPrivateKeyTextBox, 2, 4);
            tableLayoutPanel1.Controls.Add(rsaOutputTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(rsaEncryptBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(rsaDecryptBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(rsaPaddingModeComboBox, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(627, 85);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel2.Size = new Size(146, 312);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(rsaGenKeyBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(rsaKeyFormatComboBox, 0, 2);
            tableLayoutPanel3.Controls.Add(rsaKeyLengthComboBox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(627, 480);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel3.Size = new Size(146, 314);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // RSAForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "RSAForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button rsaEncryptBtn;
        private AntdUI.Button rsaDecryptBtn;
        private AntdUI.Select rsaPaddingModeComboBox;
        private AntdUI.Input rsaInputTextBox;
        private AntdUI.Input rsaOutputTextBox;
        private AntdUI.Input rsaPublicKeyTextBox;
        private AntdUI.Input rsaPrivateKeyTextBox;
        private AntdUI.Button rsaGenKeyBtn;
        private AntdUI.Select rsaKeyLengthComboBox;
        private AntdUI.Select rsaKeyFormatComboBox;
        private AntdUI.Label inputLabel;
        private AntdUI.Label outputLabel;
        private AntdUI.Label publicKeyLabel;
        private AntdUI.Label privateKeyLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}