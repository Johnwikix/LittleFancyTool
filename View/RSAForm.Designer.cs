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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            rsaLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // rsaEncryptBtn
            // 
            rsaEncryptBtn.Anchor = AnchorStyles.Bottom;
            rsaEncryptBtn.Location = new Point(4, 35);
            rsaEncryptBtn.Name = "rsaEncryptBtn";
            rsaEncryptBtn.Size = new Size(112, 34);
            rsaEncryptBtn.TabIndex = 0;
            rsaEncryptBtn.Text = "加密>>";
            rsaEncryptBtn.UseVisualStyleBackColor = true;
            rsaEncryptBtn.Click += rsaEncryptButton_Click;
            // 
            // rsaDecryptBtn
            // 
            rsaDecryptBtn.Anchor = AnchorStyles.None;
            rsaDecryptBtn.Location = new Point(4, 91);
            rsaDecryptBtn.Name = "rsaDecryptBtn";
            rsaDecryptBtn.Size = new Size(112, 34);
            rsaDecryptBtn.TabIndex = 1;
            rsaDecryptBtn.Text = "解密<<";
            rsaDecryptBtn.UseVisualStyleBackColor = true;
            rsaDecryptBtn.Click += rsaDecryptButton_Click;
            // 
            // rsaPaddingModeComboBox
            // 
            rsaPaddingModeComboBox.Anchor = AnchorStyles.Top;
            rsaPaddingModeComboBox.FormattingEnabled = true;
            rsaPaddingModeComboBox.Items.AddRange(new object[] { "Pkcs1", "OaepSHA1", "OaepSHA256", "OaepSHA384", "OaepSHA512" });
            rsaPaddingModeComboBox.Location = new Point(4, 147);
            rsaPaddingModeComboBox.Name = "rsaPaddingModeComboBox";
            rsaPaddingModeComboBox.Size = new Size(112, 32);
            rsaPaddingModeComboBox.TabIndex = 2;
            // 
            // rsaInputTextBox
            // 
            rsaInputTextBox.Dock = DockStyle.Fill;
            rsaInputTextBox.Location = new Point(53, 181);
            rsaInputTextBox.Multiline = true;
            rsaInputTextBox.Name = "rsaInputTextBox";
            rsaInputTextBox.ScrollBars = ScrollBars.Vertical;
            rsaInputTextBox.Size = new Size(569, 219);
            rsaInputTextBox.TabIndex = 3;
            // 
            // rsaOutputTextBox
            // 
            rsaOutputTextBox.Dock = DockStyle.Fill;
            rsaOutputTextBox.Location = new Point(755, 181);
            rsaOutputTextBox.Multiline = true;
            rsaOutputTextBox.Name = "rsaOutputTextBox";
            rsaOutputTextBox.ScrollBars = ScrollBars.Vertical;
            rsaOutputTextBox.Size = new Size(570, 219);
            rsaOutputTextBox.TabIndex = 4;
            // 
            // rsaPublicKeyTextBox
            // 
            rsaPublicKeyTextBox.Dock = DockStyle.Fill;
            rsaPublicKeyTextBox.Location = new Point(53, 470);
            rsaPublicKeyTextBox.Multiline = true;
            rsaPublicKeyTextBox.Name = "rsaPublicKeyTextBox";
            rsaPublicKeyTextBox.ScrollBars = ScrollBars.Vertical;
            rsaPublicKeyTextBox.Size = new Size(569, 221);
            rsaPublicKeyTextBox.TabIndex = 5;
            // 
            // rsaPrivateKeyTextBox
            // 
            rsaPrivateKeyTextBox.Dock = DockStyle.Fill;
            rsaPrivateKeyTextBox.Location = new Point(755, 470);
            rsaPrivateKeyTextBox.Multiline = true;
            rsaPrivateKeyTextBox.Name = "rsaPrivateKeyTextBox";
            rsaPrivateKeyTextBox.ScrollBars = ScrollBars.Vertical;
            rsaPrivateKeyTextBox.Size = new Size(570, 221);
            rsaPrivateKeyTextBox.TabIndex = 6;
            // 
            // rsaGenKeyBtn
            // 
            rsaGenKeyBtn.Anchor = AnchorStyles.Bottom;
            rsaGenKeyBtn.AutoSize = true;
            rsaGenKeyBtn.Location = new Point(4, 36);
            rsaGenKeyBtn.Name = "rsaGenKeyBtn";
            rsaGenKeyBtn.Size = new Size(112, 34);
            rsaGenKeyBtn.TabIndex = 7;
            rsaGenKeyBtn.Text = "生成密钥";
            rsaGenKeyBtn.UseVisualStyleBackColor = true;
            rsaGenKeyBtn.Click += rsaGenerateKeyPairButton_Click;
            // 
            // rsaKeyLengthComboBox
            // 
            rsaKeyLengthComboBox.Anchor = AnchorStyles.None;
            rsaKeyLengthComboBox.FormattingEnabled = true;
            rsaKeyLengthComboBox.Items.AddRange(new object[] { "512", "1024", "2048", "4096" });
            rsaKeyLengthComboBox.Location = new Point(6, 93);
            rsaKeyLengthComboBox.Name = "rsaKeyLengthComboBox";
            rsaKeyLengthComboBox.Size = new Size(109, 32);
            rsaKeyLengthComboBox.TabIndex = 8;
            // 
            // rsaKeyFormatComboBox
            // 
            rsaKeyFormatComboBox.Anchor = AnchorStyles.Top;
            rsaKeyFormatComboBox.FormattingEnabled = true;
            rsaKeyFormatComboBox.Items.AddRange(new object[] { "PKCS#8", "PKCS#1" });
            rsaKeyFormatComboBox.Location = new Point(6, 149);
            rsaKeyFormatComboBox.Name = "rsaKeyFormatComboBox";
            rsaKeyFormatComboBox.Size = new Size(109, 32);
            rsaKeyFormatComboBox.TabIndex = 9;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(53, 154);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(64, 24);
            inputLabel.TabIndex = 10;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(755, 154);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(64, 24);
            outputLabel.TabIndex = 11;
            outputLabel.Text = "输出框";
            // 
            // publicKeyLabel
            // 
            publicKeyLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            publicKeyLabel.AutoSize = true;
            publicKeyLabel.Location = new Point(53, 443);
            publicKeyLabel.Name = "publicKeyLabel";
            publicKeyLabel.Size = new Size(46, 24);
            publicKeyLabel.TabIndex = 12;
            publicKeyLabel.Text = "公钥";
            // 
            // privateKeyLabel
            // 
            privateKeyLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            privateKeyLabel.AutoSize = true;
            privateKeyLabel.Location = new Point(755, 443);
            privateKeyLabel.Name = "privateKeyLabel";
            privateKeyLabel.Size = new Size(46, 24);
            privateKeyLabel.TabIndex = 13;
            privateKeyLabel.Text = "私钥";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
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
            tableLayoutPanel1.Controls.Add(rsaLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(50);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(1378, 744);
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
            tableLayoutPanel2.Location = new Point(628, 181);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(121, 219);
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
            tableLayoutPanel3.Location = new Point(628, 470);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(121, 221);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // rsaLabel
            // 
            rsaLabel.Anchor = AnchorStyles.Left;
            rsaLabel.AutoSize = true;
            rsaLabel.Font = new Font("Microsoft YaHei UI", 15F);
            rsaLabel.Location = new Point(53, 78);
            rsaLabel.Name = "rsaLabel";
            rsaLabel.Size = new Size(75, 39);
            rsaLabel.TabIndex = 15;
            rsaLabel.Text = "RSA";
            // 
            // RSAForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 744);
            Controls.Add(tableLayoutPanel1);
            Name = "RSAForm";
            Text = "RSAForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label rsaLabel;
    }
}