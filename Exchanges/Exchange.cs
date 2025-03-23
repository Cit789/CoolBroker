using CoolBroker.Exchangers;
using System.Collections.Concurrent;

namespace CoolBroker.Exchanges
{
    public abstract class Exchange
    {
        protected readonly ConcurrentDictionary<string,ConcurrentBag<QueueEntity>> bindedQueues = [];
        public string Name { get; } = string.Empty;

        public Exchange(string name)
        {
            Name = name;
        }
        public static Exchange CreateExchange(ExchangeType type, string name)
        {
            return type switch
            {
                ExchangeType.direct => new DirectExchange(name),
                ExchangeType.topic => new TopicExchange(name),
                _ => new DirectExchange(name),
            };
        }
        public void AddQueue(QueueEntity queue,string routingKey)
        {
            if (bindedQueues.TryGetValue(routingKey, out ConcurrentBag<QueueEntity>? value))
            {
                value.Add(queue);
                return;
            }
            bindedQueues.TryAdd(routingKey, []);
            bindedQueues[routingKey].Add(queue);

        }
        public bool IsContainQueue(string queueName,string routingKey)
        {
            if(!bindedQueues.TryGetValue(routingKey,out ConcurrentBag<QueueEntity>? value))
            {
                return false;
            }
            return bindedQueues[routingKey].Any(x => x.name == queueName);
        }
        public abstract void SendMessageInQueues(string routingKey, IReadOnlyCollection<byte> message);


    }
}
