using LittleFancyTool.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View.SubView
{
    public partial class Wellcome : UserControl
    {
        private System.Windows.Forms.Timer rotationTimer;
        private float rotationAngle = 0;
        private Image originalImage;
        private SoundPlayer currentPlayer;
        public Wellcome()
        {
            InitializeComponent();
            originalImage = pictureBox1.Image;
            // 初始化 Timer 控件
            rotationTimer = new System.Windows.Forms.Timer();
            rotationTimer.Interval = 1000 / 16;
            rotationTimer.Tick += RotationTimer_Tick;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (rotationTimer.Enabled)
            {
                rotationTimer.Stop();
            }
            if (!rotationTimer.Enabled)
            {
                rotationTimer.Start();
            }
            if (ToolMethod.GetRandomBoolean(4))
            {
                playSound(Properties.Resources.short114);
            }
            else
            {
                if (ToolMethod.GetRandomBoolean(1))
                {
                    playSound(Properties.Resources.origin114);
                }
            }
        }

        private void playSound(byte[] sound) {
            if (currentPlayer != null)
            {
                currentPlayer.Stop();
                currentPlayer.Dispose();
            }
            using (MemoryStream memoryStream = new MemoryStream(sound))
            {
                currentPlayer = new SoundPlayer(memoryStream);
                currentPlayer.Play();
            }
        }

        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            // 增加旋转角度
            rotationAngle += 6;
            if (rotationAngle >= 360)
            {
                rotationAngle = 0;
            }
            // 计算缩放后的图像尺寸
            float scaleX = (float)pictureBox1.Width / originalImage.Width;
            float scaleY = (float)pictureBox1.Height / originalImage.Height;
            float scale = Math.Min(scaleX, scaleY);
            int scaledWidth = (int)(originalImage.Width * scale);
            int scaledHeight = (int)(originalImage.Height * scale);
            // 创建一个新的 Bitmap 对象，大小为 PictureBox 的大小
            Bitmap rotatedImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // 计算旋转中心（基于缩放后的图像）
                int centerX = pictureBox1.Width / 2;
                int centerY = pictureBox1.Height / 2;

                // 设置旋转中心
                g.TranslateTransform(centerX, centerY);
                // 旋转图形
                g.RotateTransform(rotationAngle);
                // 恢复变换
                g.TranslateTransform(-centerX, -centerY);

                // 计算绘制图像的位置（使图像居中）
                int x = (pictureBox1.Width - scaledWidth) / 2;
                int y = (pictureBox1.Height - scaledHeight) / 2;

                // 绘制缩放后的原始图像
                g.DrawImage(originalImage, x, y, scaledWidth, scaledHeight);
            }
            // 更新 PictureBox 的显示
            pictureBox1.Image = rotatedImage;
        }
    }
}
