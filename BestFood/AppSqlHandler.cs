using System.Data;
using System.Data.SqlClient;

namespace BestFood
{
    internal static class AppSqlHandler
    {
        public static string connectionString = "Data Source=AEK\\SQLEXPRESS;User ID=sa;Password=12345;database=bestfood;Connect Timeout=30;Encrypt=False;";

        // Method to connect to the database
        private static SqlConnection Connect()
        {
            /*
            try
            {
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();
                    Console.WriteLine("Successfully connected to SQL Server");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error connecting to SQL Server: " + e.Message);
            }
            */

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connection opened successfully.");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error opening connection: " + e.Message);
                // Consider re-throwing the exception or handling it to notify the caller.
                throw;
            }
            return connection;
        }

        // Method to execute the current query and return the results in a DataTable
        public static DataTable QueryIntoDataTable(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new InvalidOperationException("Query is not set.");
            }

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connect())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error executing query: " + e.Message);
                    throw;
                }
            }
            return dataTable;
        }
    }
}
