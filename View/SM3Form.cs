using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using System.Security.Policy;

namespace LittleFancyTool.View
{
    public partial class SM3Form : UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        public SM3Form(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            upperLowerCase.SelectedIndex = 0;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            List<string> fileList = input.Split("\r\n").ToList();
            string hash;
            string? upperLowerCaseStr = upperLowerCase.SelectedValue?.ToString();
            if (File.Exists(input))
            {
                messageService.InternationalizationMessage("文件摘要", null, "info", window);
                hash = ToolMethod.CalculateFileHash(input, "SM3");
                if (upperLowerCaseStr == "UPPER")
                {
                    hash = hash.ToUpper();
                }                
                outputTextBox.Text = hash;                
            }
            else {
                try
                {
                    messageService.InternationalizationMessage("文本摘要", null, "info", window);
                    IEncryptionAbstract encryptionAlgorithm = new SM3Encryption();
                    string encryptedText = encryptionAlgorithm.Encrypt(input, upperLowerCaseStr);
                    outputTextBox.Text = encryptedText;
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
                }
            }                
        }

        private void addFileBtn_Click(object sender, EventArgs e)
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
