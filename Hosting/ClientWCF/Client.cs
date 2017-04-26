using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientWCF
{
    [ServiceContract]
    interface IServiceContract
    {
        [OperationContract]
        double method(string s);

    }
    class Client
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";
            ChannelFactory<IServiceContract> factory = new ChannelFactory<IServiceContract>(new BasicHttpBinding(),new EndpointAddress("http://localhost:8000//ServiceWCF"));
            IServiceContract service = factory.CreateChannel();
            double num = service.method("double");
            Console.WriteLine($"Double : {num}");

            Console.WriteLine("Any key");
            Console.ReadKey();

        }
    }
}
