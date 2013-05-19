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
                                        [date] string NOT NULL,
                                        [cpu] integer NOT NULL,
                                        [memory] integer NOT NULL
                                        );";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }

            Console.WriteLine("[monitorData] tables is created"); //!

            CloseConnection();

        }

        private string DateTimeSQLite(DateTime datetime)
        {
            return string.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}", datetime.Year, datetime.Month, datetime.Day, 
                                                                datetime.Hour, datetime.Minute, datetime.Second, 
                                                                datetime.Millisecond);
        }
        //TODO: РЕАЛИЗОВАТЬ ВСТАВКУ ДАТЫ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public void InsertZiroDataRecord(ZiroAgentRecord record)
        {
            string sql = string.Format("Insert Into monitorData" +
                "(agentid, date, cpu, memory) Values" +
                "('{0}', '{1}', '{2}', '{3}')", record.IdAgent, DateTimeSQLite(DateTime.Now), record.CpuUsage, record.FreeMemory);
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NumbersOfRecod">количество возвращаемых записей</param>
        /// <returns></returns>
        public List<ZiroAgentRecord> GetZiroLastDataRecords(int numbersOfRecod)
        {
        //    DateTime oldTime = DateTime.Now;
        //    oldTime.Subtract(new TimeSpan(0, 0, NumbersOfRecod));
            List<ZiroAgentRecord> records = new List<ZiroAgentRecord>();
            
            string sql = string.Format("select * from monitorData " +
                "where id > MAX(id)", numbersOfRecod); //MAX(ID) не верно
            using (SQLiteCommand command= new SQLiteCommand(connection))
            {

                command.CommandText = sql;
                SQLiteDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    records.Add(new ZiroAgentRecord
                    {
                        idRecords = reader.GetInt32(0),
                        IdAgent = reader.GetInt32(1),
                        FreeMemory = reader.GetInt32(3),
                        CpuUsage = reader.GetInt32(4)
                        //FreeMemory = reader.GetFloat(reader.GetOrdinal("memory")),
                        //CpuUsage = reader.GetFloat(reader.GetOrdinal("cpu")),
                    
                    });
                }
                return records;
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
        //public void DeleteZiroDataRecord(int agentId)
        //{
        //}

        //TODO:
        public void DeleteZiroDataRecordOlderThenDate(int Date)
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
