using LittleFancyTool.Models;

namespace LittleFancyTool.View.SubView
{
    public partial class SlaveTableEdit : UserControl
    {
        private AntdUI.Window window;
        private SlaveTable slaveTable;
        public bool submit;
        public SlaveTableEdit(AntdUI.Window _window, SlaveTable _slaveTable)
        {
            window = _window;
            slaveTable = _slaveTable;
            InitializeComponent();
            InitData();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_ok.Click += Button_ok_Click;
            button_cancel.Click += Button_cancel_Click;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            submit = false;
            this.Dispose();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            slaveTable.address = input_addr.Text;
            slaveTable.valueDec = input_value.Text;
            submit = true;
            this.Dispose();
        }

        private void InitData()
        {
            input_addr.Text = slaveTable.address;
            input_value.Text = slaveTable.valueDec;
        }
    }
}
