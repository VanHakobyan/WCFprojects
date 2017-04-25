using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        static void Main()
        {
            Console.Title = "Client";
            Uri adress = new Uri("http://localhost:4000//IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(adress);
            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding,endpoint);
            IContract chanel = factory.CreateChannel();//proxy
            chanel.Say("First Text");
            Console.ReadKey();


        }
    }
}
