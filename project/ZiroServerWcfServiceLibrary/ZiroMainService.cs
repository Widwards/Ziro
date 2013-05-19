using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace ZiroServerWcfServiceLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class ZiroMainService : IZiroService
    {
        /*TOD:!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
         * Этот объект создается каждый раз при вызове методов!!!!!!!!!!!!!!!!!!!!!!!
         * StackOfNode всегда будет ОДИН!!!!!!!!!!!!!!!
         */ 
        public List<StatObject> StackOfNode = new List<StatObject>();

        //public float CurrentCpuUsage { get; set; }
        //public float CurrentFreeMemory { get; set; }

        public ZiroMainService()
        {
            //Инициализация базы при первом запуске или удалении файла базы
            if (!File.Exists("ZiroDB.db3"))
            {
                Console.WriteLine("Initialize application");
                ZiroBaseDAL dal = new ZiroBaseDAL();
                dal.CreateBase();
            }
            //Console.WriteLine("Ziro Service created \t [OK] {0}", StackOfNode.Count);
        }

        /// <summary>
        /// ЗАГЛУШКА
        /// </summary>
        /// <returns></returns>
        public int GetDefaultOptions()
        {
            throw new NotImplementedException();
        }

        public List<ZiroAgentRecord> GetLastRecords(int numbersOfRecord)
        {
            using (ZiroBaseDAL dal = new ZiroBaseDAL())
            {
                dal.OpenConnection();
                return dal.GetZiroLastDataRecords(numbersOfRecord);
            }
            
        }

        //TODO: возвращать List<ZiroAgentRecord> моложе определенной даты:
        // к примеру лист со всемидобавлениями в базу за последние 10 секунд
        //public void GetNewPoolList

        public void UpdateConsole(int idAgent, int cpuUsage, int freeMemory)
        {
            using (ZiroBaseDAL dal = new ZiroBaseDAL())
            {
                dal.OpenConnection();

                dal.InsertZiroDataRecord(new ZiroAgentRecord { IdAgent = idAgent,
                                                                    CpuUsage = cpuUsage,
                                                                    FreeMemory = freeMemory});
            }
            //Console.Clear();
            //Console.WriteLine("{0}\tCPU:{1}\tMEMORY11:{2}", idAgent, cpuUsage, freeMemory);
        }

        public void Update(int idAgent, int cpuUsage, int freeMemory)
        {
            using (ZiroBaseDAL dal = new ZiroBaseDAL())
            {
                dal.OpenConnection();

                dal.InsertZiroDataRecord(new ZiroAgentRecord
                {
                    IdAgent = idAgent,
                    CpuUsage = cpuUsage,
                    FreeMemory = freeMemory
                });
            }
            //Console.Clear();
            //bool objectChanged = false;
            //if (StackOfNode!=null)
            //{
            //    foreach (StatObject stat in StackOfNode)
            //    {
            //        if (stat.Id == idAgent)
            //        {
            //            stat.Update(cpuUsage, freeMemory);
            //            objectChanged = true;
                        
            //        }
            //    }
            //}
            

            //if (!objectChanged)
            //{
            //    StackOfNode.Add(new StatObject { Id = idAgent, CurrentCpuUsage = cpuUsage, CurrentFreeMemory = freeMemory});
            //}
            //Console.WriteLine("{0} updated", idAgent);
        }

        public void PushCurrentCpuUsage(int idAgent, int cpuUsage)
        {
            bool objectChanged = false;
            if (StackOfNode!=null)
            {
                foreach (StatObject stat in StackOfNode)
                {
                    if (stat.Id == idAgent)
                    {
                        stat.CurrentCpuUsage = cpuUsage;
                        stat.Update();
                        objectChanged = true;
                        break;
                    }
                }
            }
            

            if (!objectChanged)
            {
                StackOfNode.Add(new StatObject {Id = idAgent, CurrentCpuUsage = cpuUsage });
            }
        }

        public void PushCurrentFreeMemory(int idAgent, int freeMemory)
        {
            bool objectChanged = false;
            if (StackOfNode!=null)
            {
                foreach (StatObject stat in StackOfNode)
                {
                    if (stat.Id == idAgent)
                    {
                        stat.CurrentFreeMemory = freeMemory;
                        stat.Update();
                        objectChanged = true;
                        break;
                    }
                }
            }

            if (!objectChanged)
            {
                StackOfNode.Add(new StatObject { Id = idAgent, CurrentFreeMemory = freeMemory });
            }
            
        }
    }

    public class StatObject
    {
        private List<float> cpuUsage = new List<float>();
        private List<float> freeMemory = new List<float>();
        private int countToDisconnet = 0;

        public int CounterToDisconnect { get; set; }

        public bool IsConnected { get; set; }
        
        public int Id { get; set; }
        public float CurrentCpuUsage { 
            get 
            { 
                return cpuUsage.LastOrDefault(); 
            }
            set
            {
                
                cpuUsage.Add(value);
                countToDisconnet = 0;
                if (!IsConnected)
                {
                    IsConnected = true;
                }
            }
        }
        public float CurrentFreeMemory {
            get
            {
                return freeMemory.LastOrDefault();
            }
            set
            {
                freeMemory.Add(value);
                countToDisconnet = 0;
                if (!IsConnected)
                {
                    IsConnected = true;
                }
            }
        }

        public StatObject() 
        {
            CounterToDisconnect = 10;
            countToDisconnet = 0;
            IsConnected = true;

        }

        public void Update(float currentCpuUsage, float currentFreeMemory)
        {
            this.CurrentCpuUsage = currentCpuUsage;
            this.CurrentFreeMemory = currentFreeMemory;
            if (!IsConnected)
            {
                IsConnected = true;
            }
            countToDisconnet = 0;
        }

        public StatObject(int id, float currentCpuUsage, float currentFreeMemory)
        {
            CounterToDisconnect = 10;
            this.Id = id;
            this.CurrentCpuUsage = currentCpuUsage;
            this.CurrentFreeMemory = currentCpuUsage;
            IsConnected = true;
            countToDisconnet = 0;
        }

        public void Update()
        {
            countToDisconnet++;
            if (countToDisconnet==CounterToDisconnect)
            {
                IsConnected = false;
            }
        }

    }
}