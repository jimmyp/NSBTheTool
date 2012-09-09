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
        public void Handle(SomeCommand message)
        {
            Console.WriteLine("Recieved Some Command");
        }
    }
}
