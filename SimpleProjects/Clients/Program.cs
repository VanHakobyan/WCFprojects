using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ContractClient cc = new ServiceReference1.ContractClient();
            cc.GetData(4);
            Console.ReadKey();
        }
    }
}
