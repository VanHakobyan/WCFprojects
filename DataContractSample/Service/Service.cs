using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace ="point")]
    public interface IService
    {

        [OperationContract]
        Point Add(Point p1,Point p2);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract(Namespace ="http://my")]
    public struct Point
    {
        [DataMember]
        public double x;
        public double y;
        
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Service : IService
    {
        public Point Add(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
    }
}
