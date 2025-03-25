using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using System.Security.Policy;

namespace LittleFancyTool.View
{
    public partial class SHAForm : UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        public SHAForm(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            mode.SelectedIndex = 0;
            upperLowerCase.SelectedIndex = 0;
        }
        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string hash;
            string? algMode = mode.SelectedValue?.ToString();
            string? upperLowerCaseStr = upperLowerCase.SelectedValue?.ToString();
            if (File.Exists(input))
            {
                messageService.InternationalizationMessage("文件摘要", null, "info", window);
                hash = ToolMethod.CalculateFileHash(input, algMode);
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
                    IEncryptionAbstract encryptionAlgorithm = new SHAEncrpytion();
                    string encryptedText = encryptionAlgorithm.Encrypt(input, upperLowerCaseStr, 0, algMode);
                    outputTextBox.Text = encryptedText;
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, ex.Message, autoClose: 3);
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
