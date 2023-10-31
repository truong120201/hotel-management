using Npgsql;
using System.Runtime.CompilerServices;

namespace WinFormsApp
{
    public static class DB_Connection
    {
        private static NpgsqlConnection _connection;

        public static bool Initialize()
        {
            string host = "localhost";
            string username = "postgres";
            string password = "truong";
            string database = "hotel_management";
            string connString = $"Host={host};Username={username};Password={password};Database={database}";
            _connection = new NpgsqlConnection(connString);
            var openConnection = OpenConnection();
            return openConnection;
        }

        public static bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Failed to establish a connection to the database.");
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Failed to shut down connection to the database.");
                return false;
            }
        }

        public static NpgsqlDataReader ExecuteQuery(string query)
        {
            using var cmd = new NpgsqlCommand(query, _connection);
            return cmd.ExecuteReader();
        }

        public static NpgsqlDataReader ExecuteParameterizedQuery(string query, Dictionary<string, string> parameters)
        {
            using var command = new NpgsqlCommand(query, _connection);
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
            return command.ExecuteReader();
        }
    }
}
