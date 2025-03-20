using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;

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
            string? useUpperCase = upperLowerSelect.SelectedValue?.ToString();
            int outputLength = int.Parse(outputLengthSelect.SelectedValue?.ToString());
            try
            {
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
}
