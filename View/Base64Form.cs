using CryptoTool.Algorithms;
using LittleFancyTool.Algorithms;

namespace CryptoTool.View
{
    public partial class Base64Form : UserControl
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

        private void picBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
