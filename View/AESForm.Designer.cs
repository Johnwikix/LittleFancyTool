namespace CryptoTool.View
{
    partial class AESForm
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
            encryptBtn = new Button();
            decryptBtn = new Button();
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            inputLabel = new Label();
            outputLabel = new Label();
            paddingModeComboBox = new ComboBox();
            keyTextBox = new TextBox();
            ivTextBox = new TextBox();
            key = new Label();
            iv = new Label();
            title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            genKeyIv = new Button();
            keyLengthComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.Bottom;
            encryptBtn.Location = new Point(11, 106);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(112, 34);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "加密>>";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += encryptButton_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Anchor = AnchorStyles.None;
            decryptBtn.Location = new Point(11, 172);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(112, 34);
            decryptBtn.TabIndex = 1;
            decryptBtn.Text = "解密<<";
            decryptBtn.UseVisualStyleBackColor = true;
            decryptBtn.Click += decryptButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Dock = DockStyle.Fill;
            inputTextBox.Location = new Point(53, 181);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(561, 380);
            inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Location = new Point(761, 181);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(564, 380);
            outputTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(53, 154);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(64, 24);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(761, 154);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(64, 24);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "输出框";
            // 
            // paddingModeComboBox
            // 
            paddingModeComboBox.Anchor = AnchorStyles.Top;
            paddingModeComboBox.FormattingEnabled = true;
            paddingModeComboBox.Items.AddRange(new object[] { "PKCS7", "Zeros" });
            paddingModeComboBox.Location = new Point(11, 239);
            paddingModeComboBox.Name = "paddingModeComboBox";
            paddingModeComboBox.Size = new Size(112, 32);
            paddingModeComboBox.TabIndex = 0;
            // 
            // keyTextBox
            // 
            keyTextBox.Dock = DockStyle.Fill;
            keyTextBox.Location = new Point(53, 631);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(561, 30);
            keyTextBox.TabIndex = 6;
            // 
            // ivTextBox
            // 
            ivTextBox.Dock = DockStyle.Fill;
            ivTextBox.Location = new Point(761, 631);
            ivTextBox.Name = "ivTextBox";
            ivTextBox.Size = new Size(564, 30);
            ivTextBox.TabIndex = 7;
            // 
            // key
            // 
            key.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            key.AutoSize = true;
            key.Location = new Point(53, 604);
            key.Name = "key";
            key.Size = new Size(46, 24);
            key.TabIndex = 8;
            key.Text = "密钥";
            // 
            // iv
            // 
            iv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iv.AutoSize = true;
            iv.Location = new Point(761, 604);
            iv.Name = "iv";
            iv.Size = new Size(46, 24);
            iv.TabIndex = 9;
            iv.Text = "偏移";
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Left;
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Microsoft YaHei UI", 15F);
            title.Location = new Point(53, 78);
            title.Name = "title";
            title.Size = new Size(72, 39);
            title.TabIndex = 10;
            title.Text = "AES";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.Controls.Add(inputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(iv, 2, 3);
            tableLayoutPanel1.Controls.Add(ivTextBox, 2, 4);
            tableLayoutPanel1.Controls.Add(key, 0, 3);
            tableLayoutPanel1.Controls.Add(keyTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(outputTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(inputLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(outputLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(title, 0, 0);
            tableLayoutPanel1.Controls.Add(genKeyIv, 1, 3);
            tableLayoutPanel1.Controls.Add(keyLengthComboBox, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(50);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
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
            tableLayoutPanel2.Location = new Point(620, 181);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 50, 0, 50);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(135, 380);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // genKeyIv
            // 
            genKeyIv.Anchor = AnchorStyles.Bottom;
            genKeyIv.Location = new Point(631, 591);
            genKeyIv.Name = "genKeyIv";
            genKeyIv.Size = new Size(112, 34);
            genKeyIv.TabIndex = 12;
            genKeyIv.Text = "生成密钥iv";
            genKeyIv.UseVisualStyleBackColor = true;
            genKeyIv.Click += genKeyIv_Click;
            // 
            // keyLengthComboBox
            // 
            keyLengthComboBox.Anchor = AnchorStyles.Top;
            keyLengthComboBox.FormattingEnabled = true;
            keyLengthComboBox.Items.AddRange(new object[] { "128", "192", "256" });
            keyLengthComboBox.Location = new Point(634, 631);
            keyLengthComboBox.Name = "keyLengthComboBox";
            keyLengthComboBox.Size = new Size(107, 32);
            keyLengthComboBox.TabIndex = 13;
            // 
            // AESForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 744);
            Controls.Add(tableLayoutPanel1);
            Name = "AESForm";
            Text = "AESForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encryptBtn;
        private Button decryptBtn;
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Label inputLabel;
        private Label outputLabel;
        private ComboBox paddingModeComboBox;
        private TextBox keyTextBox;
        private TextBox ivTextBox;
        private Label key;
        private Label iv;
        private Label title;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button genKeyIv;
        private ComboBox keyLengthComboBox;
    }
}