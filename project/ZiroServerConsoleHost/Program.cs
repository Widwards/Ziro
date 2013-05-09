using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using ZiroServerWcfServiceLibrary;


namespace ZiroServerConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ZiroMainService)))
            {
                host.Open();

                Console.WriteLine("Press <Enter> to terminate service");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
