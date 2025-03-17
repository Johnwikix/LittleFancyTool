using CryptoTool.Algorithms;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoTool.View
{
    public partial class AESForm : UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        public AESForm(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            paddingModeComboBox.SelectedIndex = 0;
            keyLengthComboBox.SelectedIndex = 0;
            keyTextBox.Text = ToolMethod.GenerateSymmetricKey(128, "text");
            ivTextBox.Text = ToolMethod.GenerateSymmetricKey(128, "text");
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? paddingMode = paddingModeComboBox.SelectedValue?.ToString();
            string? key = keyTextBox.Text;
            string? iv = ivTextBox.Text;
            string? encryptModeStr = encryptModeSelect.SelectedValue.ToString();
            string? outputType = outputTypeSelect.SelectedValue?.ToString();
            string? keyIvType = keyIvTypeSelect.SelectedValue?.ToString();
            if (!ValidateAesIvLength(iv, window, keyIvType))
            {
                return;
            }
            if (!ValidateAesKeyLength(key, window, keyIvType))
            {
                return;
            }
            try
            {
                IEncryptionSymmetric encryptionAlgorithm = new AESEncryption();
                string encryptedText = encryptionAlgorithm.Encrypt(input, key, paddingMode, 128, iv, encryptModeStr, outputType, keyIvType);
                outputTextBox.Text = encryptedText;
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
            }

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string input = outputTextBox.Text;
            string? paddingMode = paddingModeComboBox.SelectedValue?.ToString();
            string? key = keyTextBox.Text;
            string? iv = ivTextBox.Text;
            string? encryptModeStr = encryptModeSelect.SelectedValue.ToString();
            string? outputType = outputTypeSelect.SelectedValue?.ToString();
            string? keyIvType = keyIvTypeSelect.SelectedValue?.ToString();
            if (!ValidateAesIvLength(iv, window, keyIvType))
            {
                return;
            }
            if (ValidateAesKeyLength(key, window, keyIvType))
            {
                return;
            }
            try
            {
                IEncryptionSymmetric encryptionAlgorithm = new AESEncryption();
                string decryptedText = encryptionAlgorithm.Decrypt(input, key, paddingMode, 128, iv, encryptModeStr, outputType, keyIvType);
                inputTextBox.Text = decryptedText;
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
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
            if (!(key.Length == 16 || key.Length == 24 || key.Length == 32))
            {
                messageService.InternationalizationMessage("密钥字符串长度必须为16字节或24字节或32字节",null, "error", window);
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
            int keyLength = int.Parse(keyLengthComboBox.SelectedValue?.ToString());
            string? keyIvType = keyIvTypeSelect.SelectedValue?.ToString();
            keyTextBox.Text = ToolMethod.GenerateSymmetricKey(keyLength, keyIvType);
            ivTextBox.Text = ToolMethod.GenerateSymmetricKey(128, keyIvType);
        }
    }
}
