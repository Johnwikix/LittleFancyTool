using AntdUI;
using LittleFancyTool.Languages;
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
            musicTitleCheckBox.Checked = true;
        }

        private void targetFolderBtn_Click(object sender, EventArgs e) {
            using (System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog())
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
            using (System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    sourceFolderPath = dialog.SelectedPath;
                    sourceFolderInput.Text = sourceFolderPath;
                }
            }
        }

        private async void compareBtn_ClickAsync(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(sourceFolderInput.Text) || string.IsNullOrEmpty(targetFolderInput.Text) || !ToolMethod.IsValidFolderPath(sourceFolderInput.Text) || !ToolMethod.IsValidFolderPath(targetFolderInput.Text))
            {
                messageService.InternationalizationMessage("请选择有效的源文件夹和目标文件夹",null,"warn",window);
                return;
            }            
            try
            {
                outputInput.Clear();
                progressBar.Visible = true;
                progressBar.Value = 0;
                compareBtn.Loading = true;
                compareBtn.Enabled = false;
                List<string> missingFiles = await CompareFoldersAsync(sourceFolderInput.Text, targetFolderInput.Text);
                if (missingFiles.Count == 0)
                {
                    messageService.InternationalizationMessage("目标文件夹包含原始文件夹的所有文件", null, "success", window);
                    string language = AntdUI.Localization.CurrentLanguage;
                    outputInput.Text = "目标文件夹包含原始文件夹的所有文件";
                    if (!language.StartsWith("zh"))
                    {
                        outputInput.Clear();
                        var provider = new message_localizer();
                        outputInput.Text = provider.GetLocalizedString("目标文件夹包含原始文件夹的所有文件");
                    }
                }
                else {
                    outputInput.Text = string.Join(Environment.NewLine, missingFiles);
                }
                compareBtn.Loading = false;
                compareBtn.Enabled = true;
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
                List<string> missingFiles = new List<string>();
                if (musicTitleCheckBox.Checked) {
                    var targetMusicTitles = new List<string>();
                    var targetNonMusicFiles = new List<string>();
                    foreach (var targetFile in targetFiles)
                    {
                        if (ToolMethod.IsMusicFile(targetFile))
                        {
                            try
                            {
                                using (var file = TagLib.File.Create(targetFile))
                                {
                                    if (!string.IsNullOrEmpty(file.Tag.Title))
                                    {
                                        targetMusicTitles.Add(file.Tag.Title);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                messageService.InternationalizationMessage("读取音乐文件时发生错误:", ex.Message, "error", window);
                            }
                        }
                        else
                        {
                            targetNonMusicFiles.Add(targetFile);
                        }
                    }
                    int sourceFileCount = sourceFiles.Count;
                    for (int i = 0; i < sourceFileCount; i++)
                    {
                        var sourceFile = sourceFiles[i];
                        if (ToolMethod.IsMusicFile(sourceFile))
                        {
                            try
                            {
                                using (var file = TagLib.File.Create(sourceFile))
                                {
                                    if (!string.IsNullOrEmpty(file.Tag.Title) && !targetMusicTitles.Contains(file.Tag.Title))
                                    {
                                        missingFiles.Add(sourceFile);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                messageService.InternationalizationMessage("读取音乐文件时发生错误:", ex.Message, "error", window);
                            }
                        }
                        else if (hashCheckBox.Checked)
                        {
                            var sourceFileHash = ToolMethod.CalculateFileHash(sourceFile, "MD5");
                            var targetFileHashes = targetNonMusicFiles.Select(f => ToolMethod.CalculateFileHash(f,"MD5")).ToList();
                            if (!targetFileHashes.Contains(sourceFileHash))
                            {
                                missingFiles.Add(sourceFile);
                            }
                        }
                        else
                        {
                            if (!targetNonMusicFiles.Contains(sourceFile, StringComparer.OrdinalIgnoreCase))
                            {
                                missingFiles.Add(sourceFile);
                            }
                        }
                        progressBar.Value =(float)(i + 1) / sourceFileCount;
                    }
                    return missingFiles;
                }
                else if(hashCheckBox.Checked)
                {
                    var targetFileHashes = new Dictionary<string, string>();
                    int targetFileCount = targetFiles.Count;
                     int sourceFileCount = sourceFiles.Count;
                    for (int i = 0; i < targetFileCount; i++)
                    {
                        var targetFile = targetFiles[i];
                        try
                        {
                            targetFileHashes[targetFile] = ToolMethod.CalculateFileHash(targetFile, "MD5");
                        }
                        catch (Exception ex)
                        {
                            messageService.InternationalizationMessage("计算文件哈希值时发生错误:", ex.Message, "error", window);
                        }
                        progressBar.Value = ((float)(i+1) / (targetFileCount + sourceFileCount));
                    }
                    
                    missingFiles = new List<string>();                   
                    for (int i = 0; i < sourceFileCount; i++)
                    {
                        var sourceFile = sourceFiles[i];
                        try
                        {
                            var sourceFileHash = ToolMethod.CalculateFileHash(sourceFile, "MD5");
                            if (!targetFileHashes.Values.Contains(sourceFileHash))
                            {
                                missingFiles.Add(sourceFile);
                            }
                        }
                        catch (Exception ex)
                        {
                            messageService.InternationalizationMessage("计算文件哈希值时发生错误:", ex.Message, "error", window);
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
                        float progress = (float)(i + 1) / fileCount;
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
                messageService.InternationalizationMessage("读取文件夹时发生错误:", ex.Message, "error", window);
            }
            return files;
        }        
    }
}
