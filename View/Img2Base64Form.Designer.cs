using AntdUI;

namespace LittleFancyTool.View
{
    partial class Img2Base64Form
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
            outputTextBox = new Input();
            inputLabel = new AntdUI.Label();
            outputLabel = new AntdUI.Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            picUploadDragger = new UploadDragger();
            pictureBox = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            downloadPicBtn = new AntdUI.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.Bottom;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            encryptBtn.LocalizationText = "Encode";
            encryptBtn.Location = new Point(5, 138);
            encryptBtn.Margin = new Padding(2);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(120, 50);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "编码>>";
            encryptBtn.Type = TTypeMini.Primary;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Anchor = AnchorStyles.Top;
            decryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            decryptBtn.LocalizationText = "Decode";
            decryptBtn.Location = new Point(5, 192);
            decryptBtn.Margin = new Padding(2);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(120, 50);
            decryptBtn.TabIndex = 1;
            decryptBtn.Text = "解码<<";
            decryptBtn.Type = TTypeMini.Success;
            decryptBtn.Click += decryptBtn_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.AutoScroll = true;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            outputTextBox.Location = new Point(767, 66);
            outputTextBox.Margin = new Padding(2);
            outputTextBox.MaxLength = int.MaxValue;
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(628, 728);
            outputTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSizeMode = TAutoSize.Auto;
            inputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            inputLabel.LocalizationText = "img";
            inputLabel.Location = new Point(46, 24);
            inputLabel.Margin = new Padding(2);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(48, 28);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "图片";
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSizeMode = TAutoSize.Auto;
            outputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            outputLabel.LocalizationText = "Output";
            outputLabel.Location = new Point(767, 34);
            outputLabel.Margin = new Padding(2);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(69, 28);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "输出框";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(outputLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(outputTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(pictureBox, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(decryptBtn, 0, 2);
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(picUploadDragger, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(635, 64);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(130, 732);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // picUploadDragger
            // 
            picUploadDragger.Anchor = AnchorStyles.None;
            picUploadDragger.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.gif";
            picUploadDragger.Font = new Font("Microsoft YaHei UI", 12F);
            picUploadDragger.LocalizationText = "openImg";
            picUploadDragger.Location = new Point(5, 5);
            picUploadDragger.Multiselect = false;
            picUploadDragger.Name = "picUploadDragger";
            picUploadDragger.Size = new Size(120, 120);
            picUploadDragger.TabIndex = 2;
            picUploadDragger.Text = "打开图片";
            picUploadDragger.DragChanged += UploadDragger_DragChanged;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(6, 67);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(626, 726);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(inputLabel, 1, 0);
            tableLayoutPanel3.Controls.Add(downloadPicBtn, 0, 0);
            tableLayoutPanel3.Location = new Point(6, 7);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(616, 54);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // downloadPicBtn
            // 
            downloadPicBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            downloadPicBtn.Font = new Font("Microsoft YaHei UI", 14F);
            downloadPicBtn.Ghost = true;
            downloadPicBtn.IconSvg = "DownloadOutlined";
            downloadPicBtn.Location = new Point(3, 18);
            downloadPicBtn.Name = "downloadPicBtn";
            downloadPicBtn.Size = new Size(38, 33);
            downloadPicBtn.TabIndex = 5;
            downloadPicBtn.Type = TTypeMini.Primary;
            downloadPicBtn.Click += downloadPicBtn_Click;
            // 
            // Img2Base64Form
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "Img2Base64Form";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button encryptBtn;
        private AntdUI.Button decryptBtn;
        private AntdUI.Input outputTextBox;
        private AntdUI.Label inputLabel;
        private AntdUI.Label outputLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.UploadDragger picUploadDragger;
        private PictureBox pictureBox;
        private TableLayoutPanel tableLayoutPanel3;
        private AntdUI.Button downloadPicBtn;
    }
}