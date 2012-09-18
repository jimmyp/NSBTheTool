using NServiceBus;

namespace Subscriber1
{
    public class Ordering : ISpecifyMessageHandlerOrdering
    {
        public void SpecifyOrder(Order order)
        {
            order.Specify(First<AuthHandler>.Then<EventHandler>());
        }
    }
}