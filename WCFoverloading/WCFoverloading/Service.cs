using System;
using System.ServiceModel;
namespace WCFoverloading
{

    

    [ServiceContract]
    interface IInterface
    {
        [OperationContract(Name = "AddInt")]
        int Add(int x, int y);

        [OperationContract(Name = "AddDouble")]
        double Add(double x, double y);

    }
    class Service : IInterface
    {
        public int Add(int x, int y)
        {
            Console.WriteLine(OperationContext.Current.RequestContext.RequestMessage.ToString());
            return x + y;
        }

        public double Add(double x, double y)
        {
            Console.WriteLine(OperationContext.Current.RequestContext.RequestMessage.ToString());
            return x + y;
        }
    }
}
