using AntdUI;

namespace LittleFancyTool.View
{
    partial class Img2ico
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
            inputLabel = new AntdUI.Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            picUploadDragger = new UploadDragger();
            sizeSelect = new Select();
            pictureBox = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            outputLabel = new AntdUI.Label();
            saveIcoBtn = new AntdUI.Button();
            icoBox = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoBox).BeginInit();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Anchor = AnchorStyles.Bottom;
            encryptBtn.Font = new Font("Microsoft YaHei UI", 12F);
            encryptBtn.LocalizationText = "convert";
            encryptBtn.Location = new Point(5, 138);
            encryptBtn.Margin = new Padding(2);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(120, 50);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "转换 >>";
            encryptBtn.Type = TTypeMini.Primary;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSizeMode = TAutoSize.Auto;
            inputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            inputLabel.LocalizationText = "img";
            inputLabel.Location = new Point(5, 34);
            inputLabel.Margin = new Padding(2);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(48, 28);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "图片";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 1);
            tableLayoutPanel1.Controls.Add(inputLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(icoBox, 2, 2);
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
            tableLayoutPanel2.Controls.Add(encryptBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(picUploadDragger, 0, 0);
            tableLayoutPanel2.Controls.Add(sizeSelect, 0, 2);
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
            picUploadDragger.Filter = "图片文件|*.jpg;*.jpeg;*.png;";
            picUploadDragger.Font = new Font("Microsoft YaHei UI", 12F);
            picUploadDragger.LocalizationText = "openImg";
            picUploadDragger.Location = new Point(5, 5);
            picUploadDragger.Multiselect = false;
            picUploadDragger.Name = "picUploadDragger";
            picUploadDragger.Size = new Size(120, 120);
            picUploadDragger.TabIndex = 2;
            picUploadDragger.Text = "打开图片";
            picUploadDragger.DragChanged += picUploadDragger_Click;
            // 
            // sizeSelect
            // 
            sizeSelect.Items.AddRange(new object[] { "16x16", "24x24", "32x32", "48x48", "64x64", "96x96", "128x128", "192x192", "256x256" });
            sizeSelect.Location = new Point(3, 193);
            sizeSelect.Name = "sizeSelect";
            sizeSelect.SelectedIndex = 2;
            sizeSelect.SelectedValue = "32x32";
            sizeSelect.Size = new Size(120, 50);
            sizeSelect.TabIndex = 3;
            sizeSelect.Text = "32x32";
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
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(outputLabel, 1, 0);
            tableLayoutPanel4.Controls.Add(saveIcoBtn, 0, 0);
            tableLayoutPanel4.Location = new Point(768, 7);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(616, 54);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // outputLabel
            // 
            outputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            outputLabel.AutoSizeMode = TAutoSize.Auto;
            outputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            outputLabel.LocalizationText = "ico";
            outputLabel.Location = new Point(46, 24);
            outputLabel.Margin = new Padding(2);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(77, 28);
            outputLabel.TabIndex = 4;
            outputLabel.Text = "输出ico";
            // 
            // saveIcoBtn
            // 
            saveIcoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveIcoBtn.Font = new Font("Microsoft YaHei UI", 14F);
            saveIcoBtn.Ghost = true;
            saveIcoBtn.IconSvg = "DownloadOutlined";
            saveIcoBtn.Location = new Point(3, 18);
            saveIcoBtn.Name = "saveIcoBtn";
            saveIcoBtn.Size = new Size(38, 33);
            saveIcoBtn.TabIndex = 5;
            saveIcoBtn.Type = TTypeMini.Primary;
            saveIcoBtn.Click += saveIcoBtn_Click;
            // 
            // icoBox
            // 
            icoBox.Dock = DockStyle.Fill;
            icoBox.Location = new Point(768, 67);
            icoBox.Name = "icoBox";
            icoBox.Size = new Size(626, 726);
            icoBox.SizeMode = PictureBoxSizeMode.Zoom;
            icoBox.TabIndex = 9;
            icoBox.TabStop = false;
            // 
            // Img2ico
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "Img2ico";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button encryptBtn;
        private AntdUI.Label inputLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.UploadDragger picUploadDragger;
        private PictureBox pictureBox;
        private TableLayoutPanel tableLayoutPanel4;
        private AntdUI.Label outputLabel;
        private AntdUI.Button saveIcoBtn;
        private Select sizeSelect;
        private PictureBox icoBox;
    }
}