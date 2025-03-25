using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using LittleFancyTool.Utils;
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
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            progressBar.Visible = false;
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
            try
            {
                outputInput.Clear();
                progressBar.Visible = true;
                progressBar.Value = 0;
                compareBtn.Loading = true;
                compareBtn.Enabled = false;
                List<string> missingFiles = await CompareFoldersAsync(sourceFolderPath, targetFolderPath);
                if (missingFiles.Count == 0)
                {
                    messageService.InternationalizationMessage("目标文件夹包含原始文件夹的所有文件", null, "success", window);
                    outputInput.Text = "目标文件夹包含原始文件夹的所有文件";
                }
                else {
                    outputInput.Text = string.Join(Environment.NewLine, missingFiles);
                }                
            }
            catch (Exception ex)
            {
                compareBtn.Loading = false;
                compareBtn.Enabled = true;
                messageService.InternationalizationMessage("Error:", ex.Message, "error", window);
            }
        }

        private async Task<List<string>> CompareFoldersAsync(string sourceFolder, string targetFolder)
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
                     int sourceFileCount = sourceFiles.Count;
                    for (int i = 0; i < targetFileCount; i++)
                    {
                        var targetFile = targetFiles[i];
                        try
                        {
                            targetFileHashes[targetFile] = ToolMethod.CalculateFileHash(targetFile);
                        }
                        catch (Exception ex)
                        {
                            messageService.InternationalizationMessage("计算文件哈希值时发生错误", ex.Message, "error", window);
                        }
                        progressBar.Value = ((float)(i+1) / (targetFileCount + sourceFileCount));
                    }
                    
                    missingFiles = new List<string>();                   
                    for (int i = 0; i < sourceFileCount; i++)
                    {
                        var sourceFile = sourceFiles[i];
                        try
                        {
                            var sourceFileHash = ToolMethod.CalculateFileHash(sourceFile);
                            if (!targetFileHashes.Values.Contains(sourceFileHash))
                            {
                                missingFiles.Add(sourceFile);
                            }
                        }
                        catch (Exception ex)
                        {
                            messageService.InternationalizationMessage("计算文件哈希值时发生错误", ex.Message, "error", window);
                        }
                        float progress = (float)(targetFileCount + i + 1) / (targetFileCount + sourceFileCount);
                        progressBar.Value = progress;
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
                        progressBar.Value = progress;
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
    }
}
