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
    public partial class AESForm: Form
    {
        public AESForm()
        {
            InitializeComponent();
            paddingModeComboBox.SelectedIndex = 0;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string paddingMode = paddingModeComboBox.SelectedItem?.ToString();
            IEncryptionAlgorithm encryptionAlgorithm = new AESEncryption();
            string encryptedText = encryptionAlgorithm.Encrypt(input,null,paddingMode);
            outputTextBox.Text = encryptedText;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string input = outputTextBox.Text;
            string paddingMode = paddingModeComboBox.SelectedItem?.ToString();
            IEncryptionAlgorithm encryptionAlgorithm = new AESEncryption();
            string decryptedText = encryptionAlgorithm.Decrypt(input, null, paddingMode);
            inputTextBox.Text = decryptedText;
        }
    }
}
