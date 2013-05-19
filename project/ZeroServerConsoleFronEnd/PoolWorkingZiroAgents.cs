using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Collections;
using ZiroServerWcfServiceLibrary;

namespace ZeroServerConsoleFronEnd
{
    class PoolWorkingZiroAgents
    {
        private int defaultDisconnectCounter = 500;
        private List<ZiroAgentRecord> PoolOfCoorectZiroAgentRecord = null;
        public List<ZiroAgentRecord> PoolOfZiro { get { return PoolOfCoorectZiroAgentRecord; } }
        

        public int DisconnectCounter { get; set; }

        public PoolWorkingZiroAgents()
        {
            PoolOfCoorectZiroAgentRecord = new List<ZiroAgentRecord>();
            DisconnectCounter = defaultDisconnectCounter;
        }

        public List<ZiroAgentRecord> GetActualAgentList()
        {
            return PoolOfZiro;
        }



    }
}
