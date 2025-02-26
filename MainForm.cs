using CryptoTool.Algorithms;
using CryptoTool.render;
using CryptoTool.View;
using System.Windows.Forms;

namespace CryptoTool
{
    public partial class MainForm : Form
    {
        private RSAForm rsaForm;
        private AESForm aesForm;
        private Base64Form base64Form;
        private CustomMenuRenderer menuRenderer;
        public MainForm()
        {
            InitializeComponent();
            rsaForm = new RSAForm();
            aesForm = new AESForm();
            base64Form = new Base64Form();

            ShowForm(rsaForm);
            //menuRenderer = new CustomMenuRenderer();
            //mainMenuStrip.Renderer = menuRenderer;

            //rsaToolStripMenuItem.Click += MenuItem_Click;
            //aesToolStripMenuItem.Click += MenuItem_Click;
            //base64ToolStripMenuItem.Click += MenuItem_Click;
           
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem != null)
            {
                menuRenderer.SetSelectedMenuItem(clickedItem);
                mainMenuStrip.Invalidate(); // 强制重绘 MenuStrip

                // 处理界面切换逻辑
                if (clickedItem == rsaToolStripMenuItem)
                {
                    ShowForm(rsaForm);
                }
                else if (clickedItem == aesToolStripMenuItem)
                {
                    ShowForm(aesForm);
                }
                else if (clickedItem == base64ToolStripMenuItem)
                {
                    ShowForm(base64Form);
                }
            }
        }


        private void ShowForm(Form form)
        {
            // 隐藏所有子窗体
            rsaForm.Hide();
            aesForm.Hide();
            base64Form.Hide();

            // 设置子窗体的父容器为当前主窗体
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // 添加子窗体到主窗体的容器中
            this.Controls.Add(form);
            form.Show();
        }

        private void rsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(rsaForm);
        }

        private void aesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(aesForm);
        }

        private void base64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(base64Form);
        }
    }
}
