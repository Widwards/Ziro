using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Data.SQLite;
using System.Data;


namespace ZiroServerWcfServiceLibrary
{
    
    class ZiroBaseDAL: IDisposable
    {
        string baseName = "ZiroDB.db3";
        SQLiteConnection connection = null;
        //SQLiteFactory factory = null;

        public void CreateBase()
        {
            
            SQLiteConnection.CreateFile(baseName);
            Console.WriteLine("{0} File Created", baseName); //!

            OpenConnection();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText =   @"CREATE TABLE [monitorData] (
                                        [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                                        [agentid] integer NOT NULL,
                                        [date] integer NOT NULL,
                                        [cpu] real NOT NULL,
                                        [memory] real NOT NULL
                                        );";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }

            Console.WriteLine("[monitorData] tables is created"); //!

            CloseConnection();

        }

        //TODO: РЕАЛИЗОВАТЬ ВСТАВКУ ДАТЫ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public void InsertZiroDataRecord(ZiroAgentRecord record)
        {
            string sql = string.Format("Insert Into monitorData" +
                "(agentid, date, cpu, memory) Values" +
                "('{0}', '{1}', '{2}', '{3}')", record.IdAgent, 0, record.CpuUsage, record.FreeMemory);
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

        //TODO:
        public void DeleteZiroDataRecord(int recordId)
        {
            string sql = string.Format("Delete from monitorData where id = '{0}'", recordId);
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

        //TODO:
        public void DeleteZiroDataRecord(int agentId)
        {
        }

        //TODO:
        public void DeleZiroDataRecordOlderThenDate(int Date)
        {
        }

        public void OpenConnection()
        {

            connection = new SQLiteConnection();
            connection.ConnectionString = "Data Source = " + baseName;

            connection.Open();

            Console.WriteLine("{0} Connection is opened", baseName); //!
        }

        public void CloseConnection()
        {
            Console.WriteLine("Connection is closed"); //!
            connection.Close();
        }
    
public void Dispose()
{
 	CloseConnection();
}
}
}
