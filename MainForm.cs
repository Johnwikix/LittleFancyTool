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
                mainMenuStrip.Invalidate(); // ǿ���ػ� MenuStrip

                // ��������л��߼�
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
            // ���������Ӵ���
            rsaForm.Hide();
            aesForm.Hide();
            base64Form.Hide();

            // �����Ӵ���ĸ�����Ϊ��ǰ������
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // ����Ӵ��嵽�������������
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
