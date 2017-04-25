using System;

namespace Server
{
    class Service : IContract
    {
        public void Say(string text)
        {
            Console.WriteLine($"Send message {text}");
        }
    }
}
