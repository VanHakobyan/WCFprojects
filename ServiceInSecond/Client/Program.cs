using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Uri address = new Uri($"http://localhost:4000/IService1");
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(address);
            ChannelFactory<IService1> Factory = new ChannelFactory<IService1>(binding, endpoint);
            IService1 channel= Factory.CreateChannel();
            string st = channel.GetData(2);
            Console.WriteLine(st);
            
        }
    }
}
