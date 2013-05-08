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

        private float currentCpuUsage;
        private float currentFreeMemory;


        //дефолтные настройки для клиента
        public int GetDefaultOptions()
        {
            throw new NotImplementedException();
        }

        //КЛИЕНТ:
        public void PushCurrentCpuUsage()
        {
            throw new NotImplementedException();
        }

        //КЛИЕНТ:
        public void PushCurrentFreeMemory()
        {
            throw new NotImplementedException();
        }

        //СЕРВЕР:
        public float GetCurrentCpuUsage()
        {
            throw new NotImplementedException();
        }

        //СЕРВЕР:
        public float GetCurrentFreeMemory()
        {
            throw new NotImplementedException();
        }
    }
}
