
using CoolBroker.Exchanges;

namespace CoolBroker.Exchangers
{
    public class TopicExchange : Exchange
    {
        public TopicExchange(string name) : base(name) { }
        

        public override void SendMessageInQueues(string routingKey, IReadOnlyCollection<byte> message)
        {
           
            throw new NotImplementedException();
        }
    }
}
