using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;


namespace Client
{
    class Client
    {
        static void Main()
        {
            Console.Title = "Client";
            ServiceReference1.ContractClient cc = new ServiceReference1.ContractClient();
            cc.sey("hello");
            
        }

        public class ServiceReference1
        {
        }
    }
}
