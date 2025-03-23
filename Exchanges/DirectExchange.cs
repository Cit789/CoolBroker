using System.Collections.Concurrent;

namespace CoolBroker.Exchanges
{
    public class DirectExchange : Exchange
    {
        public DirectExchange(string name) : base(name) { }

        public override void SendMessageInQueues(string routingKey, IReadOnlyCollection<byte> message)
        {
            if (bindedQueues.TryGetValue(routingKey, out ConcurrentBag<QueueEntity>? value))
            {
                foreach (var queue in value)
                {
                    queue.AddMessageInQueue(message);
                }
            }
        }
    }
}
