using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace WebFrameworksCA2
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void TestConnection()
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();
            Console.WriteLine("Connection successful!");
        }
    }
}