using System;
using System.ServiceModel;

namespace Client
{
    class Client
    {
        static void Main()
        {
            Console.Title = "Client";
            Uri adress = new Uri("http://localhost:8000//IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(adress);
            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding,endpoint);
            IContract chanel = factory.CreateChannel();//proxy
            chanel.ToString();
            Console.ReadKey();
        }
    }
}
