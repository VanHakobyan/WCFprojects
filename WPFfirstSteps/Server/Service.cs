using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Service : IContract
    {
        public void Say(string text)
        {
            Console.WriteLine($"Send messege {text}");
        }
    }
}
