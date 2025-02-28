namespace LittleFancyTool.View.SubView
{
    partial class Wellcome
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
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft YaHei UI", 20F);
            label1.LocalizationText = "welcome";
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(750, 150);
            label1.TabIndex = 0;
            label1.Text = "妙妙小工具";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Wellcome
            // 
            Controls.Add(label1);
            Name = "Wellcome";
            Size = new Size(750, 150);
            ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label label1;
    }
}