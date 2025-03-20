using LittleFancyTool.Algorithms;
using LittleFancyTool.Algorithms.Encryption;

namespace LittleFancyTool.View
{
    public partial class SHAForm : UserControl
    {
        private AntdUI.Window window;
        public SHAForm(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            mode.SelectedIndex = 0;
            upperLowerCase.SelectedIndex = 0;
        }
        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string? algMode = mode.SelectedValue?.ToString();
            string? upperLowerCaseStr = upperLowerCase.SelectedValue?.ToString();
            try
            {
                IEncryptionAbstract encryptionAlgorithm = new SHAEncrpytion();
                string encryptedText = encryptionAlgorithm.Encrypt(input, upperLowerCaseStr, 0, algMode);
                outputTextBox.Text = encryptedText;
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(window, ex.Message, autoClose: 3);
            }
        }
    }
}
