using CryptoTool.Algorithms;
using LittleFancyTool.Utils;
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
        public AESForm(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            paddingModeComboBox.SelectedIndex = 0;
            keyLengthComboBox.SelectedIndex = 0;
            keyTextBox.Text = ToolMethod.GenerateSymmetricKey(128,"text");
            ivTextBox.Text = ToolMethod.GenerateSymmetricKey(128,"text");
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
            if (ValidateAesIvLength(iv, window) && ValidateAesKeyLength(key, window))
            {
                try
                {
                    IEncryptionSymmetric encryptionAlgorithm = new AESEncryption();
                    string encryptedText = encryptionAlgorithm.Encrypt(input, key, paddingMode, 128, iv, encryptModeStr, outputType, keyIvType);
                    outputTextBox.Text = encryptedText;
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, ex.Message, autoClose: 3);
                }
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
            if (ValidateAesIvLength(iv, window) && ValidateAesKeyLength(key, window))
            {
                try
                {
                    IEncryptionSymmetric encryptionAlgorithm = new AESEncryption();
                    string decryptedText = encryptionAlgorithm.Decrypt(input, key, paddingMode, 128, iv,encryptModeStr,outputType,keyIvType);
                    inputTextBox.Text = decryptedText;
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, ex.Message, autoClose: 3);
                }
            }
        }

        public static bool ValidateAesKeyLength(string keyStr, AntdUI.Window window)
        {
            if (string.IsNullOrEmpty(keyStr))
            {
                AntdUI.Message.error(window, "密钥字符串不能为空", autoClose: 3);
                return false;
            }
            // 将字符串转换为字节数组
            byte[] key = Encoding.UTF8.GetBytes(keyStr);

            // AES 支持的密钥长度为 128 位（16 字节）、192 位（24 字节）和 256 位（32 字节）
            //if (!(key.Length == 16 || key.Length == 24 || key.Length == 32))
            //{
            //    AntdUI.Message.error(window, "密钥字符串长度必须为16字节或24字节或32字节", autoClose: 3);
            //    return false;
            //}
            return true;
        }

        public static bool ValidateAesIvLength(string ivStr, AntdUI.Window window)
        {
            if (string.IsNullOrEmpty(ivStr))
            {
                AntdUI.Message.error(window, "iv字符串不能为空", autoClose: 3);
                return false;
            }

            // 将字符串转换为字节数组
            byte[] iv = Encoding.UTF8.GetBytes(ivStr);

            // AES 的 IV 长度固定为 128 位（16 字节）
            //if (iv.Length != 16)
            //{
            //    AntdUI.Message.error(window, "iv字符串长度必须为16字节", autoClose: 3);
            //    return false;
            //}
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
