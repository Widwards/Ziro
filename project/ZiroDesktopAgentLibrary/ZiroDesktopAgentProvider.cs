using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;

namespace ZiroDesktopAgentLibrary
{
    public class ZiroDesktopAgentProvider
    {
        public int cpuUsageThreadSleepingTime { get; set; }
        public int idAgent { get; set; }
        private PerformanceCounter currentCpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter currentFreeMemory = new PerformanceCounter("Memory", "Available MBytes");


        public ZiroDesktopAgentProvider()
        {
            cpuUsageThreadSleepingTime = 400;
        }

        public float GetCurrentCpuUsage()
        {
            currentCpuUsage.NextValue();
            System.Threading.Thread.Sleep(cpuUsageThreadSleepingTime);
            return currentCpuUsage.NextValue();
        }

        public float GetCurrentFreeMemory()
        {
            return currentFreeMemory.NextValue();
        }

        public void LoadIdAgentConfiguration()
        {
            ZiroDesktopConfigurationManager configManager = new ZiroDesktopConfigurationManager("AgenConfiguration.ini");
            configManager.LoadFileConfiguration();
            this.idAgent = configManager.GetIdAgent();
        }

        //public void GenerateIdAgentConfiguration
        //{
        //}
    }

    public class ZiroDesktopConfigurationManager
    {
        private int idAgent;
        public string ConfigFileName { get; set; }
        private List<string> configLines = new List<string>();

        public ZiroDesktopConfigurationManager(string configurationFileName)
        {
            this.ConfigFileName = configurationFileName;
        }
        public void LoadFileConfiguration()
        {
            if (File.Exists(ConfigFileName))
            {
                foreach (var configLine in File.ReadAllLines(ConfigFileName))
                {
                    configLines.Add(configLine);
                }
                
            }
            else
            {
                File.Create(ConfigFileName).Close();
            }

            //Загрузка id
            int tmpGUID;
            
            if (configLines.Count==0)
            {
                //int.TryParse(Guid.NewGuid().GetHashCode().ToString("X"),out idAgent);
                idAgent = Math.Abs(Guid.NewGuid().GetHashCode());
                string[] wr = new string[1];
                wr[0] = idAgent+"";
                File.WriteAllLines(ConfigFileName, wr);
            }
            else
            {
                int.TryParse(configLines[0], out tmpGUID);
                if (tmpGUID==0)
                {
                    File.Delete(ConfigFileName);
                    idAgent = Math.Abs(Guid.NewGuid().GetHashCode());
                    string[] wr = new string[1];
                    wr[0] = idAgent + "";
                    File.WriteAllLines(ConfigFileName, wr);
                }
                else
                {
                    idAgent = tmpGUID;
                }
                
            }

            //TODO: СДЕЛАТЬ ЗАПИСЬ NEW GUID в файл
        }

        public int GetIdAgent()
        {
            return idAgent;
        }



    }
}

























