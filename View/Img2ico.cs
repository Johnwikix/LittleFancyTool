using LittleFancyTool.Service;
using LittleFancyTool.Service.Impl;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace LittleFancyTool.View
{
    public partial class Img2ico : UserControl
    {
        private AntdUI.Window window;
        private IMessageService messageService = new MessageService();
        private Icon generatedIcon;

        public Img2ico(AntdUI.Window _window)
        {
            this.window = _window;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            InitializeComponent();
        }

        private Size resizeImg(string size)
        {
            switch (size)
            {
                case "16x16":
                    return new Size(16, 16);
                case "24x24":
                    return new Size(24, 24);
                case "32x32":
                    return new Size(32, 32);
                case "48x48":
                    return new Size(48, 48);
                case "64x64":
                    return new Size(64, 64);
                case "96x96":
                    return new Size(96, 96);
                case "128x128":
                    return new Size(128, 128);
                case "192x192":
                    return new Size(192, 192);
                case "256x256":
                    return new Size(256, 256);
                default:
                    return new Size(32, 32);
            }
        }

        private void picUploadDragger_Click(object sender, AntdUI.StringsEventArgs e)
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
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = pictureBox.Image;
                if (image == null)
                {
                    messageService.InternationalizationMessage("请先选择图片！", null, "warning", window);
                    return;
                }
                Size newSize = resizeImg(sizeSelect.SelectedValue.ToString());
                //Bitmap resizedBitmap = new Bitmap(image, newSize);
                Bitmap resizedBitmap = new Bitmap(newSize.Width, newSize.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(resizedBitmap))
                {
                    g.Clear(Color.Transparent);
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(image, 0, 0, newSize.Width, newSize.Height);
                }
                if (generatedIcon != null)
                {
                    generatedIcon.Dispose();
                }
                IIconService iconService = new IconService();
                generatedIcon = iconService.CreateIconFromBitmap(resizedBitmap);
                icoBox.Image?.Dispose();
                icoBox.Image = resizedBitmap;
                messageService.InternationalizationMessage("转换成功！", null, "success", window);
            }
            catch (Exception ex)
            {
                messageService.InternationalizationMessage("转换失败：", ex.Message, "error", window);
            }
        }

        private void saveIcoBtn_Click(object sender, EventArgs e)
        {
            if (icoBox.Image != null)
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Windows 图标文件 (*.ico)|*.ico";
                    saveDialog.DefaultExt = "ico";
                    saveDialog.Title = "保存图标文件";
                    saveDialog.OverwritePrompt = true;
                    saveDialog.FileName = "output_ico";
                    if (saveDialog.ShowDialog(window) == DialogResult.OK)
                    {
                        Task.Run(() =>
                        {
                            using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                            {
                                generatedIcon.Save(fs);
                            }
                        });
                        messageService.InternationalizationMessage(
                            "图标已保存至：",
                            saveDialog.FileName,
                            "success",
                            window
                        );
                    }
                }
            }
            else
            {
                messageService.InternationalizationMessage("没有ico可供保存", null, "warn", window);
            }

        }
    }
}
