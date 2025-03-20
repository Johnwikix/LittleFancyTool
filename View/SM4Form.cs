using CryptoTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

namespace LittleFancyTool.View
{
    public partial class SM4Form : UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        public SM4Form(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            keyTextBox.Text = ToolMethod.GenerateSymmetricKey(128, "text");
            ivTextBox.Text = ToolMethod.GenerateSymmetricKey(128, "text");
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? paddingMode = paddingModeComboBox.SelectedValue?.ToString();
            string? key = keyTextBox.Text;
            string? iv = ivTextBox.Text;
            string? encryptModeStr = encryptMode.SelectedValue.ToString();
            string? outputType = outputTypeSelect.SelectedValue?.ToString();
            string? keyIvType = keyIvTypeSelect.SelectedValue?.ToString();
            if (ValidateAesIvLength(iv, window, keyIvType) && ValidateAesKeyLength(key, window, keyIvType))
            {
                try
                {
                    IEncryptionSymmetric encryptionAlgorithm = new SM4Encryption();
                    string encryptedText = encryptionAlgorithm.Encrypt(input, key, paddingMode, 128, iv, encryptModeStr, outputType, keyIvType);
                    outputTextBox.Text = encryptedText;
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string input = outputTextBox.Text;
            string? paddingMode = paddingModeComboBox.SelectedValue?.ToString();
            string? key = keyTextBox.Text;
            string? iv = ivTextBox.Text;
            string? encryptModeStr = encryptMode.SelectedValue.ToString();
            string? outputType = outputTypeSelect.SelectedValue?.ToString();
            string? keyIvType = keyIvTypeSelect.SelectedValue?.ToString();
            if (ValidateAesIvLength(iv, window, keyIvType) && ValidateAesKeyLength(key, window, keyIvType))
            {
                try
                {
                    IEncryptionSymmetric encryptionAlgorithm = new SM4Encryption();
                    string decryptedText = encryptionAlgorithm.Decrypt(input, key, paddingMode, 128, iv, encryptModeStr, outputType, keyIvType);
                    inputTextBox.Text = decryptedText;
                }
                catch (Exception ex)
                {
                    messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
                }
            }
        }

        public bool ValidateAesKeyLength(string keyStr, AntdUI.Window window, string keyIvType)
        {
            if (string.IsNullOrEmpty(keyStr))
            {
                messageService.InternationalizationMessage("密钥字符串不能为空", null, "error", window);
                return false;
            }
            byte[] key = Encoding.UTF8.GetBytes(keyStr);
            if (keyIvType == "hex")
            {
                key = Hex.Decode(keyStr);
            }
            if (keyIvType == "base64")
            {
                key = Convert.FromBase64String(keyStr);
            }
            if (key.Length != 16)
            {
                messageService.InternationalizationMessage("密钥字符串长度必须为16字节", null, "error", window);
                return false;
            }
            return true;
        }

        public bool ValidateAesIvLength(string ivStr, AntdUI.Window window, string keyIvType)
        {
            if (string.IsNullOrEmpty(ivStr))
            {
                messageService.InternationalizationMessage("iv字符串不能为空", null, "error", window);
                return false;
            }
            byte[] iv = Encoding.UTF8.GetBytes(ivStr);
            if (keyIvType == "hex")
            {
                iv = Hex.Decode(ivStr);
            }
            if (keyIvType == "base64")
            {
                iv = Convert.FromBase64String(ivStr);
            }
            if (iv.Length != 16)
            {
                messageService.InternationalizationMessage("iv字符串长度必须为16字节", null, "error", window);
                return false;
            }
            return true;
        }

        private void genKeyIv_Click(object sender, EventArgs e)
        {
            string? keyIvType = keyIvTypeSelect.SelectedValue?.ToString();
            keyTextBox.Text = ToolMethod.GenerateSymmetricKey(128, keyIvType);
            ivTextBox.Text = ToolMethod.GenerateSymmetricKey(128, keyIvType);
        }
    }
}
