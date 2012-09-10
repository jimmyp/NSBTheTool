using System;
using NServiceBus.Saga;

namespace Subscriber2
{
    public class ThreeEventsData : ISagaEntity
    {
        public Guid Id { get; set; }
        public string Originator { get; set; }
        public string OriginalMessageId { get; set; }

        public int NumEvents { get; set; }
    }
}