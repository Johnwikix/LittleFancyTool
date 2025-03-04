using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LittleFancyTool.View
{
    public partial class FileEncryptForm : UserControl
    {
        private string inputFilePath;
        private string outputDirectory;
        private AntdUI.Window window;
        public FileEncryptForm(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
            keyModeSelect.Visible = false;
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = openFileDialog.FileName;
                filePathInput.Text = inputFilePath;
                outputPathInput.Text = Path.GetDirectoryName(inputFilePath); ;
            }
        }

        private async void encryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePathInput.Text) || string.IsNullOrEmpty(outputPathInput.Text))
            {
                AntdUI.Message.warn(window, "请选择要加密的文件和输出目录!", autoClose: 3);
                return;
            }

            if (string.IsNullOrEmpty(keyInput.Text) || string.IsNullOrEmpty(ivInput.Text))
            {
                AntdUI.Message.warn(window, "请选择输入密钥和iv", autoClose: 3);
                return;
            }

            string outputFilePath = Path.Combine(outputPathInput.Text, Path.GetFileName(inputFilePath) + ".encrypted");
            if (encryptAlgSelect.SelectedValue.ToString() == "AES") {
                try
                {
                    FileEncryptor encryptor = new FileEncryptor();
                    string aesKey = keyInput.Text;
                    string aesIV = ivInput.Text;
                    await encryptor.EncryptFileAsync(filePathInput.Text, outputFilePath, aesKey, aesIV);
                    AntdUI.Message.success(window, "文件加密成功", autoClose: 3);
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, "文件加密失败:" + ex, autoClose: 3);
                }
            }
            if (encryptAlgSelect.SelectedValue.ToString() == "RSA") {
                try
                {
                    IEncryptionAsymmetric encryptor = new RSAEncryption();
                    string publicKey = keyInput.Text;
                    string privateKey = ivInput.Text;
                    int keyLength = int.Parse(keyLengthSelect.SelectedValue.ToString());
                    await encryptor.EncryptFileAsync(filePathInput.Text, outputFilePath, publicKey, keyLength);
                    AntdUI.Message.success(window, "文件加密成功", autoClose: 3);
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, "文件加密失败:" + ex, autoClose: 3);
                }
            }
            

        }

        private void outputPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputDirectory = folderBrowserDialog.SelectedPath;
                outputPathInput.Text = outputDirectory;
            }

        }

        private void genKeyIvBtn_Click(object sender, EventArgs e)
        {
            if (encryptAlgSelect.SelectedValue.ToString() == "AES")
            {
                int keyLength = int.Parse(keyLengthSelect.SelectedValue.ToString());
                string? keyIvType = "text";
                keyInput.Text = ToolMethod.GenerateSymmetricKey(keyLength, keyIvType);
                ivInput.Text = ToolMethod.GenerateSymmetricKey(128, keyIvType);
            }
            if (encryptAlgSelect.SelectedValue.ToString() == "RSA") {
                int keyLength = int.Parse(keyLengthSelect.SelectedValue.ToString());
                RSAEncryption rsaEncryption = new RSAEncryption();
                string keyFormat = keyModeSelect.SelectedValue.ToString();
                var (publicKey, privateKey) = rsaEncryption.GenerateKeyPair(keyLength, keyFormat);
                keyInput.Text = publicKey;
                ivInput.Text = privateKey;
            }
                
        }

        private async void decryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePathInput.Text) || string.IsNullOrEmpty(outputPathInput.Text))
            {
                AntdUI.Message.warn(window, "请选择要解密的文件和输出目录!", autoClose: 3);
                return;
            }

            if (string.IsNullOrEmpty(keyInput.Text) || string.IsNullOrEmpty(ivInput.Text))
            {
                AntdUI.Message.warn(window, "请选择输入密钥和iv", autoClose: 3);
                return;
            }
            string fileName = Path.GetFileName(filePathInput.Text).Substring(0, Path.GetFileName(filePathInput.Text).LastIndexOf(".encrypted"));
            string outputFilePath = Path.Combine(outputPathInput.Text, fileName);

            if (encryptAlgSelect.SelectedValue.ToString() == "AES")
            {
                try
                {
                    FileEncryptor encryptor = new FileEncryptor();
                    string aesKey = keyInput.Text;
                    string aesIV = ivInput.Text;
                    await encryptor.DecryptFileAsync(filePathInput.Text, outputFilePath, aesKey, aesIV);
                    AntdUI.Message.success(window, "文件解密成功", autoClose: 3);
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, "文件解密失败:" + ex, autoClose: 3);
                }
            }
            if (encryptAlgSelect.SelectedValue.ToString() == "RSA")
            {
                try
                {
                    IEncryptionAsymmetric encryptor = new RSAEncryption();
                    string publicKey = keyInput.Text;
                    string privateKey = ivInput.Text;
                    int keyLength = int.Parse(keyLengthSelect.SelectedValue.ToString());
                    await encryptor.DecryptFileAsync(filePathInput.Text, outputFilePath, publicKey, keyLength);
                    AntdUI.Message.success(window, "文件解密成功", autoClose: 3);
                }
                catch (Exception ex)
                {
                    AntdUI.Message.error(window, "文件解密失败:" + ex, autoClose: 3);
                }
            }           

        }

        private void encryptAlgSelect_SelectedIndexChanged(object sender, AntdUI.IntEventArgs e)
        {
            keyInput.Text = null;
            ivInput.Text = null;
            keyLengthSelect.Clear();
            keyModeSelect.Clear();
            keyLengthSelect.Items.Clear();
            keyModeSelect.Items.Clear();           
            if (encryptAlgSelect.SelectedValue.ToString() == "RSA")
            {
                label1.Text = "公钥";
                label2.Text = "私钥";
                keyLengthSelect.Items.AddRange(new object[] { "512", "1024", "2048","4096" });
                keyLengthSelect.SelectedIndex = 2;
                keyModeSelect.Visible = true;
                keyModeSelect.Items.AddRange(new object[] { "PKCS#8", "PKCS#1" });
                keyModeSelect.SelectedIndex = 0;
            }
            if (encryptAlgSelect.SelectedValue.ToString() == "AES") {
                label1.Text = "密钥";
                label2.Text = "偏移";
                keyLengthSelect.Items.AddRange(new object[] { "128", "192", "256" });
                keyLengthSelect.SelectedIndex = 0;
                keyModeSelect.Visible = false;
            }
        }
    }
}
