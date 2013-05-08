using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace ZiroDesktopAgentLibrary
{
    public class ZiroDesktopAgentProvider
    {
        public int cpuUsageThreadSleepingTime { get; set; }
        private PerformanceCounter currentCpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter currentFreeMemory = new PerformanceCounter("Memory", "Available MBytes");

        ZiroDesktopAgentProvider()
        {
            cpuUsageThreadSleepingTime = 400;
        }

        public float getCurrentCpuUsage()
        {
            currentCpuUsage.NextValue();
            System.Threading.Thread.Sleep(cpuUsageThreadSleepingTime);
            return currentCpuUsage.NextValue();
        }

        public float getCurrentFreeMemory()
        {
            return currentFreeMemory.NextValue();
        }
    }
}
