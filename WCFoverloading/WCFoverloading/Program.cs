using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFoverloading
{
   
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.Title = "server";

            ServiceHost host = new ServiceHost(typeof(Service));
            host.AddServiceEndpoint(typeof(IInterface), new BasicHttpBinding(), "http://localhost:7787/IInterface");
            host.Open();

            Console.WriteLine("opened...");
            Console.ReadKey();
            host.Close();
        }
    }
}
