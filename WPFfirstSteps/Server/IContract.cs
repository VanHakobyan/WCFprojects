using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        void Say();
    }
}
