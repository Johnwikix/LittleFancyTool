using System.Security.Cryptography;

namespace CryptoTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            titlebar = new AntdUI.PageHeader();
            input_search = new AntdUI.Input();
            dropdown_translate = new AntdUI.Dropdown();
            button_color = new AntdUI.Button();
            buttonSZ = new AntdUI.Button();
            pageHeader1 = new AntdUI.PageHeader();
            button_collapse = new AntdUI.Button();
            tabs = new AntdUI.Tabs();
            panel_content = new AntdUI.Panel();
            menu = new AntdUI.Menu();
            titlebar.SuspendLayout();
            pageHeader1.SuspendLayout();
            SuspendLayout();
            // 
            // titlebar
            // 
            titlebar.Controls.Add(input_search);
            titlebar.Controls.Add(dropdown_translate);
            titlebar.Controls.Add(button_color);
            titlebar.Controls.Add(buttonSZ);
            titlebar.DividerShow = true;
            titlebar.Dock = DockStyle.Top;
            titlebar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            titlebar.Location = new Point(0, 0);
            titlebar.Name = "titlebar";
            titlebar.ShowButton = true;
            titlebar.Size = new Size(1400, 40);
            titlebar.SubText = "";
            titlebar.TabIndex = 0;
            titlebar.Text = "工具";
            // 
            // input_search
            // 
            input_search.AllowClear = true;
            input_search.Dock = DockStyle.Right;
            input_search.Font = new Font("Microsoft YaHei UI", 10F);
            input_search.LocalizationPlaceholderText = "search";
            input_search.Location = new Point(884, 0);
            input_search.Name = "input_search";
            input_search.PlaceholderText = "搜索";
            input_search.PrefixSvg = "SearchOutlined";
            input_search.Size = new Size(200, 40);
            input_search.TabIndex = 4;
            // 
            // dropdown_translate
            // 
            dropdown_translate.Location = new Point(0, 0);
            dropdown_translate.Name = "dropdown_translate";
            dropdown_translate.Size = new Size(0, 0);
            dropdown_translate.TabIndex = 5;
            // 
            // button_color
            // 
            button_color.Dock = DockStyle.Right;
            button_color.Ghost = true;
            button_color.IconRatio = 0.6F;
            button_color.IconSvg = "SunOutlined";
            button_color.Location = new Point(1084, 0);
            button_color.Name = "button_color";
            button_color.Radius = 0;
            button_color.Size = new Size(50, 40);
            button_color.TabIndex = 1;
            button_color.ToggleIconSvg = "MoonOutlined";
            button_color.WaveSize = 0;
            // 
            // buttonSZ
            // 
            buttonSZ.Dock = DockStyle.Right;
            buttonSZ.Ghost = true;
            buttonSZ.IconSvg = resources.GetString("buttonSZ.IconSvg");
            buttonSZ.Location = new Point(1134, 0);
            buttonSZ.Name = "buttonSZ";
            buttonSZ.Radius = 0;
            buttonSZ.Size = new Size(50, 40);
            buttonSZ.TabIndex = 0;
            buttonSZ.WaveSize = 0;
            // 
            // pageHeader1
            // 
            pageHeader1.Controls.Add(button_collapse);
            pageHeader1.DividerShow = true;
            pageHeader1.Dock = DockStyle.Bottom;
            pageHeader1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader1.Location = new Point(0, 760);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.Size = new Size(1400, 40);
            pageHeader1.TabIndex = 7;
            // 
            // button_collapse
            // 
            button_collapse.Dock = DockStyle.Left;
            button_collapse.Ghost = true;
            button_collapse.IconRatio = 0.6F;
            button_collapse.IconSvg = "MenuUnfoldOutlined";
            button_collapse.Location = new Point(0, 0);
            button_collapse.Name = "button_collapse";
            button_collapse.Radius = 0;
            button_collapse.Size = new Size(50, 40);
            button_collapse.TabIndex = 3;
            button_collapse.ToggleIconSvg = "MenuFoldOutlined";
            button_collapse.WaveSize = 0;
            // 
            // tabs
            // 
            tabs.Dock = DockStyle.Fill;
            tabs.Gap = 20;
            tabs.Location = new Point(70, 40);
            tabs.Name = "tabs";
            tabs.Size = new Size(1330, 720);
            styleCard1.Closable = true;
            tabs.Style = styleCard1;
            tabs.TabIndex = 9;
            tabs.Type = AntdUI.TabType.Card;
            // 
            // panel_content
            // 
            panel_content.Back = Color.Transparent;
            panel_content.Dock = DockStyle.Fill;
            panel_content.Location = new Point(0, 0);
            panel_content.Name = "panel_content";
            panel_content.Radius = 0;
            panel_content.Size = new Size(948, 517);
            panel_content.TabIndex = 4;
            // 
            // menu
            // 
            menu.Dock = DockStyle.Left;
            menu.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            menu.IconRatio = 1F;
            menu.Indent = true;
            menu.Location = new Point(0, 40);
            menu.Margin = new Padding(3, 3, 0, 3);
            menu.Name = "menu";
            menu.Size = new Size(70, 720);
            menu.TabIndex = 8;
            menu.Unique = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(1400, 800);
            ControlBox = false;
            Controls.Add(tabs);
            Controls.Add(menu);
            Controls.Add(pageHeader1);
            Controls.Add(titlebar);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AntdUI Demo";
            titlebar.ResumeLayout(false);
            pageHeader1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader titlebar;
        private AntdUI.Button buttonSZ;
        private AntdUI.Button button_color;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Button button_collapse;
        private AntdUI.Tabs tabs;
        //private AntdUI.TabPage tabPage;
        private AntdUI.Panel panel_content;
        private AntdUI.Menu menu;
        private AntdUI.Dropdown dropdown_translate;
        private AntdUI.Input input_search;
        //    mainMenuStrip = new MenuStrip();
        //    encryptToolStripMenuItem = new ToolStripMenuItem();
        //    rsaToolStripMenuItem = new ToolStripMenuItem();
        //    aesToolStripMenuItem = new ToolStripMenuItem();
        //    base64ToolStripMenuItem = new ToolStripMenuItem();
        //    mainMenuStrip.SuspendLayout();
        //    SuspendLayout();
        //    // 
        //    // mainMenuStrip
        //    // 
        //    mainMenuStrip.ImageScalingSize = new Size(24, 24);
        //    mainMenuStrip.Items.AddRange(new ToolStripItem[] { encryptToolStripMenuItem});
        //    mainMenuStrip.Location = new Point(0, 0);
        //    mainMenuStrip.Name = "mainMenuStrip";
        //    mainMenuStrip.Size = new Size(1378, 32);
        //    mainMenuStrip.TabIndex = 0;
        //    mainMenuStrip.Text = "menuStrip1";
        //    // 
        //    // 加密ToolStripMenuItem
        //    // 
        //    encryptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rsaToolStripMenuItem, aesToolStripMenuItem, base64ToolStripMenuItem });
        //    encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
        //    encryptToolStripMenuItem.Size = new Size(62, 28);
        //    encryptToolStripMenuItem.Text = "加密";
        //    // 
        //    // rSAToolStripMenuItem1
        //    // 
        //    rsaToolStripMenuItem.Name = "rsaToolStripMenuItem";
        //    rsaToolStripMenuItem.Size = new Size(270, 34);
        //    rsaToolStripMenuItem.Text = "RSA";
        //    rsaToolStripMenuItem.Click += rsaToolStripMenuItem_Click;
        //    // 
        //    // aESToolStripMenuItem1
        //    // 
        //    aesToolStripMenuItem.Name = "aesToolStripMenuItem";
        //    aesToolStripMenuItem.Size = new Size(270, 34);
        //    aesToolStripMenuItem.Text = "AES";
        //    aesToolStripMenuItem.Click += aesToolStripMenuItem_Click;
        //    // 
        //    // base64ToolStripMenuItem1
        //    // 
        //    base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
        //    base64ToolStripMenuItem.Size = new Size(270, 34);
        //    base64ToolStripMenuItem.Text = "Base64";
        //    base64ToolStripMenuItem.Click += base64ToolStripMenuItem_Click;
        //    // 
        //    // MainForm
        //    // 
        //    ClientSize = new Size(1378, 808);
        //    Controls.Add(mainMenuStrip);
        //    MainMenuStrip = mainMenuStrip;
        //    Name = "MainForm";
        //    Text = "加密工具";
        //    mainMenuStrip.ResumeLayout(false);
        //    mainMenuStrip.PerformLayout();
        //    ResumeLayout(false);
        //    PerformLayout();
        //}

        //#endregion
        //// 在类中添加控件成员变量
        //private System.Windows.Forms.MenuStrip mainMenuStrip;
        ////private System.Windows.Forms.ToolStripMenuItem rsaToolStripMenuItem;
        ////private System.Windows.Forms.ToolStripMenuItem aesToolStripMenuItem;
        ////private System.Windows.Forms.ToolStripMenuItem base64ToolStripMenuItem;
        //private ToolStripMenuItem encryptToolStripMenuItem;
        //private ToolStripMenuItem rsaToolStripMenuItem;
        //private ToolStripMenuItem aesToolStripMenuItem;
        //private ToolStripMenuItem base64ToolStripMenuItem;
    }
}
