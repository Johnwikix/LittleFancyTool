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
            tableLayoutPanel2 = new TableLayoutPanel();
            encryptBtn = new AntdUI.Button();
            decryptBtn = new AntdUI.Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            genKeyIvBtn = new AntdUI.Button();
            keyLengthSelect = new AntdUI.Select();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new AntdUI.Label();
            openPathBtn = new AntdUI.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Anchor = AnchorStyles.Left;
            chooseFileBtn.Font = new Font("Microsoft YaHei UI", 12F);
            chooseFileBtn.IconSvg = "FileAddOutlined";
            chooseFileBtn.LocalizationText = "chooseFile";
            chooseFileBtn.Location = new Point(13, 720);
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
            outputPathBtn.Font = new Font("Microsoft YaHei UI", 12F);
            outputPathBtn.IconHoverSvg = "";
            outputPathBtn.IconSvg = "FolderOutlined";
            outputPathBtn.LocalizationText = "choosePath";
            outputPathBtn.Location = new Point(768, 720);
            outputPathBtn.Name = "outputPathBtn";
            outputPathBtn.Size = new Size(140, 60);
            outputPathBtn.TabIndex = 1;
            outputPathBtn.Text = "选择路径";
            outputPathBtn.Type = AntdUI.TTypeMini.Primary;
            outputPathBtn.Click += outputPathBtn_Click;
            // 
            // filePathInput
            // 
            filePathInput.Dock = DockStyle.Fill;
            filePathInput.Font = new Font("Microsoft YaHei UI", 12F);
            filePathInput.Location = new Point(13, 263);
            filePathInput.Multiline = true;
            filePathInput.Name = "filePathInput";
            filePathInput.Size = new Size(619, 444);
            filePathInput.TabIndex = 2;
            // 
            // outputPathInput
            // 
            outputPathInput.Dock = DockStyle.Fill;
            outputPathInput.Font = new Font("Microsoft YaHei UI", 12F);
            outputPathInput.Location = new Point(768, 263);
            outputPathInput.Multiline = true;
            outputPathInput.Name = "outputPathInput";
            outputPathInput.Size = new Size(619, 444);
            outputPathInput.TabIndex = 3;
            // 
            // keyInput
            // 
            keyInput.Dock = DockStyle.Fill;
            keyInput.Font = new Font("Microsoft YaHei UI", 12F);
            keyInput.Location = new Point(13, 73);
            keyInput.Multiline = true;
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(619, 114);
            keyInput.TabIndex = 5;
            // 
            // ivInput
            // 
            ivInput.Dock = DockStyle.Fill;
            ivInput.Font = new Font("Microsoft YaHei UI", 12F);
            ivInput.Location = new Point(768, 73);
            ivInput.Multiline = true;
            ivInput.Name = "ivInput";
            ivInput.Size = new Size(619, 114);
            ivInput.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft YaHei UI", 15F);
            label1.LocalizationText = "Key";
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(75, 36);
            label1.TabIndex = 8;
            label1.Text = "密钥";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft YaHei UI", 15F);
            label2.LocalizationText = "Iv";
            label2.Location = new Point(768, 31);
            label2.Name = "label2";
            label2.Size = new Size(75, 36);
            label2.TabIndex = 9;
            label2.Text = "偏移";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Microsoft YaHei UI", 15F);
            label3.LocalizationText = "targetFile";
            label3.Location = new Point(13, 221);
            label3.Name = "label3";
            label3.Size = new Size(266, 36);
            label3.TabIndex = 10;
            label3.Text = "目标文件";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(decryptBtn, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(635, 260);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(130, 450);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.None;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            encryptBtn.LocalizationText = "Encrypt";
            encryptBtn.Location = new Point(5, 5);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(120, 50);
            encryptBtn.TabIndex = 4;
            encryptBtn.Text = "加密 >>";
            encryptBtn.Type = AntdUI.TTypeMini.Primary;
            encryptBtn.Click += encryptBtn_Click;
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
            decryptBtn.TabIndex = 12;
            decryptBtn.Text = "解密 <<";
            decryptBtn.Type = AntdUI.TTypeMini.Success;
            decryptBtn.Click += decryptBtn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(genKeyIvBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(keyLengthSelect, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(635, 70);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(130, 120);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // genKeyIvBtn
            // 
            genKeyIvBtn.Anchor = AnchorStyles.None;
            genKeyIvBtn.Font = new Font("Microsoft YaHei UI", 12F);
            genKeyIvBtn.LocalizationText = "GenKeyIv";
            genKeyIvBtn.Location = new Point(5, 5);
            genKeyIvBtn.Name = "genKeyIvBtn";
            genKeyIvBtn.Size = new Size(120, 50);
            genKeyIvBtn.TabIndex = 7;
            genKeyIvBtn.Text = "生成密钥";
            genKeyIvBtn.Type = AntdUI.TTypeMini.Primary;
            genKeyIvBtn.Click += genKeyIvBtn_Click;
            // 
            // keyLengthSelect
            // 
            keyLengthSelect.Anchor = AnchorStyles.None;
            keyLengthSelect.Font = new Font("Microsoft YaHei UI", 12F);
            keyLengthSelect.Items.AddRange(new object[] { "128", "192", "256" });
            keyLengthSelect.Location = new Point(5, 65);
            keyLengthSelect.Name = "keyLengthSelect";
            keyLengthSelect.SelectedIndex = 2;
            keyLengthSelect.SelectedValue = "256";
            keyLengthSelect.Size = new Size(120, 50);
            keyLengthSelect.TabIndex = 8;
            keyLengthSelect.Text = "256";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label4, 1, 0);
            tableLayoutPanel4.Controls.Add(openPathBtn, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(768, 193);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(619, 64);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Microsoft YaHei UI", 15F);
            label4.LocalizationText = "outputPath";
            label4.Location = new Point(50, 25);
            label4.Name = "label4";
            label4.Size = new Size(183, 36);
            label4.TabIndex = 11;
            label4.Text = "输出路径";
            // 
            // openPathBtn
            // 
            openPathBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            openPathBtn.Font = new Font("Microsoft YaHei UI", 12F);
            openPathBtn.Ghost = true;
            openPathBtn.IconSvg = "FolderOpenOutlined";
            openPathBtn.Location = new Point(3, 25);
            openPathBtn.Name = "openPathBtn";
            openPathBtn.Size = new Size(41, 36);
            openPathBtn.TabIndex = 12;
            openPathBtn.Type = AntdUI.TTypeMini.Primary;
            openPathBtn.Click += openPathBtn_Click;
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
            tableLayoutPanel4.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel3;
        private AntdUI.Select keyLengthSelect;
        private TableLayoutPanel tableLayoutPanel4;
        private AntdUI.Button openPathBtn;
    }
}