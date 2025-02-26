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
            mainMenuStrip = new MenuStrip();
            encryptToolStripMenuItem = new ToolStripMenuItem();
            rsaToolStripMenuItem = new ToolStripMenuItem();
            aesToolStripMenuItem = new ToolStripMenuItem();
            base64ToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(24, 24);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { encryptToolStripMenuItem});
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1378, 32);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // 加密ToolStripMenuItem
            // 
            encryptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rsaToolStripMenuItem, aesToolStripMenuItem, base64ToolStripMenuItem });
            encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            encryptToolStripMenuItem.Size = new Size(62, 28);
            encryptToolStripMenuItem.Text = "加密";
            // 
            // rSAToolStripMenuItem1
            // 
            rsaToolStripMenuItem.Name = "rsaToolStripMenuItem";
            rsaToolStripMenuItem.Size = new Size(270, 34);
            rsaToolStripMenuItem.Text = "RSA";
            rsaToolStripMenuItem.Click += rsaToolStripMenuItem_Click;
            // 
            // aESToolStripMenuItem1
            // 
            aesToolStripMenuItem.Name = "aesToolStripMenuItem";
            aesToolStripMenuItem.Size = new Size(270, 34);
            aesToolStripMenuItem.Text = "AES";
            aesToolStripMenuItem.Click += aesToolStripMenuItem_Click;
            // 
            // base64ToolStripMenuItem1
            // 
            base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
            base64ToolStripMenuItem.Size = new Size(270, 34);
            base64ToolStripMenuItem.Text = "Base64";
            base64ToolStripMenuItem.Click += base64ToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(1378, 808);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "MainForm";
            Text = "加密工具";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        // 在类中添加控件成员变量
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        //private System.Windows.Forms.ToolStripMenuItem rsaToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem aesToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem base64ToolStripMenuItem;
        private ToolStripMenuItem encryptToolStripMenuItem;
        private ToolStripMenuItem rsaToolStripMenuItem;
        private ToolStripMenuItem aesToolStripMenuItem;
        private ToolStripMenuItem base64ToolStripMenuItem;
    }
}
