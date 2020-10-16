using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTcpEndpoint.ServiceReference;

namespace TestTcpEndpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFServiceClient client = new WCFServiceClient();

            Console.Write("x = ");
            int.TryParse(Console.ReadLine(), out int x);
            Console.Write("y = ");
            int.TryParse(Console.ReadLine(), out int y);
            Console.WriteLine($"sum = {client.Add(x, y)}");

            Console.ReadKey();
        }
    }
}
