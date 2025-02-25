using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTool.render
{
    public class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        private ToolStripMenuItem selectedMenuItem;

        public CustomMenuRenderer()
        {
            selectedMenuItem = null;
        }

        public void SetSelectedMenuItem(ToolStripMenuItem item)
        {
            selectedMenuItem = item;
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            bool isSelected = e.Item == selectedMenuItem || e.Item.Selected;
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
            if (isSelected)
            {
                using (SolidBrush brush = new SolidBrush(Color.LightBlue)) // 设置选中时的背景颜色
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
}
