namespace LittleFancyTool.View.SubView
{
    partial class PollTableEdit
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
            inputValue = new AntdUI.Input();
            valueLabel = new AntdUI.Label();
            inputAddr = new AntdUI.Input();
            addrLabel = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
            stackPanel1 = new AntdUI.StackPanel();
            button_cancel = new AntdUI.Button();
            button_ok = new AntdUI.Button();
            panel1.SuspendLayout();
            stackPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(inputValue);
            panel1.Controls.Add(valueLabel);
            panel1.Controls.Add(inputAddr);
            panel1.Controls.Add(addrLabel);
            panel1.Controls.Add(divider1);
            panel1.Controls.Add(stackPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Shadow = 6;
            panel1.Size = new Size(484, 347);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // inputValue
            // 
            inputValue.Dock = DockStyle.Top;
            inputValue.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            inputValue.Location = new Point(18, 160);
            inputValue.Name = "inputValue";
            inputValue.Radius = 3;
            inputValue.Size = new Size(448, 38);
            inputValue.TabIndex = 20;
            // 
            // valueLabel
            // 
            valueLabel.Dock = DockStyle.Top;
            valueLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            valueLabel.LocalizationText = "value";
            valueLabel.Location = new Point(18, 136);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(448, 24);
            valueLabel.TabIndex = 19;
            valueLabel.Text = "值";
            // 
            // inputAddr
            // 
            inputAddr.Dock = DockStyle.Top;
            inputAddr.Font = new Font("Microsoft YaHei UI", 9F);
            inputAddr.Location = new Point(18, 98);
            inputAddr.Name = "inputAddr";
            inputAddr.Radius = 3;
            inputAddr.ReadOnly = true;
            inputAddr.Size = new Size(448, 38);
            inputAddr.TabIndex = 18;
            // 
            // addrLabel
            // 
            addrLabel.Dock = DockStyle.Top;
            addrLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            addrLabel.LocalizationText = "regAddress";
            addrLabel.Location = new Point(18, 74);
            addrLabel.Name = "addrLabel";
            addrLabel.Size = new Size(448, 24);
            addrLabel.TabIndex = 17;
            addrLabel.Text = "地址";
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(18, 62);
            divider1.Name = "divider1";
            divider1.Size = new Size(448, 12);
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
            stackPanel1.Size = new Size(448, 44);
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
            button_cancel.Click += button_cancel_Click;
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
            button_ok.Click += button_ok_Click;
            // 
            // PollTableEdit
            // 
            ClientSize = new Size(484, 347);
            Controls.Add(panel1);
            Name = "PollTableEdit";
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
        private AntdUI.Input inputAddr;
        private AntdUI.Label addrLabel;
        private AntdUI.Input inputValue;
        private AntdUI.Label valueLabel;
        private AntdUI.Input input_name;
        private AntdUI.Label label3;
    }
}