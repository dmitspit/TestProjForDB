using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;

namespace TestProjForDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionData = "server=localhost;user=root;database=helloappdb;password=12345678;";
            MySqlConnection connection = new MySqlConnection(connectionData);
            connection.Open();
            var metadata = new List<User>();

           

            string sql = "Select * from users";
            metadata = connection.Query<User>(sql).ToList();

            // MySqlCommand command = new MySqlCommand(sql, connection);
            // string name = command.ExecuteScalar().ToString();
            //MySqlDataReader dataReader = command.ExecuteReader();

            Console.WriteLine(metadata.First().Age);
            Console.Read();
            connection.Close();
        }
    }
}
