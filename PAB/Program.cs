using PAB.LoginScreen;
using PAB.MainWindow;

namespace PAB
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
            string connectionString = "Server=DESKTOP-C9F8288;Database=PADB;Integrated Security=True;Encrypt=False;";
            ILoginDAO loginDAO = new LoginDAO(connectionString);
            IDocumentationList displayTable = new DocumentationList(connectionString);
            GeneralMenu generalMenu = new GeneralMenu(displayTable);
            Application.Run(new Login(loginDAO,generalMenu));
        }
    }
}