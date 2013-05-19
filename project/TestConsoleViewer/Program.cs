using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using TestConsoleViewer.ServiceReference1;
using ZiroServerWcfServiceLibrary;
using TestConsoleViewer.ServiceReference2;

namespace TestConsoleViewer
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine(".......................................................................");
                using (ZiroServiceClient ziroClient = new ZiroServiceClient())
                {
                    List<ZiroAgentRecord> records = ziroClient.GetLastRecords(10).ToList<ZiroAgentRecord>();
                    foreach  (ZiroAgentRecord record in records)
                    {
                        Console.WriteLine("idAgent: {0}\t date: {1}\t cpu: {2}\t memory: {3}\t idRecord: {4}", record.IdAgent, 0, record.CpuUsage, record.FreeMemory, record.idRecords );
                    }
                }

                System.Threading.Thread.Sleep(10000);
            }

            Console.ReadKey();
        }
    }
}
