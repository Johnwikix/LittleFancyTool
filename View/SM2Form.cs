using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;

namespace LittleFancyTool.View
{
    public partial class SM2Form : UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        public SM2Form(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
        }
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string publicKey = publicKeyTextBox.Text;
            if (string.IsNullOrEmpty(publicKey))
            {
                messageService.InternationalizationMessage("缺少公钥", null, "error", window);
                return;
            }
            if (string.IsNullOrEmpty(input))
            {
                messageService.InternationalizationMessage("请输入要加密的文本", null, "error", window);
                return;
            }
            string paddingMode = paddingModeComboBox.SelectedValue.ToString();
            try
            {
                IEncryptionAsymmetric encryptionAlgorithm = new SM2Encryption();
                string encryptedText = ((SM2Encryption)encryptionAlgorithm).Encrypt(input, publicKey, paddingMode);
                outputTextBox.Text = encryptedText;
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string input = outputTextBox.Text;
            string privateKey = privateKeyTextBox.Text;
            if (string.IsNullOrEmpty(privateKey))
            {
                messageService.InternationalizationMessage("缺少私钥", null, "error", window);
                return;
            }
            string paddingMode = paddingModeComboBox.SelectedValue?.ToString();
            try
            {
                IEncryptionAsymmetric encryptionAlgorithm = new SM2Encryption();
                string decryptedText = ((SM2Encryption)encryptionAlgorithm).Decrypt(input, privateKey, paddingMode);
                inputTextBox.Text = decryptedText;
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
            }

        }

        private void GenerateKeyPairButton_Click(object sender, EventArgs e)
        {
            SM2Encryption encryption = new SM2Encryption();
            var (publicKey, privateKey) = encryption.GenerateKeyPair();
            publicKeyTextBox.Text = publicKey;
            privateKeyTextBox.Text = privateKey;
        }
    }
}
