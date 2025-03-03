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
            //若文字不清晰，切换其他渲染方式
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
            AntdUI.Notification.error(mainForm, "未处理的UI线程异常", e.Exception.Message, autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }

        // 捕获非UI线程中的未处理异常
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            AntdUI.Notification.error(mainForm, "未处理的非UI线程异常", e.ToString(), autoClose: 3, align: AntdUI.TAlignFrom.TR);
        }

        //private static void ShowErrorDialog(Exception ex)
        //{
        //    string errorMessage = $"发生错误：{ex.Message}\n\n堆栈跟踪：{ex.StackTrace}";
        //    MessageBox.Show(errorMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
    }
}