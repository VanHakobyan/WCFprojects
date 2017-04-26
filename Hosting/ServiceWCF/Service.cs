using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWCF
{
    [ServiceContract]
    interface IServiceContract
    {
        [OperationContract]
        double method(string s);

    }
    class MyService : IServiceContract
    {
        public double method(string s)
        {
            Console.WriteLine($"OK+{s}");
            if (s=="double")
            {
                return 55.151;
            }
            else
            {
                return 0;
            }
        }
    }


    //Host
    class Service
    {
        static void Main()
        {
            Console.Title = "Server";
            ServiceHost serviceHost = new ServiceHost(typeof(MyService), new Uri("http://localhost:8000//ServiceWCF"));
            serviceHost.AddServiceEndpoint(typeof(IServiceContract), new BasicHttpBinding(), "");
            serviceHost.Open();
            Console.WriteLine("Enter any key");
            Console.ReadKey();
            serviceHost.Close();

        }
    }
}
