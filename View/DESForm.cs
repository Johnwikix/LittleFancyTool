using CryptoTool.Algorithms;
using LittleFancyTool.Algorithms;
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
    public partial class DESForm: UserControl
    {
        private const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;':\",./<>?";
        private AntdUI.Window window;
        public DESForm(AntdUI.Window window)
        {
            this.window = window;
            InitializeComponent();
            paddingModeComboBox.SelectedIndex = 0;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? paddingMode = paddingModeComboBox.SelectedValue?.ToString();
            string? key = keyTextBox.Text;
            string? iv = ivTextBox.Text;
            if (ValidateAesIvLength(iv, window) && ValidateAesKeyLength(key, window))
            {
                try
                {
                    IEncryptionAlgorithm encryptionAlgorithm = new DESEncryption();
                    string encryptedText = encryptionAlgorithm.Encrypt(input, key, paddingMode, 64, iv);
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
            if (ValidateAesIvLength(iv, window) && ValidateAesKeyLength(key, window))
            {
                try
                {
                    IEncryptionAlgorithm encryptionAlgorithm = new DESEncryption();
                    string decryptedText = encryptionAlgorithm.Decrypt(input, key, paddingMode, 64, iv);
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

            if (!(key.Length == 8))
            {
                AntdUI.Message.error(window, "密钥字符串长度必须为8字节", autoClose: 3);
                return false;
            }
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
            if (iv.Length != 8)
            {
                AntdUI.Message.error(window, "iv字符串长度必须为8字节", autoClose: 3);
                return false;
            }
            return true;
        }

        private void genKeyIv_Click(object sender, EventArgs e)
        {            
            keyTextBox.Text = GenerateKey();
            ivTextBox.Text = GenerateKey();
        }

        public static string GenerateKey()
        {
            int length = 8;
            Random random = new Random();
            StringBuilder key = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, ValidChars.Length);
                key.Append(ValidChars[index]);
            }

            return key.ToString();
        }
    }
}
