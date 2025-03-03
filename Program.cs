namespace CryptoTool
{
    internal static class Program
    {
        private static MainForm mainForm = new MainForm();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            AntdUI.Localization.DefaultLanguage = "zh-CN";
            //�����ֲ��������л�������Ⱦ��ʽ
            AntdUI.Config.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            AntdUI.Config.SetCorrectionTextRendering("Microsoft YaHei UI");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ApplicationConfiguration.Initialize();
            
            Application.Run(mainForm);
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            AntdUI.Notification.error(mainForm, "δ�����UI�߳��쳣", e.Exception.Message, autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }

        // �����UI�߳��е�δ�����쳣
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            AntdUI.Notification.error(mainForm, "δ����ķ�UI�߳��쳣", e.ToString(), autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }

        //private static void ShowErrorDialog(Exception ex)
        //{
        //    string errorMessage = $"��������{ex.Message}\n\n��ջ���٣�{ex.StackTrace}";
        //    MessageBox.Show(errorMessage, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
    }
}