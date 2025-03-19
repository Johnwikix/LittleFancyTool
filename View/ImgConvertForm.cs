using LittleFancyTool.Service.Impl;
using LittleFancyTool.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LittleFancyTool.Utils;
using System.Diagnostics;

namespace LittleFancyTool.View
{
    public partial class ImgConvertForm: UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        private string extension;
        public ImgConvertForm(AntdUI.Window _window)
        {
            this.window = _window;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            InitializeComponent();
        }        

        private void picUploadDragger_Click(object sender, AntdUI.StringsEventArgs e)
        {
            string[] filePaths = e.Value;
            extension = System.IO.Path.GetExtension(filePaths[0]);
            Task.Run(() =>
            {
                    Image originalImage = Image.FromFile(filePaths[0]);
                    pictureBox.Invoke((MethodInvoker)delegate
                    {
                        if (pictureBox.Image != null)
                        {
                            pictureBox.Image.Dispose();
                        }
                        pictureBox.Image = originalImage;
                    });
                
            });
        }

        private void saveIcoBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "所有图片文件|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.webp;*.tiff;*.heif";
                    saveDialog.DefaultExt = formatSelect.SelectedValue.ToString();
                    saveDialog.Title = "保存图片";
                    saveDialog.OverwritePrompt = true;
                    saveDialog.FileName = "output_img";
                    ImageFormat outputFormat = ToolMethod.Format(formatSelect.SelectedValue.ToString());
                    if (saveDialog.ShowDialog(window) == DialogResult.OK)
                    {
                        Task.Run(() =>
                        {
                            if (extension != ".gif" || outputFormat != ImageFormat.Gif)
                            {
                                using (Image imageToSave = new Bitmap(pictureBox.Image))
                                {
                                    imageToSave.Save(saveDialog.FileName, outputFormat);
                                    messageService.InternationalizationMessage("图片已保存至：",
                                            saveDialog.FileName,
                                            "success",
                                            window
                                    );
                                }
                            }
                            else
                            {
                                pictureBox.Image.Save(saveDialog.FileName, outputFormat);
                                messageService.InternationalizationMessage("图片已保存至：",
                                        saveDialog.FileName,
                                        "success",
                                        window
                                );
                            }

                        });
                    }
                }
            }
            else
            {
                messageService.InternationalizationMessage("没有图片可供保存", null, "warn", window);
            }
        }
    }
}
