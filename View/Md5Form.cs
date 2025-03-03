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
    public partial class Md5Form: UserControl
    {
        private AntdUI.Window window;
        public Md5Form(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            upperLowerSelect.SelectedIndex = 0;
            outputLengthSelect.SelectedIndex = 0;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? useUpperCase = upperLowerSelect.SelectedValue?.ToString();
            int outputLength = int.Parse(outputLengthSelect.SelectedValue?.ToString());
            try
            {
                IEncryptionAbstract encryptionAlgorithm = new Md5Encryption();
                string encryptedText = encryptionAlgorithm.Encrypt(input,useUpperCase,outputLength);
                outputTextBox.Text = encryptedText;
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(window, ex.Message, autoClose: 3);
            }
        }
        //private void decryptButton_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("MD5算法不支持解密", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
    }
}
