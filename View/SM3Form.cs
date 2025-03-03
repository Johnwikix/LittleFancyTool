using CryptoTool.Algorithms;
using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
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
    public partial class SM3Form: UserControl
    {
        private AntdUI.Window window;
        public SM3Form(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            upperLowerCase.SelectedIndex = 0;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? upperLowerCaseStr = upperLowerCase.SelectedValue?.ToString();
            try
            {
                IEncryptionAbstract encryptionAlgorithm = new SM3Encryption();
                string encryptedText = encryptionAlgorithm.Encrypt(input,upperLowerCaseStr);
                outputTextBox.Text = encryptedText;
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(window, ex.Message, autoClose: 3);
            }
        }
    }
}
