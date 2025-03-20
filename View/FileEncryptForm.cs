using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private IMessageService messageService = new MessageService();
        public FileEncryptForm(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            var startTime = DateTime.Now;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                CheckFileExists = false,
                CheckPathExists = true,
                ValidateNames = false
            };
            System.Diagnostics.Debug.WriteLine("打开文件对话框耗时: " + (DateTime.Now - startTime).TotalMilliseconds);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathInput.Clear();
                List<string> filePaths = new List<string>();
                foreach (string selectedPath in openFileDialog.FileNames)
                {
                    filePathInput.AppendText(selectedPath + Environment.NewLine);
                }
                if (openFileDialog.FileNames.Length > 0)
                {
                    outputPathInput.Text = Path.GetDirectoryName(openFileDialog.FileNames[0]) ?? string.Empty;
                }
            }
            System.Diagnostics.Debug.WriteLine("选择文件耗时: " + (DateTime.Now - startTime).TotalMilliseconds);
        }

        private async void encryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keyInput.Text) || string.IsNullOrEmpty(ivInput.Text))
            {
                messageService.InternationalizationMessage("请选择输入密钥和iv", null, "warn", window);
                return;
            }
            string multiLineString = filePathInput.Text;
            string[] filePaths = multiLineString.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                       .Where(line => !string.IsNullOrWhiteSpace(line))
                                       .ToArray();
            if (filePaths.Length == 0)
            {
                messageService.InternationalizationMessage("请先选择要加密的文件！", null, "warn", window);
                return;
            }
            var startTime = DateTime.Now;
            encryptBtn.Loading = true;
            List<Task> encryptionTasks = new List<Task>();
            int errorCount = 0;
            foreach (string filePath in filePaths)
            {
                if (File.Exists(filePath))
                {
                    string outputFilePath = Path.Combine(outputPathInput.Text, Path.GetFileName(filePath) + ".encrypted");
                    FileEncryptor encryptor = new FileEncryptor();
                    string currentPath = filePath;
                    Task encryptionTask = Task.Run(async () => await encryptor.EncryptFileAsync(currentPath, outputFilePath, keyInput.Text, ivInput.Text));
                    encryptionTasks.Add(encryptionTask);
                }
                else {
                    errorCount++;
                    break;
                }
            }
            try
            {
                await Task.WhenAll(encryptionTasks).ConfigureAwait(true);
                encryptBtn.Loading = false;
                if (errorCount > 0)
                {
                    messageService.InternationalizationMessage("加密出错，文件未读取",null, "error", window);
                }
                else {
                    createLog(keyInput.Text, ivInput.Text, filePathInput.Text, outputPathInput.Text);
                    var endTime = DateTime.Now;
                    var elapsedTime = endTime - startTime;                    
                    messageService.InternationalizationMessage("所有文件加密完成,耗时: ", $"{elapsedTime.TotalSeconds:0.00}", "success", window);
                }
            }
            catch (Exception ex)
            {
                encryptBtn.Loading = false;
                messageService.InternationalizationMessage("加密过程中出现错误:", ex.Message, "error", window);
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
            int keyLength = int.Parse(keyLengthSelect.SelectedValue.ToString());
            string? keyIvType = "text";
            keyInput.Text = ToolMethod.GenerateSymmetricKey(keyLength, keyIvType);
            ivInput.Text = ToolMethod.GenerateSymmetricKey(128, keyIvType);
        }

        private async void decryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(outputPathInput.Text))
            {
                messageService.InternationalizationMessage("请选择输出目录!", null, "warn", window);
                return;
            }

            if (string.IsNullOrEmpty(keyInput.Text) || string.IsNullOrEmpty(ivInput.Text))
            {
                messageService.InternationalizationMessage("请选择输入密钥和iv", null, "warn", window);
                return;
            }

            string multiLineString = filePathInput.Text;
            string[] filePaths = multiLineString.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                       .Where(line => !string.IsNullOrWhiteSpace(line))
                                       .ToArray();
            if (filePaths.Length == 0)
            {
                messageService.InternationalizationMessage("请先选择要解密的文件！", null, "warn", window);
                return;
            }
            decryptBtn.Loading = true;
            var startTime = DateTime.Now;
            List<Task> decryptionTasks = new List<Task>();
            foreach (string filePath in filePaths)
            {
                if (File.Exists(filePath))
                {
                    string originalFileName = Path.GetFileName(filePath);
                    if (Path.GetExtension(originalFileName) != ".encrypted")
                    {
                        messageService.InternationalizationMessage("请选择加密后的文件", null, "warn", window);
                        decryptBtn.Loading = false;
                        return;
                    }
                    string baseFileName = Path.GetFileNameWithoutExtension(filePath);
                    string extension = Path.GetExtension(baseFileName);
                    baseFileName = baseFileName.Substring(0, baseFileName.LastIndexOf("."));
                    string fileName = $"{baseFileName}-decrypted{extension}";
                    string baseOutputPath = Path.Combine(outputPathInput.Text, $"{baseFileName}-decrypted{extension}");
                    string outputFilePath = GetUniqueFileName(baseOutputPath);
                    FileEncryptor encryptor = new FileEncryptor();
                    Task encryptionTask = Task.Run(async () => await encryptor.DecryptFileAsync(filePath, outputFilePath, keyInput.Text, ivInput.Text));
                    decryptionTasks.Add(encryptionTask);
                }
            }

            try
            {
                await Task.WhenAll(decryptionTasks).ConfigureAwait(true);
                var endTime = DateTime.Now;
                var elapsedTime = endTime - startTime;
                decryptBtn.Loading = false;
                messageService.InternationalizationMessage("所有文件解密完成,耗时: ", $"{elapsedTime.TotalSeconds:0.00}", "success", window);
            }
            catch (Exception ex)
            {
                decryptBtn.Loading = false;
                messageService.InternationalizationMessage("解密过程中出现错误:", ex.Message, "error", window);
            }
        }

        private string GetUniqueFileName(string basePath)
        {
            string directory = Path.GetDirectoryName(basePath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(basePath);
            string extension = Path.GetExtension(basePath);

            if (!File.Exists(basePath))
            {
                return basePath;
            }

            int counter = 1;
            string newPath;
            do
            {
                newPath = Path.Combine(directory, $"{fileNameWithoutExtension}-{counter}{extension}");
                counter++;
            } while (File.Exists(newPath));

            return newPath;
        }

        private void openPathBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = outputPathInput.Text,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("打开目录时出现错误:", ex.Message, "error", window);
            }

        }

        private void createLog(string key, string iv, string filelist,string path)
        {
            string logContent = $"密钥：{key} \n偏移iv：{iv} \n加密文件: \n{filelist}";
            string logFileName = $"encryptLog_{DateTime.Now:yyyy-MM-dd HH-mm-ss}.log";
            string fullLogPath = Path.Combine(path, logFileName);
            try
            {
                File.WriteAllText(fullLogPath, logContent);
                messageService.InternationalizationMessage("写入日志:", fullLogPath, "success", window);
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("写入日志文件时出现错误:", ex.Message, "error", window);
            }
        }
    }
}
