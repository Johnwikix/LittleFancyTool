using AntdUI;

namespace LittleFancyTool.View
{
    partial class ImgConvertForm
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
            inputLabel = new AntdUI.Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            picUploadDragger = new UploadDragger();
            formatSelect = new Select();
            saveIcoBtn = new AntdUI.Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // inputLabel
            // 
            inputLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputLabel.AutoSizeMode = TAutoSize.Auto;
            inputLabel.Font = new Font("Microsoft YaHei UI", 15F);
            inputLabel.LocalizationText = "img";
            inputLabel.Location = new Point(135, 34);
            inputLabel.Margin = new Padding(2);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(48, 28);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "图片";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.Controls.Add(pictureBox, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(inputLabel, 1, 1);
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
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(136, 67);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1258, 726);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(picUploadDragger, 0, 0);
            tableLayoutPanel2.Controls.Add(formatSelect, 0, 1);
            tableLayoutPanel2.Controls.Add(saveIcoBtn, 0, 2);
            tableLayoutPanel2.Location = new Point(3, 64);
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
            picUploadDragger.Dock = DockStyle.Fill;
            picUploadDragger.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.webp;*.tiff;*.heif";
            picUploadDragger.Font = new Font("Microsoft YaHei UI", 12F);
            picUploadDragger.LocalizationText = "openImg";
            picUploadDragger.Location = new Point(3, 3);
            picUploadDragger.Multiselect = false;
            picUploadDragger.Name = "picUploadDragger";
            picUploadDragger.Size = new Size(124, 124);
            picUploadDragger.TabIndex = 2;
            picUploadDragger.Text = "打开图片";
            picUploadDragger.DragChanged += picUploadDragger_Click;
            // 
            // formatSelect
            // 
            formatSelect.Anchor = AnchorStyles.None;
            formatSelect.Items.AddRange(new object[] { "jpg", "jpeg", "png", "gif", "bmp", "webp", "tiff", "heic" });
            formatSelect.Location = new Point(5, 135);
            formatSelect.Name = "formatSelect";
            formatSelect.SelectedIndex = 0;
            formatSelect.SelectedValue = "jpg";
            formatSelect.Size = new Size(120, 50);
            formatSelect.TabIndex = 3;
            formatSelect.Text = "jpg";
            // 
            // saveIcoBtn
            // 
            saveIcoBtn.Anchor = AnchorStyles.None;
            saveIcoBtn.Font = new Font("Microsoft YaHei UI", 14F);
            saveIcoBtn.IconSvg = "DownloadOutlined";
            saveIcoBtn.LocalizationText = "save";
            saveIcoBtn.Location = new Point(5, 195);
            saveIcoBtn.Name = "saveIcoBtn";
            saveIcoBtn.Size = new Size(120, 50);
            saveIcoBtn.TabIndex = 5;
            saveIcoBtn.Text = "保存";
            saveIcoBtn.Type = TTypeMini.Primary;
            saveIcoBtn.Click += saveIcoBtn_Click;
            // 
            // ImgConvertForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "ImgConvertForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Label inputLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.UploadDragger picUploadDragger;
        private PictureBox pictureBox;
        private AntdUI.Button saveIcoBtn;
        private Select formatSelect;
    }
}