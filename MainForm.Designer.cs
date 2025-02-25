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
            rsaToolStripMenuItem = new ToolStripMenuItem();
            aesToolStripMenuItem = new ToolStripMenuItem();
            base64ToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            mainMenuStrip.ImageScalingSize = new Size(24, 24);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { rsaToolStripMenuItem, aesToolStripMenuItem, base64ToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "menuStrip1";
            mainMenuStrip.Size = new Size(1378, 32);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // rsaToolStripMenuItem
            // 
            rsaToolStripMenuItem.Name = "rsaToolStripMenuItem";
            rsaToolStripMenuItem.Size = new Size(61, 28);
            rsaToolStripMenuItem.Text = "RSA";
            rsaToolStripMenuItem.Click += rsaToolStripMenuItem_Click;
            // 
            // aesToolStripMenuItem
            // 
            aesToolStripMenuItem.Name = "aesToolStripMenuItem";
            aesToolStripMenuItem.Size = new Size(59, 28);
            aesToolStripMenuItem.Text = "AES";
            aesToolStripMenuItem.Click += aesToolStripMenuItem_Click;
            // 
            // base64ToolStripMenuItem
            // 
            base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
            base64ToolStripMenuItem.Size = new Size(87, 28);
            base64ToolStripMenuItem.Text = "Base64";
            base64ToolStripMenuItem.Click += base64ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1378, 776);
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
        private System.Windows.Forms.ToolStripMenuItem rsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64ToolStripMenuItem;
       
    }
}
