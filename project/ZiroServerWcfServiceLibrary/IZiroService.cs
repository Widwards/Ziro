using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ZiroServerWcfServiceLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract (Namespace="http://widwards.cloudapp.net")]
    public interface IZiroService
    {
        [OperationContract]
        int GetDefaultOptions();


        [OperationContract]
        void Update(int idAgent, int cpuUsage, int freeMemory);

        [OperationContract]
        void PushCurrentCpuUsage(int idAgent, int cpuUsage);

        [OperationContract]
        void PushCurrentFreeMemory(int idAgent, int freeMemory);

        [OperationContract]
        void UpdateConsole(int idAgent, int cpuUsage, int freeMemory);

        [OperationContract]
        List<ZiroAgentRecord> GetLastRecords(int numbersOfRecord);
        // TODO: Добавьте здесь операции служб
    }

    // Используйте контракт данных, как показано на следующем примере, чтобы добавить сложные типы к сервисным операциям.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "ZiroServerWcfServiceLibrary.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
