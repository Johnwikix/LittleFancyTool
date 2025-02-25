using CryptoTool.Algorithms;
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
    public partial class RSAForm: Form
    {
        public RSAForm()
        {
            InitializeComponent();
            rsaPaddingModeComboBox.SelectedIndex = 0;
            rsaKeyLengthComboBox.SelectedIndex = 2;
            rsaKeyFormatComboBox.SelectedIndex = 0;
        }

        private void rsaEncryptButton_Click(object sender, EventArgs e)
        {
            string input = rsaInputTextBox.Text;
            string publicKey = rsaPublicKeyTextBox.Text;
            string paddingMode = rsaPaddingModeComboBox.SelectedItem?.ToString();
            int keyLength = int.Parse(rsaKeyLengthComboBox.SelectedItem.ToString());
            IEncryptionAlgorithm encryptionAlgorithm = new RSAEncryption();
            string encryptedText = ((RSAEncryption)encryptionAlgorithm).Encrypt(input, publicKey, paddingMode, keyLength);
            rsaOutputTextBox.Text = encryptedText;
        }

        private void rsaDecryptButton_Click(object sender, EventArgs e)
        {
            string input = rsaOutputTextBox.Text;
            string privateKey = rsaPrivateKeyTextBox.Text;
            string paddingMode = rsaPaddingModeComboBox.SelectedItem?.ToString();
            int keyLength = int.Parse(rsaKeyLengthComboBox.SelectedItem.ToString());
            IEncryptionAlgorithm encryptionAlgorithm = new RSAEncryption();
            string decryptedText = ((RSAEncryption)encryptionAlgorithm).Decrypt(input, privateKey, paddingMode, keyLength);
            rsaInputTextBox.Text = decryptedText;
        }

        private void rsaGenerateKeyPairButton_Click(object sender, EventArgs e)
        {
            int keyLength = int.Parse(rsaKeyLengthComboBox.SelectedItem.ToString());
            RSAEncryption rsaEncryption = new RSAEncryption();
            string keyFormat = rsaKeyFormatComboBox.SelectedItem.ToString();
            var (publicKey, privateKey) = rsaEncryption.GenerateKeyPair(keyLength, keyFormat);
            rsaPublicKeyTextBox.Text = publicKey;
            rsaPrivateKeyTextBox.Text = privateKey;
        }
    }
}
