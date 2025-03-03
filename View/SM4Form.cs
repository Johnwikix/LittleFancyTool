using CryptoTool.Algorithms;
using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Utils;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View
{
    public partial class SM4Form: UserControl
    {        
        private AntdUI.Window window;
        public SM4Form(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            keyTextBox.Text = ToolMethod.GenerateSymmetricKey(128,"text");
            ivTextBox.Text = ToolMethod.GenerateSymmetricKey(128,"text");
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
            if (ValidateAesIvLength(iv, window) && ValidateAesKeyLength(key, window))
            {
                try
                {
                    IEncryptionSymmetric encryptionAlgorithm = new SM4Encryption();
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
            string? encryptModeStr = encryptMode.SelectedValue.ToString();
            string? outputType = outputTypeSelect.SelectedValue?.ToString();
            string? keyIvType = keyIvTypeSelect.SelectedValue?.ToString();
            if (ValidateAesIvLength(iv, window) && ValidateAesKeyLength(key, window))
            {
                try
                {
                    IEncryptionSymmetric encryptionAlgorithm = new SM4Encryption();
                    string decryptedText = encryptionAlgorithm.Decrypt(input, key, paddingMode, 128, iv,encryptModeStr, outputType,keyIvType);
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
            byte[] key = Encoding.UTF8.GetBytes(keyStr);
            //if (!(key.Length == 16))
            //{
            //    AntdUI.Message.error(window, "密钥字符串长度必须为16字节", autoClose: 3);
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
            byte[] iv = Encoding.UTF8.GetBytes(ivStr);
            //if (iv.Length != 16)
            //{
            //    AntdUI.Message.error(window, "iv字符串长度必须为16字节", autoClose: 3);
            //    return false;
            //}
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
