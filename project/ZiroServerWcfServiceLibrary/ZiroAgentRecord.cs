using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ZiroServerWcfServiceLibrary
{
    [DataContract]
    public class ZiroAgentRecord
    {
        [DataMember]
        public int idRecords { get; set; }

        [DataMember]
        public int IdAgent { get; set; }

        [DataMember]
        public int CpuUsage { get; set; }

        [DataMember]
        public int FreeMemory { get; set; }
    }
}
