namespace LittleFancyTool.View
{
    partial class FolderCompareForm
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
            targetFolderBtn = new AntdUI.Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            sourceFolderBtn = new AntdUI.Button();
            sourceFolderInput = new AntdUI.Input();
            sourceFolderLabel = new AntdUI.Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            targetFolderInput = new AntdUI.Input();
            targetFolderLabel = new AntdUI.Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            outputInput = new AntdUI.Input();
            tableLayoutPanel5 = new TableLayoutPanel();
            compareBtn = new AntdUI.Button();
            hashCheckBox = new AntdUI.Checkbox();
            progressBar = new AntdUI.Progress();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // targetFolderBtn
            // 
            targetFolderBtn.Anchor = AnchorStyles.None;
            targetFolderBtn.Font = new Font("Microsoft YaHei UI", 12F);
            targetFolderBtn.IconSvg = "FolderAddOutlined";
            targetFolderBtn.LocalizationText = "targetFolderBtn";
            targetFolderBtn.Location = new Point(1173, 2);
            targetFolderBtn.Margin = new Padding(0);
            targetFolderBtn.Name = "targetFolderBtn";
            targetFolderBtn.Size = new Size(200, 55);
            targetFolderBtn.TabIndex = 0;
            targetFolderBtn.Text = "选择目标文件夹";
            targetFolderBtn.Type = AntdUI.TTypeMini.Primary;
            targetFolderBtn.Click += targetFolderBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1400, 800);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Controls.Add(sourceFolderBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(sourceFolderInput, 1, 0);
            tableLayoutPanel3.Controls.Add(sourceFolderLabel, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 72);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1388, 59);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // sourceFolderBtn
            // 
            sourceFolderBtn.Anchor = AnchorStyles.None;
            sourceFolderBtn.Font = new Font("Microsoft YaHei UI", 12F);
            sourceFolderBtn.IconSvg = "FolderAddOutlined";
            sourceFolderBtn.LocalizationText = "sourceFolderBtn";
            sourceFolderBtn.Location = new Point(1173, 2);
            sourceFolderBtn.Margin = new Padding(0);
            sourceFolderBtn.Name = "sourceFolderBtn";
            sourceFolderBtn.Size = new Size(200, 55);
            sourceFolderBtn.TabIndex = 0;
            sourceFolderBtn.Text = "选择原始文件夹";
            sourceFolderBtn.Type = AntdUI.TTypeMini.Primary;
            sourceFolderBtn.Click += sourceFolderBtn_Click;
            // 
            // sourceFolderInput
            // 
            sourceFolderInput.AutoScroll = true;
            sourceFolderInput.Dock = DockStyle.Fill;
            sourceFolderInput.Location = new Point(202, 2);
            sourceFolderInput.Margin = new Padding(2);
            sourceFolderInput.Name = "sourceFolderInput";
            sourceFolderInput.Size = new Size(964, 55);
            sourceFolderInput.TabIndex = 1;
            // 
            // sourceFolderLabel
            // 
            sourceFolderLabel.Anchor = AnchorStyles.Right;
            sourceFolderLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            sourceFolderLabel.Font = new Font("Microsoft YaHei UI", 14F);
            sourceFolderLabel.LocalizationText = "sourceFolderLabel";
            sourceFolderLabel.Location = new Point(94, 16);
            sourceFolderLabel.Name = "sourceFolderLabel";
            sourceFolderLabel.Size = new Size(103, 27);
            sourceFolderLabel.TabIndex = 2;
            sourceFolderLabel.Text = "原始文件夹";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.Controls.Add(targetFolderBtn, 2, 0);
            tableLayoutPanel2.Controls.Add(targetFolderInput, 1, 0);
            tableLayoutPanel2.Controls.Add(targetFolderLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 7);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1388, 59);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // targetFolderInput
            // 
            targetFolderInput.AutoScroll = true;
            targetFolderInput.Dock = DockStyle.Fill;
            targetFolderInput.Location = new Point(202, 2);
            targetFolderInput.Margin = new Padding(2);
            targetFolderInput.Name = "targetFolderInput";
            targetFolderInput.Size = new Size(964, 55);
            targetFolderInput.TabIndex = 1;
            // 
            // targetFolderLabel
            // 
            targetFolderLabel.Anchor = AnchorStyles.Right;
            targetFolderLabel.AutoSizeMode = AntdUI.TAutoSize.Auto;
            targetFolderLabel.Font = new Font("Microsoft YaHei UI", 14F);
            targetFolderLabel.LocalizationText = "targetFolderLabel";
            targetFolderLabel.Location = new Point(94, 16);
            targetFolderLabel.Name = "targetFolderLabel";
            targetFolderLabel.Size = new Size(103, 27);
            targetFolderLabel.TabIndex = 2;
            targetFolderLabel.Text = "目标文件夹";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel4.Controls.Add(outputInput, 1, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel4.Controls.Add(hashCheckBox, 0, 0);
            tableLayoutPanel4.Controls.Add(progressBar, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(6, 137);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.Size = new Size(1388, 656);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // outputInput
            // 
            outputInput.AutoScroll = true;
            outputInput.Dock = DockStyle.Fill;
            outputInput.Font = new Font("Microsoft YaHei UI", 10F);
            outputInput.Location = new Point(203, 3);
            outputInput.Multiline = true;
            outputInput.Name = "outputInput";
            outputInput.Size = new Size(962, 600);
            outputInput.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(compareBtn, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(1168, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(220, 606);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // compareBtn
            // 
            compareBtn.Anchor = AnchorStyles.None;
            compareBtn.Font = new Font("Microsoft YaHei UI", 15F);
            compareBtn.LocalizationText = "compareBtn";
            compareBtn.Location = new Point(5, 10);
            compareBtn.Margin = new Padding(0, 0, 10, 0);
            compareBtn.Name = "compareBtn";
            compareBtn.Size = new Size(200, 200);
            compareBtn.TabIndex = 1;
            compareBtn.Text = "对比";
            compareBtn.Type = AntdUI.TTypeMini.Primary;
            compareBtn.Click += compareBtn_ClickAsync;
            // 
            // hashCheckBox
            // 
            hashCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hashCheckBox.AutoSizeMode = AntdUI.TAutoSize.Auto;
            hashCheckBox.Font = new Font("Microsoft YaHei UI", 12F);
            hashCheckBox.LocalizationText = "hashCheck";
            hashCheckBox.Location = new Point(82, 3);
            hashCheckBox.Name = "hashCheckBox";
            hashCheckBox.Size = new Size(115, 43);
            hashCheckBox.TabIndex = 4;
            hashCheckBox.Text = "哈希校验";
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Fill;
            progressBar.Location = new Point(210, 616);
            progressBar.Margin = new Padding(10);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(948, 30);
            progressBar.TabIndex = 5;
            progressBar.Text = "progress1";
            // 
            // FolderCompareForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "FolderCompareForm";
            Size = new Size(1400, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button targetFolderBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.Input targetFolderInput;
        private AntdUI.Label targetFolderLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private AntdUI.Button sourceFolderBtn;
        private AntdUI.Input sourceFolderInput;
        private AntdUI.Label sourceFolderLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private AntdUI.Button compareBtn;
        private TableLayoutPanel tableLayoutPanel5;
        private AntdUI.Input outputInput;
        private AntdUI.Checkbox hashCheckBox;
        private AntdUI.Progress progressBar;
    }
}