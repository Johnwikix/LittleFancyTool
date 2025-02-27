using CryptoTool.Algorithms;
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
        private const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;':\",./<>?";
        public AESForm()
        {
            InitializeComponent();
            paddingModeComboBox.SelectedIndex = 0;
            keyLengthComboBox.SelectedIndex = 0;
            keyTextBox.Text = "0123456789abcdef";
            ivTextBox.Text = "abcdef9876543210";
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? paddingMode = paddingModeComboBox.SelectedItem?.ToString();
            string? key = keyTextBox.Text;
            string? iv = ivTextBox.Text;
            if (ValidateAesIvLength(iv) && ValidateAesKeyLength(key))
            {
                IEncryptionAlgorithm encryptionAlgorithm = new AESEncryption();
                string encryptedText = encryptionAlgorithm.Encrypt(input, key, paddingMode, 128, iv);
                outputTextBox.Text = encryptedText;
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string input = outputTextBox.Text;
            string? paddingMode = paddingModeComboBox.SelectedItem?.ToString();
            string? key = keyTextBox.Text;
            string? iv = ivTextBox.Text;
            if (ValidateAesIvLength(iv) && ValidateAesKeyLength(key))
            {
                IEncryptionAlgorithm encryptionAlgorithm = new AESEncryption();
                string decryptedText = encryptionAlgorithm.Decrypt(input, key, paddingMode, 128, iv);
                inputTextBox.Text = decryptedText;
            }
        }

        public static bool ValidateAesKeyLength(string keyStr)
        {
            if (string.IsNullOrEmpty(keyStr))
            {
                MessageBox.Show("密钥字符串不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 将字符串转换为字节数组
            byte[] key = Encoding.UTF8.GetBytes(keyStr);

            // AES 支持的密钥长度为 128 位（16 字节）、192 位（24 字节）和 256 位（32 字节）
            if (!(key.Length == 16 || key.Length == 24 || key.Length == 32))
            {
                MessageBox.Show("密钥字符串长度必须为16字节或24字节或32字节", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ValidateAesIvLength(string ivStr)
        {
            if (string.IsNullOrEmpty(ivStr))
            {
                MessageBox.Show("iv字符串不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 将字符串转换为字节数组
            byte[] iv = Encoding.UTF8.GetBytes(ivStr);

            // AES 的 IV 长度固定为 128 位（16 字节）
            if (iv.Length != 16)
            {
                MessageBox.Show("iv字符串长度必须为16字节", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void genKeyIv_Click(object sender, EventArgs e)
        {
            int keyLength = int.Parse(keyLengthComboBox.SelectedItem.ToString());
            keyTextBox.Text = GenerateKey(keyLength);
            ivTextBox.Text = GenerateKey(128);
        }

        public static string GenerateKey(int bitLength)
        {
            int length;
            switch (bitLength)
            {
                case 128:
                    length = 16;
                    break;
                case 192:
                    length = 24;
                    break;
                case 256:
                    length = 32;
                    break;
                default:
                    throw new ArgumentException("Invalid bit length. Supported lengths are 128, 192, and 256.");
            }

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
