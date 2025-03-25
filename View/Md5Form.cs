using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using System.Windows.Forms;

namespace LittleFancyTool.View
{
    public partial class Md5Form : UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        public Md5Form(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            upperLowerSelect.SelectedIndex = 0;
            outputLengthSelect.SelectedIndex = 0;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string hash;
            int outputLength=int.Parse(outputLengthSelect.SelectedValue?.ToString());
            string? useUpperCase = upperLowerSelect.SelectedValue?.ToString();
            if (File.Exists(input))
            {
                messageService.InternationalizationMessage("文件摘要", null, "info", window);
                hash = ToolMethod.CalculateFileHash(input, "MD5");
                if (useUpperCase == "UPPER") {
                    hash = hash.ToUpper();
                }
                if (outputLength == 16)
                {
                    outputTextBox.Text = hash.Substring(8, 16);
                }
                else {
                    outputTextBox.Text = hash;
                }                    
            }
            else {
                
                try
                {
                    messageService.InternationalizationMessage("文本摘要", null, "info", window);
                    IEncryptionAbstract encryptionAlgorithm = new Md5Encryption();
                    string encryptedText = encryptionAlgorithm.Encrypt(input, useUpperCase, outputLength);
                    outputTextBox.Text = encryptedText;
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
                }
            }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    inputTextBox.Text = dialog.FileName;
                }
            }
        }
    }
}
