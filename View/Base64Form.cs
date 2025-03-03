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

namespace CryptoTool.View
{
    public partial class Base64Form: UserControl
    {
        public Base64Form()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            IEncryptionCode encryptionAlgorithm = new Base64Encryption();
            string encryptedText = encryptionAlgorithm.Encrypt(input);
            outputTextBox.Text = encryptedText;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string input = outputTextBox.Text;
            IEncryptionCode encryptionAlgorithm = new Base64Encryption();
            string decryptedText = encryptionAlgorithm.Decrypt(input);
            inputTextBox.Text = decryptedText;
        }
    }
}
