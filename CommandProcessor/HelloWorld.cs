using System;
using NServiceBus;

namespace CommandProcessor
{
    public class HelloWorld : IWantToRunAtStartup
    {
        public void Run()
        {
            Console.WriteLine("Hello World!");
        }

        public void Stop()
        {
        }
    }
}