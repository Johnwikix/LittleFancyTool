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
            rsaEncryptBtn = new Button();
            rsaDecryptBtn = new Button();
            rsaPaddingModeComboBox = new ComboBox();
            rsaInputTextBox = new TextBox();
            rsaOutputTextBox = new TextBox();
            rsaPublicKeyTextBox = new TextBox();
            rsaPrivateKeyTextBox = new TextBox();
            rsaGenKeyBtn = new Button();
            rsaKeyLengthComboBox = new ComboBox();
            rsaKeyFormatComboBox = new ComboBox();
            inputLabel = new Label();
            outputLabel = new Label();
            publicKeyLabel = new Label();
            privateKeyLabel = new Label();
            SuspendLayout();
            // 
            // rsaEncryptBtn
            // 
            rsaEncryptBtn.Location = new Point(642, 107);
            rsaEncryptBtn.Name = "rsaEncryptBtn";
            rsaEncryptBtn.Size = new Size(112, 34);
            rsaEncryptBtn.TabIndex = 0;
            rsaEncryptBtn.Text = "加密>>";
            rsaEncryptBtn.UseVisualStyleBackColor = true;
            rsaEncryptBtn.Click += rsaEncryptButton_Click;
            // 
            // rsaDecryptBtn
            // 
            rsaDecryptBtn.Location = new Point(642, 162);
            rsaDecryptBtn.Name = "rsaDecryptBtn";
            rsaDecryptBtn.Size = new Size(112, 34);
            rsaDecryptBtn.TabIndex = 1;
            rsaDecryptBtn.Text = "解密<<";
            rsaDecryptBtn.UseVisualStyleBackColor = true;
            rsaDecryptBtn.Click += rsaDecryptButton_Click;
            // 
            // rsaPaddingModeComboBox
            // 
            rsaPaddingModeComboBox.FormattingEnabled = true;
            rsaPaddingModeComboBox.Items.AddRange(new object[] { "Pkcs1", "OaepSHA1", "OaepSHA256", "OaepSHA384", "OaepSHA512" });
            rsaPaddingModeComboBox.Location = new Point(642, 219);
            rsaPaddingModeComboBox.Name = "rsaPaddingModeComboBox";
            rsaPaddingModeComboBox.Size = new Size(112, 32);
            rsaPaddingModeComboBox.TabIndex = 2;
            // 
            // rsaInputTextBox
            // 
            rsaInputTextBox.Location = new Point(97, 107);
            rsaInputTextBox.Multiline = true;
            rsaInputTextBox.Name = "rsaInputTextBox";
            rsaInputTextBox.ScrollBars = ScrollBars.Vertical;
            rsaInputTextBox.Size = new Size(501, 237);
            rsaInputTextBox.TabIndex = 3;
            // 
            // rsaOutputTextBox
            // 
            rsaOutputTextBox.Location = new Point(818, 109);
            rsaOutputTextBox.Multiline = true;
            rsaOutputTextBox.Name = "rsaOutputTextBox";
            rsaOutputTextBox.ScrollBars = ScrollBars.Vertical;
            rsaOutputTextBox.Size = new Size(473, 235);
            rsaOutputTextBox.TabIndex = 4;
            // 
            // rsaPublicKeyTextBox
            // 
            rsaPublicKeyTextBox.Location = new Point(97, 455);
            rsaPublicKeyTextBox.Multiline = true;
            rsaPublicKeyTextBox.Name = "rsaPublicKeyTextBox";
            rsaPublicKeyTextBox.ScrollBars = ScrollBars.Vertical;
            rsaPublicKeyTextBox.Size = new Size(501, 248);
            rsaPublicKeyTextBox.TabIndex = 5;
            // 
            // rsaPrivateKeyTextBox
            // 
            rsaPrivateKeyTextBox.Location = new Point(818, 453);
            rsaPrivateKeyTextBox.Multiline = true;
            rsaPrivateKeyTextBox.Name = "rsaPrivateKeyTextBox";
            rsaPrivateKeyTextBox.ScrollBars = ScrollBars.Vertical;
            rsaPrivateKeyTextBox.Size = new Size(473, 250);
            rsaPrivateKeyTextBox.TabIndex = 6;
            // 
            // rsaGenKeyBtn
            // 
            rsaGenKeyBtn.Location = new Point(642, 453);
            rsaGenKeyBtn.Name = "rsaGenKeyBtn";
            rsaGenKeyBtn.Size = new Size(112, 34);
            rsaGenKeyBtn.TabIndex = 7;
            rsaGenKeyBtn.Text = "生成密钥";
            rsaGenKeyBtn.UseVisualStyleBackColor = true;
            rsaGenKeyBtn.Click += rsaGenerateKeyPairButton_Click;
            // 
            // rsaKeyLengthComboBox
            // 
            rsaKeyLengthComboBox.FormattingEnabled = true;
            rsaKeyLengthComboBox.Items.AddRange(new object[] { "512", "1024", "2048", "4096" });
            rsaKeyLengthComboBox.Location = new Point(645, 501);
            rsaKeyLengthComboBox.Name = "rsaKeyLengthComboBox";
            rsaKeyLengthComboBox.Size = new Size(109, 32);
            rsaKeyLengthComboBox.TabIndex = 8;
            // 
            // rsaKeyFormatComboBox
            // 
            rsaKeyFormatComboBox.FormattingEnabled = true;
            rsaKeyFormatComboBox.Items.AddRange(new object[] { "PKCS#8", "PKCS#1" });
            rsaKeyFormatComboBox.Location = new Point(645, 554);
            rsaKeyFormatComboBox.Name = "rsaKeyFormatComboBox";
            rsaKeyFormatComboBox.Size = new Size(109, 32);
            rsaKeyFormatComboBox.TabIndex = 9;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(98, 61);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(64, 24);
            inputLabel.TabIndex = 10;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(818, 61);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(64, 24);
            outputLabel.TabIndex = 11;
            outputLabel.Text = "输出框";
            // 
            // publicKeyLabel
            // 
            publicKeyLabel.AutoSize = true;
            publicKeyLabel.Location = new Point(98, 402);
            publicKeyLabel.Name = "publicKeyLabel";
            publicKeyLabel.Size = new Size(46, 24);
            publicKeyLabel.TabIndex = 12;
            publicKeyLabel.Text = "公钥";
            // 
            // privateKeyLabel
            // 
            privateKeyLabel.AutoSize = true;
            privateKeyLabel.Location = new Point(818, 402);
            privateKeyLabel.Name = "privateKeyLabel";
            privateKeyLabel.Size = new Size(46, 24);
            privateKeyLabel.TabIndex = 13;
            privateKeyLabel.Text = "私钥";
            // 
            // RSAForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 744);
            Controls.Add(privateKeyLabel);
            Controls.Add(publicKeyLabel);
            Controls.Add(outputLabel);
            Controls.Add(inputLabel);
            Controls.Add(rsaKeyFormatComboBox);
            Controls.Add(rsaKeyLengthComboBox);
            Controls.Add(rsaGenKeyBtn);
            Controls.Add(rsaPrivateKeyTextBox);
            Controls.Add(rsaPublicKeyTextBox);
            Controls.Add(rsaOutputTextBox);
            Controls.Add(rsaInputTextBox);
            Controls.Add(rsaPaddingModeComboBox);
            Controls.Add(rsaDecryptBtn);
            Controls.Add(rsaEncryptBtn);
            Name = "RSAForm";
            Text = "RSAForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rsaEncryptBtn;
        private Button rsaDecryptBtn;
        private ComboBox rsaPaddingModeComboBox;
        private TextBox rsaInputTextBox;
        private TextBox rsaOutputTextBox;
        private TextBox rsaPublicKeyTextBox;
        private TextBox rsaPrivateKeyTextBox;
        private Button rsaGenKeyBtn;
        private ComboBox rsaKeyLengthComboBox;
        private ComboBox rsaKeyFormatComboBox;
        private Label inputLabel;
        private Label outputLabel;
        private Label publicKeyLabel;
        private Label privateKeyLabel;
    }
}