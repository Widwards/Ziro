using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Data.Common;

namespace _testSQLiteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseName = "CompanyWorkers.db3";

            SQLiteConnection.CreateFile(baseName);


            Connection(baseName);
            //VarintConnection(baseName);
        }

        private static void VarintConnection(string baseName)
        {
            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                connection.ConnectionString = "Data Source = " + baseName;
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"CREATE TABLE [workers] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [name] char(100) NOT NULL,
                    [family] char(100) NOT NULL,
                    [age] int NOT NULL,
                    [profession] char(100) NOT NULL
                    );";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void Connection(string baseName)
        {
            SQLiteConnection connection = new SQLiteConnection();
            connection.ConnectionString = "Data Source = " + baseName;
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = @"CREATE TABLE [workers] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [name] char(100) NOT NULL,
                    [family] char(100) NOT NULL,
                    [age] int NOT NULL,
                    [profession] char(100) NOT NULL
                    );";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
        }



    }
}
