using CryptoTool.Algorithms;
using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoTool.View
{
    public partial class RSAForm: UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        public RSAForm(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            rsaPaddingModeComboBox.SelectedIndex = 0;
            rsaKeyLengthComboBox.SelectedIndex = 2;
            rsaKeyFormatComboBox.SelectedIndex = 0;
        }

        private void rsaEncryptButton_Click(object sender, EventArgs e)
        {
            string input = rsaInputTextBox.Text;
            string publicKey = rsaPublicKeyTextBox.Text;
            if (string.IsNullOrEmpty(input))
            {
                messageService.InternationalizationMessage("请输入要加密的文本", null, "error", window);
                return;
            }
            if (string.IsNullOrEmpty(publicKey))
            {
                messageService.InternationalizationMessage("缺少公钥", null, "error", window);
                return;
            }
            string paddingMode = rsaPaddingModeComboBox.SelectedValue.ToString();
            int keyLength = int.Parse(rsaKeyLengthComboBox.SelectedValue.ToString());
            try
            {
                IEncryptionAsymmetric encryptionAlgorithm = new RSAEncryption();
                string encryptedText = ((RSAEncryption)encryptionAlgorithm).Encrypt(input, publicKey, paddingMode, keyLength);
                rsaOutputTextBox.Text = encryptedText;
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
            }
        }

        private void rsaDecryptButton_Click(object sender, EventArgs e)
        {
            string input = rsaOutputTextBox.Text;
            string privateKey = rsaPrivateKeyTextBox.Text;
            if (string.IsNullOrEmpty(privateKey)) {
                messageService.InternationalizationMessage("缺少私钥", null, "error", window);
                return;
            }
            string paddingMode = rsaPaddingModeComboBox.SelectedValue?.ToString();
            int keyLength = int.Parse(rsaKeyLengthComboBox.SelectedValue.ToString());
            try
            {
                IEncryptionAsymmetric encryptionAlgorithm = new RSAEncryption();
                string decryptedText = ((RSAEncryption)encryptionAlgorithm).Decrypt(input, privateKey, paddingMode, keyLength);
                rsaInputTextBox.Text = decryptedText;
            }
            catch (Exception ex) {
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
            }
            
        }

        private void rsaGenerateKeyPairButton_Click(object sender, EventArgs e)
        {
            int keyLength = int.Parse(rsaKeyLengthComboBox.SelectedValue.ToString());
            RSAEncryption rsaEncryption = new RSAEncryption();
            string keyFormat = rsaKeyFormatComboBox.SelectedValue.ToString();
            var (publicKey, privateKey) = rsaEncryption.GenerateKeyPair(keyLength, keyFormat);
            rsaPublicKeyTextBox.Text = publicKey;
            rsaPrivateKeyTextBox.Text = privateKey;
        }
    }
}
