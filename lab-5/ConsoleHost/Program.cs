using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "net.tcp://localhost:8734/Design_Time_Addresses/WCFService/Service1/";
            NetTcpBinding binding = new NetTcpBinding();
            using (ServiceHost host = new ServiceHost(typeof(WCFService.WCFService)))
            {
                host.AddServiceEndpoint(typeof(IWCFService), binding, baseAddress);
                host.Open();
                Console.WriteLine("Service Hosted Sucessfully");
                Console.Read();
            }
        }
    }
}
