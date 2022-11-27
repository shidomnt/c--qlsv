namespace QLSV
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
            ApplicationConfiguration.Initialize();
            Application.Run(new QLTTSV(new Controllers.SinhVienController(Database.GetDB())));
        }

        static public void ShowError(Exception ex, string title = "Loi khong xac dinh")
        {
            MessageBox.Show(
                        ex.Message,
                        title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
        }
        static public void ShowInfomation(string message, string title = "Thong bao")
        {
            MessageBox.Show(
                        message,
                        title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
        }
    }
}