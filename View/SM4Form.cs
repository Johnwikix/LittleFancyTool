using CryptoTool.Algorithms;
using LittleFancyTool.Algorithms;
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
        private const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;':\",./<>?";
        private AntdUI.Window window;
        public SM4Form(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            keyTextBox.Text = GenerateKey(128);
            ivTextBox.Text = GenerateKey(128);
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? paddingMode = paddingModeComboBox.SelectedValue?.ToString();
            string? key = keyTextBox.Text;
            string? iv = ivTextBox.Text;
            string? encryptModeStr = encryptMode.SelectedValue.ToString();
            if (ValidateAesIvLength(iv, window) && ValidateAesKeyLength(key, window))
            {
                try
                {
                    IEncryptionAlgorithm encryptionAlgorithm = new SM4Encryption();
                    string encryptedText = encryptionAlgorithm.Encrypt(input, key, paddingMode, 128, iv, encryptModeStr);
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
            if (ValidateAesIvLength(iv, window) && ValidateAesKeyLength(key, window))
            {
                try
                {
                    IEncryptionAlgorithm encryptionAlgorithm = new AESEncryption();
                    string decryptedText = encryptionAlgorithm.Decrypt(input, key, paddingMode, 128, iv,encryptModeStr);
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
            if (!(key.Length == 16))
            {
                AntdUI.Message.error(window, "密钥字符串长度必须为16字节", autoClose: 3);
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

            // AES 的 IV 长度固定为 128 位（16 字节）
            if (iv.Length != 16)
            {
                AntdUI.Message.error(window, "iv字符串长度必须为16字节", autoClose: 3);
                return false;
            }
            return true;
        }

        private void genKeyIv_Click(object sender, EventArgs e)
        {
            int keyLength = 128;
            keyTextBox.Text = GenerateKey(keyLength);
            ivTextBox.Text = GenerateKey(128);
        }

        public static string GenerateKey(int bitLength)
        {           
            Random random = new Random();
            StringBuilder key = new StringBuilder(128);

            for (int i = 0; i < 16; i++)
            {
                int index = random.Next(0, ValidChars.Length);
                key.Append(ValidChars[index]);
            }

            return key.ToString();
            //SecureRandom random = new SecureRandom();
            //byte[] key = new byte[bitLength / 16];
            //random.NextBytes(key);
            //StringBuilder sb = new StringBuilder();
            //foreach (byte b in key)
            //{
            //    sb.Append(b.ToString("x2"));
            //}
            //return sb.ToString();
        }
    }
}
