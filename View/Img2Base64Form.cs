using AntdUI;
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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View
{
    public partial class Img2Base64Form : UserControl
    {
        private AntdUI.Window window;
        public Img2Base64Form(AntdUI.Window _window)
        {
            this.window = _window;
            InitializeComponent();
        }

        private async void encryptBtn_Click(object sender, EventArgs e)
        {
            encryptBtn.Loading = true;
            //Image selectedImage = pictureBox.Image;
            if (pictureBox.Image != null)
            {
                await pic2base64();
                encryptBtn.Loading = false;
            }
            else
            {
                AntdUI.Message.warn(window, "请先选择一张图片。", autoClose: 3);
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
                    Image image = Image.FromStream(ms, true);
                    pictureBox.Image = Image.FromStream(ms);
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
                    AntdUI.Message.error(window, $"输入的 Base64 字符串格式不正确:{ex.Message}", autoClose: 3);
                }
            }
            else
            {
                AntdUI.Message.warn(window, "请先输入 Base64 字符串。", autoClose: 3);
            }
        }
        private void UploadDragger_DragChanged(object sender, AntdUI.StringsEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            string[] filePaths = e.Value;
            Task task = new Task(() =>
            {
                pictureBox.Image = Image.FromFile(filePaths[0]);
            });
            task.Start();
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
                        AntdUI.Message.success(window, "图片保存成功。", autoClose: 3);
                    }
                    catch (Exception ex)
                    {
                        AntdUI.Message.error(window, $"保存图片时出错: {ex.Message}", autoClose: 3);
                    }
                }
            }
            else
            {
                AntdUI.Message.warn(window, "没有图片可供保存。", autoClose: 3);
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
                AntdUI.Message.warn(window, "没有图片可以预览。", autoClose: 3);
            }
        }
    }
}
