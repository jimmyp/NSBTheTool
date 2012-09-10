using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Messages;
using NServiceBus;

namespace CommandProcessor
{
    class CommandHandler : IHandleMessages<SomeCommand>
    {
        private readonly IBus _bus;

        public CommandHandler(IBus bus)
        {
            if (bus == null) throw new ArgumentNullException("bus");
            _bus = bus;
        }

        public void Handle(SomeCommand message)
        {
            Console.WriteLine("Recieved Some Command");
            _bus.Publish<EventHappened>();
        }
    }
}
