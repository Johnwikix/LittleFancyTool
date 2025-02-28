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
    public partial class SHAForm: UserControl
    {
        private AntdUI.Window window;
        public SHAForm(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            mode.SelectedIndex = 0;
            upperLowerCase.SelectedIndex = 0;
        }
        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? algMode = mode.SelectedValue?.ToString();
            string? upperLowerCaseStr = upperLowerCase.SelectedValue?.ToString();
            try
            {
                IEncryptionAlgorithm encryptionAlgorithm = new SHAEncrpytion();
                string encryptedText = encryptionAlgorithm.Encrypt(input, algMode, upperLowerCaseStr);
                outputTextBox.Text = encryptedText;
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(window, ex.Message, autoClose: 3);
            }
        }
    }
}
