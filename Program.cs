
using hrms_client.Views;
using hrms_query.Models;
using hrms_query.Repositories;
using hrms_client.Views;
using hrms_client.Presenters;
using DotNetEnv;
using hrms_query;
using MySql.Data.MySqlClient;
using hrms_query.Database;
using hrms_client.Views.Interface;
using hrms_query.Session;
using hrms_client.Views.Dashboard;
using hrms_client.Testing;
using hrms_client.Presenters.Interface;





namespace hrms_client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        private static MyAppContext _appContext;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            IDbManager dbManager = new MySqlConnectionManager();
            if (!dbManager.testConnection())
            {
                MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            _appContext = new MyAppContext(null); // Temp null
            IMainView mainView = new MainView(dbManager);
            
            Form loginView = mainView.ShowLoginView();
            loginView.Show();
            Application.Run();




        }


        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            // Clear the session data when the application exits
            //MessageBox.Show("Application is closing", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UserSession.ClearSession();
            MessageBox.Show("Application is closing", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}