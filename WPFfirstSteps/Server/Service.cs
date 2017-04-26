using System;

namespace Server
{
    class Service : IContract
    {
        public void Say()
        {
            Console.WriteLine($"Send message");
        }
    }
}
