using System.Collections.Concurrent;
using CoolBroker.Exchanges;

namespace CoolBroker
{
    public static class ExchangeStorage
    {
        private static readonly ConcurrentDictionary<string, Exchange> _exchangeStorage = [];

        public static bool TryCreateExchange(string name, ExchangeType exchangeType)
        {
            return _exchangeStorage.TryAdd(name,Exchange.CreateExchange(exchangeType,name));
        }

        public static Exchange? GetExchange(string name)
        {
            _exchangeStorage.TryGetValue(name, out var exchange);
            return exchange;
        }
    }
}
