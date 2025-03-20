using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;

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
            string? upperLowerCaseStr = upperLowerCase.SelectedValue?.ToString();
            try
            {
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
}
