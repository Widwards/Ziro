using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ZiroDesktopAgentLibrary;
using ZiroDesktopConsoleAgent.ServiceReference1;

namespace ZiroDesktopConsoleAgent
{
    /// <summary>
    /// Тестовый консольный агент Ziro
    /// </summary>
    class ZiroDesktopAgent
    {
        
        static void Main(string[] args)
        {

            int idAgent;
            Console.WriteLine("Agent is running...");
            ZiroDesktopAgentProvider agentProvider = new ZiroDesktopAgentProvider();
            agentProvider.LoadIdAgentConfiguration();
            idAgent = agentProvider.idAgent;
            Console.WriteLine("Agent ID: {0}", agentProvider.idAgent);

            using (ZiroServiceClient ziroService = new ZiroServiceClient())
            {
                while (true)
                {
                    ziroService.Update(idAgent, agentProvider.GetCurrentCpuUsage(), agentProvider.GetCurrentFreeMemory());
                }
            }
            

            Console.ReadKey();
        }
    }
}
