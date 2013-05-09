using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZiroDesktopAgentLibrary;

namespace ZiroDesktopConsoleAgent
{
    /// <summary>
    /// Тестовый консольный агент Ziro
    /// </summary>
    class ZiroDesktopAgent
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Agent is running...");
            ZiroDesktopAgentProvider agentProvider = new ZiroDesktopAgentProvider();
            agentProvider.LoadIdAgentConfiguration();
            Console.WriteLine("Agent ID: {0}", agentProvider.idAgent);

            

            Console.ReadKey();
        }
    }
}
