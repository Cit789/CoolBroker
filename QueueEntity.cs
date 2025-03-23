using System.Collections.Concurrent;

namespace CoolBroker
{
    public class QueueEntity
    {
        private readonly ConcurrentQueue<IReadOnlyCollection<byte>> _queue = [];
        public string routingKey { get; set; } = string.Empty;
        public string name { get; } = string.Empty;
        public void AddMessageInQueue(IReadOnlyCollection<byte> message)
        {
            _queue.Enqueue(message);
        }

        public IReadOnlyCollection<byte>? ReadMessage()
        {
            while (!_queue.IsEmpty)
            {
                if (_queue.TryDequeue(out var message))
                {
                    return message;
                }
            }
            return null;
        }

        public QueueEntity(string name)
        {
            this.name = name;
        }
    }
}
