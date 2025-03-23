using System.Collections.Concurrent;

namespace CoolBroker
{
    public static class QueueStorage
    {
        private static ConcurrentDictionary<string,QueueEntity> _queueStorage = [];
        public static bool TryCreateQueue(string name)
        {
           return _queueStorage.TryAdd(name, new QueueEntity(name));
        }
        public static QueueEntity? GetQueue(string name)
        {
            _queueStorage.TryGetValue(name, out var q);
            return q;
        }
    }
}
