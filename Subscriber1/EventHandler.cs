using System;
using Messages;
using NServiceBus;

namespace Subscriber1
{
    public class EventHandler : IHandleMessages<EventHappened>
    {
        public void Handle(EventHappened message)
        {
            Console.WriteLine("Recieved Event");
        }
    }
}