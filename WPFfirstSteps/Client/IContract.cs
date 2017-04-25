using System.ServiceModel;

namespace Client
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        void Say(string text);
    }
}
