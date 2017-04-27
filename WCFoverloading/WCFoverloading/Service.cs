using System;
using System.ServiceModel;
namespace WCFoverloading
{
    [ServiceContract]
    interface IInterface
    {
        [OperationContract(Name = "addInt")]
        int Add(int x, int y);

        [OperationContract(Name = "addDouble")]
        double Add(double x, double y);

    }
    class Service : IInterface
    {
        public int Add(int x, int y)
        {
            Console.WriteLine(OperationContext.Current.RequestContext.RequestMessage);
            return x + y;
        }

        public double Add(double x, double y)
        {
            Console.WriteLine(OperationContext.Current.RequestContext.RequestMessage);
            return x + y;
        }
    }
}
