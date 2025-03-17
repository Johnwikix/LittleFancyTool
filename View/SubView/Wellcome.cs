using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View.SubView
{
    public partial class Wellcome : UserControl
    {
        private int count = 0;
        public Wellcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 3) {
                MessageBox.Show("114514");
                count = 0;
            }
        }
    }
}
