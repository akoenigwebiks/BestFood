using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BestFood.DAL
{
    internal static class AppSqlHandler
    {
        private static readonly string connectionString = "Data Source=AEK;Initial Catalog=bestfood;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        // Method to connect to the database
        private static SqlConnection GetOpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Debug.WriteLine("Connection opened successfully.");
                return connection;
            }
            catch (SqlException e)
            {
                Debug.WriteLine("Error opening connection: " + e.Message);
                connection.Dispose(); // Dispose the connection if opening failed
                throw;
            }
        }

        // Method to execute a query and return results in a DataTable
        public static DataTable QueryIntoDataTable(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new InvalidOperationException("Query is not set.");
            }

            using (SqlConnection connection = GetOpenConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Error executing query: " + e.Message);
                    throw;
                }
            }
        }

        // Method to execute an insert/update/delete command
        public static bool ExecuteNonQuery(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new InvalidOperationException("Query is not set.");
            }

            using (SqlConnection connection = GetOpenConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if any rows were affected
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Error executing query: " + e.Message);
                    return false; // Return false if an exception occurred
                }
            }
        }
    }
}
