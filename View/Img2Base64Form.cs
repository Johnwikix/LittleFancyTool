using AntdUI;
using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View
{
    public partial class Img2Base64Form : UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        public Img2Base64Form(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
        }

        private async void encryptBtn_Click(object sender, EventArgs e)
        {
            encryptBtn.Loading = true;
            if (pictureBox.Image != null)
            {
                await pic2base64();
                encryptBtn.Loading = false;
            }
            else
            {
                encryptBtn.Loading = false;
                messageService.InternationalizationMessage("请先选择一张图片", null, "warn", window);
            }
        }

        private Task pic2base64()
        {
            return Task.Run(() =>{
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    outputTextBox.Text = base64String;
                }
            });
        }

        private Task base64toPic()
        {
            return Task.Run(() => {
                byte[] imageBytes = Convert.FromBase64String(outputTextBox.Text);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image img = Image.FromStream(ms, true);
                    if (pictureBox.InvokeRequired)
                    {
                   
                        Debug.WriteLine("InvokeRequired");
                        pictureBox.BeginInvoke(new Action(() => pictureBox.Image = img));
                    }
                    else
                    {
                        Debug.WriteLine("InvokeNotRequired");
                        pictureBox.Image = img;
                    }
                }
            });
        }

        private async void decryptBtn_Click(object sender, EventArgs e)
        {
            decryptBtn.Loading = true;
            if (!string.IsNullOrEmpty(outputTextBox.Text))
            {
                try
                {
                    await base64toPic();
                    decryptBtn.Loading = false;
                }
                catch (FormatException ex)
                {
                    decryptBtn.Loading = false;
                    messageService.InternationalizationMessage("输入的Base64字符串格式不正确:", ex.Message, "error", window);
                }
            }
            else
            {
                decryptBtn.Loading = false;
                messageService.InternationalizationMessage("请先输入Base64字符串", null, "warn", window);
            }
        }
        private void UploadDragger_DragChanged(object sender, AntdUI.StringsEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            string[] filePaths = e.Value;
            Task.Run(() =>
            {
                Image image = Image.FromFile(filePaths[0]);
                pictureBox.Invoke((MethodInvoker)delegate
                {
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                    }
                    pictureBox.Image = image;
                });
            });
            Debug.WriteLine("DragChanged耗时: " + (DateTime.Now - startTime).TotalMilliseconds);
        }

        private void downloadPicBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = "base64ToImg",
                };
                saveFileDialog.Filter = "PNG 图片|*.png|GIF 图片|*.gif|JPEG 图片|*.jpg;*.jpeg";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox.Image.Save(saveFileDialog.FileName);
                        messageService.InternationalizationMessage("图片保存成功", null, "success", window);
                    }
                    catch (Exception ex)
                    {
                        messageService.InternationalizationMessage("保存图片时出错:", ex.Message, "error", window);
                    }
                }
            }
            else
            {
                messageService.InternationalizationMessage("没有图片可供保存", null, "warn", window);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            string s;
            s = " my bad ";
            string[] c = s.Split(" ");
            Debug.WriteLine(c);
            c.Reverse();
            Regex.Replace(s, @"\s+", " ");
            Debug.WriteLine(String.Join(" ", c));
            if (pictureBox.Image != null)
            {
                IList<Image> images = new List<Image>();
                images.Add(pictureBox.Image);
                Preview.open(new Preview.Config(window, images));
            }
            else
            {
                messageService.InternationalizationMessage("没有图片可供预览", null, "warn", window);
            }
        }
    }
}
