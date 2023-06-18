using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Utils;

namespace Database
{
    public class ConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            string cnn = "connectionDB";

            var settings = ConfigHelper.GetConfig();
            var connectionString = settings.GetConnectionString(cnn);
            var connection = new SqlConnection(connectionString);


            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            connection.Dispose();
            connection.Close();
        }

    }
}
