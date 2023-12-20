using WinFormsApp;

namespace hotel_management
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var openConnection = DB_Connection.Initialize();
            if(openConnection)
            {
                Login login = new Login();
                login.StartPosition = FormStartPosition.CenterScreen;
                Application.Run( login);
            }

            DB_Connection.CloseConnection();

        }
    }
}
