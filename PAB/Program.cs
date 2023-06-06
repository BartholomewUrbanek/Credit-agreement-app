using PAB.LoginScreen;
using PAB.MainWindow;
using PAB.MainWindow.Customer;

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
            string connectionString = "Server=DESKTOP-C9F8288;Database=Docu_v2;Integrated Security=True;Encrypt=False;";
            ILoginDAO loginDAO = new LoginDAO(connectionString);
            IDocumentationList displayTable = new DocumentationList(connectionString);
            ICustomer customer = new Customer(connectionString);
            GeneralMenu generalMenu = new GeneralMenu(displayTable,customer);
            Application.Run(new Login(loginDAO,generalMenu));
        }
    }
}