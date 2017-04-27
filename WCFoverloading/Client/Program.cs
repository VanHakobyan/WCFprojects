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

            IInterface proxy = ChannelFactory<IInterface>.CreateChannel(
                new BasicHttpBinding(), new EndpointAddress("http://localhost"));

            using (proxy as IDisposable)
            {
                int i = proxy.Add(22, 63);
                Console.WriteLine(i);

                double d = proxy.Add(2.7, 9.3);
                Console.WriteLine(d);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
