using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LittleFancyTool.View
{
    public partial class FolderCompareForm: UserControl
    {
        private AntdUI.Window window;
        private string sourceFolderPath;
        private string targetFolderPath;
        private MessageService messageService = new MessageService();
        public FolderCompareForm(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
        }

        private void targetFolderBtn_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    targetFolderPath = dialog.SelectedPath;
                    targetFolderInput.Text = targetFolderPath;
                }
            }
        }

        private void sourceFolderBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    sourceFolderPath = dialog.SelectedPath;
                    sourceFolderInput.Text = sourceFolderPath;
                }
            }
        }

        private async void compareBtn_ClickAsync(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(sourceFolderPath) || string.IsNullOrEmpty(targetFolderPath))
            {
                messageService.InternationalizationMessage("请选择源文件夹和目标文件夹",null,"warn",window);
                return;
            }
            progressBar.Value = 0;
            try
            {
                compareBtn.Loading = true;
                compareBtn.Enabled = false;
                List<string> missingFiles = await CompareFoldersAsync(sourceFolderPath, targetFolderPath, (progress) =>
                {
                    if (progressBar.InvokeRequired)
                    {
                        progressBar.Invoke(new Action(() => progressBar.Value = progress));
                    }
                    else
                    {
                        progressBar.Value = progress;
                    }
                });
                if (missingFiles.Count == 0) {
                    messageService.InternationalizationMessage("文件夹一致", null, "success", window);
                }
                outputInput.Text = string.Join(Environment.NewLine, missingFiles);
            }
            catch (Exception ex)
            {
                compareBtn.Loading = false;
                compareBtn.Enabled = true;
                messageService.InternationalizationMessage("发生错误: ", ex.Message, "error", window);
            }
        }

        private async Task<List<string>> CompareFoldersAsync(string sourceFolder, string targetFolder, Action<int> progressCallback)
        {
            return await Task.Run(() =>
            {
                var sourceFiles = GetAllFilesInFolder(sourceFolder);
                var targetFiles = GetAllFilesInFolder(targetFolder);
                List<string> missingFiles;
                if (hashCheckBox.Checked)
                {
                    var targetFileHashes = new Dictionary<string, string>();
                    int targetFileCount = targetFiles.Count;
                    for (int i = 0; i < targetFileCount; i++)
                    {
                        var targetFile = targetFiles[i];
                        try
                        {
                            targetFileHashes[targetFile] = CalculateFileHash(targetFile);
                        }
                        catch (Exception ex)
                        {
                            messageService.InternationalizationMessage("计算文件哈希值时发生错误", ex.Message, "error", window);
                        }
                        int progress = (int)((double)(i + 1) / targetFileCount * 50);
                        progressCallback(progress);
                    }

                    missingFiles = new List<string>();
                    int sourceFileCount = sourceFiles.Count;
                    for (int i = 0; i < sourceFileCount; i++)
                    {
                        var sourceFile = sourceFiles[i];
                        try
                        {
                            var sourceFileHash = CalculateFileHash(sourceFile);
                            if (!targetFileHashes.Values.Contains(sourceFileHash))
                            {
                                missingFiles.Add(sourceFile);
                            }
                        }
                        catch (Exception ex)
                        {
                            messageService.InternationalizationMessage("计算文件哈希值时发生错误", ex.Message, "error", window);
                        }
                        int progress = 50 + (int)((double)(i + 1) / sourceFileCount * 50);
                        progressCallback(progress);
                    }
                }
                else {
                    int fileCount = sourceFiles.Count;
                    missingFiles = new List<string>();
                    for (int i = 0; i < fileCount; i++)
                    {
                        var sourceFile = sourceFiles[i];
                        if (!targetFiles.Contains(sourceFile, StringComparer.OrdinalIgnoreCase))
                        {
                            missingFiles.Add(sourceFile);
                        }
                        int progress = (int)((double)(i + 1) / fileCount * 100);
                        progressCallback(progress);
                    }
                }
                compareBtn.Loading = false;
                compareBtn.Enabled = true;
                return missingFiles;
            });
        }

        private List<string> GetAllFilesInFolder(string folderPath)
        {
            List<string> files = new List<string>();
            try
            {
                files.AddRange(Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories));
            }
            catch (Exception ex)
            {
                compareBtn.Loading = false;
                compareBtn.Enabled = true;
                messageService.InternationalizationMessage("读取文件夹时发生错误", ex.Message, "error", window);
            }
            return files;
        }

        private string CalculateFileHash(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hashBytes = md5.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}
