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
            ServiceHost host = new ServiceHost(typeof(Service), new Uri("http://localhost"));
            host.AddServiceEndpoint(typeof(IInterface), new BasicHttpBinding(), "");
            host.Open();

            Console.WriteLine("opened...");
            Console.ReadKey();
            host.Close();
        }
    }
}
