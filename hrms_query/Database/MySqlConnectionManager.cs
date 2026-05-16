using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;


namespace hrms_query.Database
{
    public class MySqlConnectionManager : IDbManager
    {
        private readonly string _connectionString;

        public MySqlConnectionManager()
        {

            try
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Ensures correct path
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

                Console.WriteLine("Config loaded successfully!");

                _connectionString = config.GetConnectionString("DefaultConnection");
            }
            catch (Exception ex) { 
                Console.WriteLine("Config loaded Unsuccessfully!");
            }
            // Load environment variables
            //Env.Load();

            // Retrieve connection string from environment variables
            //_connectionString = $"server={Env.GetString("SERVER")};" +
            //                    $"port={Env.GetString("PORT")};" +
            //                    $"database={Env.GetString("DATABASE")};" +
            //                    $"uid={Env.GetString("USER")};" +
            //                    $"pwd={Env.GetString("PASSWORD")};";

            ////_connectionString = $"server=localhost;" +
            ////        $"port=3306;" +
            ////        $"database= ;" +
            ////        $"uid=root;" +
            ////        $"pwd= ;";


            //string server = Env.GetString("SERVER");
            //string port = Env.GetString("PORT");
            //string database = Env.GetString("DATABASE");
            //string user = Env.GetString("USER");
            //string password = Env.GetString("PASSWORD");

            //if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            //{
            //    Console.Write("One or more environment variables are not loaded correctly.");
            //}

        }


        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public bool testConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database connection failed!");
                return false;
            }
        }
    }
}
