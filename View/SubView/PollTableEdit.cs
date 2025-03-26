using LittleFancyTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFancyTool.View.SubView
{
    public partial class PollTableEdit : Form
    {
        private AntdUI.Window window;
        private PollTable pollTable;
        private bool isCoils;
        public bool submit;
        public PollTableEdit(AntdUI.Window _window, PollTable _pollTable,bool _isCoils)
        {
            window = _window;
            pollTable = _pollTable;
            isCoils = _isCoils;
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            inputAddr.Text = pollTable.address;
            inputValue.Text = pollTable.valueDec;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (isCoils) {
                if (int.Parse(inputValue.Text) > 1) {
                    inputValue.Text = "1";
                    pollTable.valueDec = "1";
                    submit = true;
                    this.Dispose();
                    return;
                }
            }
            pollTable.address = inputAddr.Text;
            pollTable.valueDec = inputValue.Text;
            submit = true;
            this.Dispose();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            submit = false;
            this.Dispose();
        }
    }
}
