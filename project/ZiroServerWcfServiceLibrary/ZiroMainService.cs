using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace ZiroServerWcfServiceLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class ZiroMainService : IZiroService
    {

        public float currentCpuUsage { get; set; }
        public float currentFreeMemory { get; set; }


        /// <summary>
        /// ЗАГЛУШКА
        /// </summary>
        /// <returns></returns>
        public int GetDefaultOptions()
        {
            throw new NotImplementedException();
        }

        
        public void PushCurrentCpuUsage(int idAgent, float cpuUsage)
        {
            this.currentCpuUsage = cpuUsage;
        }

        public void PushCurrentFreeMemory(int idAgent, float freeMemory)
        {
            this.currentFreeMemory = freeMemory;
        }
    }
}
