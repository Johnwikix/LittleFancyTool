namespace LittleFancyTool.View.SubView
{
    partial class SlaveTableEdit
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
            panel1 = new AntdUI.Panel();
            input_addr = new AntdUI.Input();
            addrLabel = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
            stackPanel1 = new AntdUI.StackPanel();
            button_cancel = new AntdUI.Button();
            button_ok = new AntdUI.Button();
            label2 = new AntdUI.Label();
            input_value = new AntdUI.Input();
            panel1.SuspendLayout();
            stackPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(input_value);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(input_addr);
            panel1.Controls.Add(addrLabel);
            panel1.Controls.Add(divider1);
            panel1.Controls.Add(stackPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Shadow = 6;
            panel1.Size = new Size(500, 386);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // input_addr
            // 
            input_addr.Dock = DockStyle.Top;
            input_addr.Font = new Font("Microsoft YaHei UI", 9F);
            input_addr.Location = new Point(18, 98);
            input_addr.Name = "input_addr";
            input_addr.Radius = 3;
            input_addr.Size = new Size(464, 38);
            input_addr.TabIndex = 18;
            // 
            // addrLabel
            // 
            addrLabel.Dock = DockStyle.Top;
            addrLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            addrLabel.Location = new Point(18, 74);
            addrLabel.Name = "addrLabel";
            addrLabel.Size = new Size(464, 24);
            addrLabel.TabIndex = 17;
            addrLabel.Text = "寄存器地址";
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(18, 62);
            divider1.Name = "divider1";
            divider1.Size = new Size(464, 12);
            divider1.TabIndex = 14;
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(button_cancel);
            stackPanel1.Controls.Add(button_ok);
            stackPanel1.Dock = DockStyle.Top;
            stackPanel1.Location = new Point(18, 18);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.RightToLeft = RightToLeft.No;
            stackPanel1.Size = new Size(464, 44);
            stackPanel1.TabIndex = 3;
            stackPanel1.Text = "stackPanel1";
            // 
            // button_cancel
            // 
            button_cancel.BorderWidth = 1F;
            button_cancel.Font = new Font("Microsoft YaHei UI", 9F);
            button_cancel.Ghost = true;
            button_cancel.LocalizationText = "cancel";
            button_cancel.Location = new Point(84, 3);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 38);
            button_cancel.TabIndex = 1;
            button_cancel.Text = "取消";
            // 
            // button_ok
            // 
            button_ok.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button_ok.LocalizationText = "submit";
            button_ok.Location = new Point(3, 3);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(75, 38);
            button_ok.TabIndex = 0;
            button_ok.Text = "提交";
            button_ok.Type = AntdUI.TTypeMini.Primary;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(18, 136);
            label2.Name = "label2";
            label2.Size = new Size(464, 24);
            label2.TabIndex = 19;
            label2.Text = "值";
            // 
            // input_value
            // 
            input_value.Dock = DockStyle.Top;
            input_value.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            input_value.Location = new Point(18, 160);
            input_value.Name = "input_value";
            input_value.Radius = 3;
            input_value.Size = new Size(464, 38);
            input_value.TabIndex = 20;
            // 
            // SlaveTableEdit
            // 
            Controls.Add(panel1);
            Name = "SlaveTableEdit";
            Size = new Size(500, 386);
            panel1.ResumeLayout(false);
            stackPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Button button_cancel;
        private AntdUI.Button button_ok;
        private AntdUI.Divider divider1;
        private AntdUI.Input input_addr;
        private AntdUI.Label addrLabel;
        private AntdUI.Input input_value;
        private AntdUI.Label label2;
        private AntdUI.Input input_name;
        private AntdUI.Label label3;
    }
}