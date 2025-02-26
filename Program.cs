namespace CryptoTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ApplicationConfiguration.Initialize();
            // ���� UI �߳��쳣
            Application.ThreadException += Application_ThreadException;
            // ����� UI �߳��쳣
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.Run(new MainForm());
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ShowErrorDialog(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;
            if (exception != null)
            {
                ShowErrorDialog(exception);
            }
        }

        private static void ShowErrorDialog(Exception ex)
        {
            string errorMessage = $"��������{ex.Message}\n\n��ջ���٣�{ex.StackTrace}";
            MessageBox.Show(errorMessage, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}