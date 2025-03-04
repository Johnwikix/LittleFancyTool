namespace LittleFancyTool.View
{
    partial class FileEncryptForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            chooseFileBtn = new AntdUI.Button();
            outputPathBtn = new AntdUI.Button();
            filePathInput = new AntdUI.Input();
            outputPathInput = new AntdUI.Input();
            keyInput = new AntdUI.Input();
            ivInput = new AntdUI.Input();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            decryptBtn = new AntdUI.Button();
            encryptBtn = new AntdUI.Button();
            encryptAlgSelect = new AntdUI.Select();
            tableLayoutPanel3 = new TableLayoutPanel();
            genKeyIvBtn = new AntdUI.Button();
            keyLengthSelect = new AntdUI.Select();
            keyModeSelect = new AntdUI.Select();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(chooseFileBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(outputPathBtn, 2, 4);
            tableLayoutPanel1.Controls.Add(filePathInput, 0, 3);
            tableLayoutPanel1.Controls.Add(outputPathInput, 2, 3);
            tableLayoutPanel1.Controls.Add(keyInput, 0, 1);
            tableLayoutPanel1.Controls.Add(ivInput, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Anchor = AnchorStyles.Left;
            chooseFileBtn.Font = new Font("Microsoft YaHei UI", 16F);
            chooseFileBtn.Location = new Point(33, 700);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(140, 60);
            chooseFileBtn.TabIndex = 0;
            chooseFileBtn.Text = "选择文件";
            chooseFileBtn.Type = AntdUI.TTypeMini.Primary;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // outputPathBtn
            // 
            outputPathBtn.Anchor = AnchorStyles.Left;
            outputPathBtn.Font = new Font("Microsoft YaHei UI", 16F);
            outputPathBtn.Location = new Point(803, 700);
            outputPathBtn.Name = "outputPathBtn";
            outputPathBtn.Size = new Size(140, 60);
            outputPathBtn.TabIndex = 1;
            outputPathBtn.Text = "输出路径";
            outputPathBtn.Type = AntdUI.TTypeMini.Primary;
            outputPathBtn.Click += outputPathBtn_Click;
            // 
            // filePathInput
            // 
            filePathInput.Dock = DockStyle.Fill;
            filePathInput.Font = new Font("Microsoft YaHei UI", 16F);
            filePathInput.Location = new Point(33, 413);
            filePathInput.Multiline = true;
            filePathInput.Name = "filePathInput";
            filePathInput.Size = new Size(564, 274);
            filePathInput.TabIndex = 2;
            // 
            // outputPathInput
            // 
            outputPathInput.Dock = DockStyle.Fill;
            outputPathInput.Font = new Font("Microsoft YaHei UI", 16F);
            outputPathInput.Location = new Point(803, 413);
            outputPathInput.Multiline = true;
            outputPathInput.Name = "outputPathInput";
            outputPathInput.Size = new Size(564, 274);
            outputPathInput.TabIndex = 3;
            // 
            // keyInput
            // 
            keyInput.Dock = DockStyle.Fill;
            keyInput.Font = new Font("Microsoft YaHei UI", 16F);
            keyInput.Location = new Point(33, 83);
            keyInput.Multiline = true;
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(564, 274);
            keyInput.TabIndex = 5;
            // 
            // ivInput
            // 
            ivInput.Dock = DockStyle.Fill;
            ivInput.Font = new Font("Microsoft YaHei UI", 16F);
            ivInput.Location = new Point(803, 83);
            ivInput.Multiline = true;
            ivInput.Name = "ivInput";
            ivInput.Size = new Size(564, 274);
            ivInput.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft YaHei UI", 18F);
            label1.Location = new Point(33, 54);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 8;
            label1.Text = "密钥";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft YaHei UI", 18F);
            label2.Location = new Point(803, 54);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 9;
            label2.Text = "偏移";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Microsoft YaHei UI", 18F);
            label3.Location = new Point(33, 371);
            label3.Name = "label3";
            label3.Size = new Size(124, 36);
            label3.TabIndex = 10;
            label3.Text = "目标文件";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Microsoft YaHei UI", 18F);
            label4.Location = new Point(803, 371);
            label4.Name = "label4";
            label4.Size = new Size(125, 36);
            label4.TabIndex = 11;
            label4.Text = "输出路径";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(decryptBtn, 0, 2);
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(encryptAlgSelect, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(603, 413);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(194, 274);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // decryptBtn
            // 
            decryptBtn.Anchor = AnchorStyles.None;
            decryptBtn.Font = new Font("Microsoft YaHei UI", 16F);
            decryptBtn.Location = new Point(27, 170);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(140, 60);
            decryptBtn.TabIndex = 12;
            decryptBtn.Text = "解密";
            decryptBtn.Type = AntdUI.TTypeMini.Primary;
            decryptBtn.Click += decryptBtn_Click;
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.None;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 16F);
            encryptBtn.Location = new Point(27, 90);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(140, 60);
            encryptBtn.TabIndex = 4;
            encryptBtn.Text = "加密";
            encryptBtn.Type = AntdUI.TTypeMini.Primary;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // encryptAlgSelect
            // 
            encryptAlgSelect.Anchor = AnchorStyles.None;
            encryptAlgSelect.Font = new Font("Microsoft YaHei UI", 16F);
            encryptAlgSelect.Items.AddRange(new object[] { "AES", "RSA" });
            encryptAlgSelect.Location = new Point(27, 10);
            encryptAlgSelect.Name = "encryptAlgSelect";
            encryptAlgSelect.SelectedIndex = 0;
            encryptAlgSelect.SelectedValue = "AES";
            encryptAlgSelect.Size = new Size(140, 60);
            encryptAlgSelect.TabIndex = 13;
            encryptAlgSelect.Text = "AES";
            encryptAlgSelect.SelectedIndexChanged += encryptAlgSelect_SelectedIndexChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(genKeyIvBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(keyLengthSelect, 0, 1);
            tableLayoutPanel3.Controls.Add(keyModeSelect, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(603, 83);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(194, 274);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // genKeyIvBtn
            // 
            genKeyIvBtn.Anchor = AnchorStyles.None;
            genKeyIvBtn.Font = new Font("Microsoft YaHei UI", 16F);
            genKeyIvBtn.Location = new Point(27, 10);
            genKeyIvBtn.Name = "genKeyIvBtn";
            genKeyIvBtn.Size = new Size(140, 60);
            genKeyIvBtn.TabIndex = 7;
            genKeyIvBtn.Text = "生成密钥";
            genKeyIvBtn.Type = AntdUI.TTypeMini.Primary;
            genKeyIvBtn.Click += genKeyIvBtn_Click;
            // 
            // keyLengthSelect
            // 
            keyLengthSelect.Anchor = AnchorStyles.None;
            keyLengthSelect.Font = new Font("Microsoft YaHei UI", 16F);
            keyLengthSelect.Items.AddRange(new object[] { "128", "192", "256" });
            keyLengthSelect.Location = new Point(27, 90);
            keyLengthSelect.Name = "keyLengthSelect";
            keyLengthSelect.SelectedIndex = 0;
            keyLengthSelect.SelectedValue = "128";
            keyLengthSelect.Size = new Size(140, 60);
            keyLengthSelect.TabIndex = 8;
            keyLengthSelect.Text = "128";
            // 
            // keyModeSelect
            // 
            keyModeSelect.Anchor = AnchorStyles.None;
            keyModeSelect.Font = new Font("Microsoft YaHei UI", 16F);
            keyModeSelect.Items.AddRange(new object[] { "PKCS#8", "PKCS#1" });
            keyModeSelect.Location = new Point(27, 170);
            keyModeSelect.Name = "keyModeSelect";
            keyModeSelect.SelectedIndex = 0;
            keyModeSelect.SelectedValue = "PKCS#8";
            keyModeSelect.Size = new Size(140, 60);
            keyModeSelect.TabIndex = 9;
            keyModeSelect.Text = "PKCS#8";
            // 
            // FileEncryptForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "FileEncryptForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private AntdUI.Button chooseFileBtn;
        private AntdUI.Button outputPathBtn;
        private AntdUI.Input filePathInput;
        private AntdUI.Input outputPathInput;
        private AntdUI.Button encryptBtn;
        private AntdUI.Input keyInput;
        private AntdUI.Input ivInput;
        private AntdUI.Button genKeyIvBtn;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Button decryptBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.Select encryptAlgSelect;
        private TableLayoutPanel tableLayoutPanel3;
        private AntdUI.Select keyLengthSelect;
        private AntdUI.Select keyModeSelect;
    }
}