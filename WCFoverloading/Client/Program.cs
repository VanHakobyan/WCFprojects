using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [ServiceContract]
    interface IInterface
    {
        [OperationContract(Name = "AddInt")]
        int Add(int a, int b);

        [OperationContract(Name = "AddDouble")]
        double Add(double a, double b);
    }


    class Program
    {
        static void Main()
        {
            Console.Title = "CLIENT";

            //IInterface proxy = ChannelFactory<IInterface>.CreateChannel(
            //    new BasicHttpBinding(), new EndpointAddress("http://localhost:7787/IInterface"));
            //IInterface chanel = proxy.Add()
            ChannelFactory<IInterface> proxy = new ChannelFactory<IInterface>(new BasicHttpBinding(),
                new EndpointAddress("http://localhost:7787/IInterface"));
            IInterface chanel = proxy.CreateChannel();
            using (chanel as IDisposable)
            {
                int i = chanel.Add(22, 63);
                Console.WriteLine(i);

                double d = chanel.Add(2.7, 9.3);
                Console.WriteLine(d);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
