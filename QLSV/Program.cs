
using QLSV.EF.Contexts;

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
            var databaseContext = new QlsvContext();
            try
            {
                Application.Run(new QLTTSV(databaseContext));
            } catch (Exception ex)
            {
                ShowError(ex);
            }
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