using Google.Protobuf;
using GrpcService;
using Grpc.Core;

namespace CoolBroker
{
    public class MainGrpcService(ILogger<MainGrpcService> logger) : grpcService.grpcServiceBase
    {
        private readonly ILogger<MainGrpcService> _logger = logger;
        public override Task<Response> CreateQueue(CreateQueueRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Создана очередь");
            return Ok(QueueStorage.TryCreateQueue(request.Name));
        }

        public override Task<Response> CreateExchange(CreateExchangeRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Создан обменник");
            return Ok(ExchangeStorage.TryCreateExchange(request.Name, (ExchangeType)request.Type));
        }

        public override Task<Response> BindQueue(BindQueueRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Бинд очереди {request.QueueName} и обменника {request.ExchangeName}");
            var Queue = QueueStorage.GetQueue(request.QueueName);
            var Exchange = ExchangeStorage.GetExchange(request.ExchangeName);
            if (Queue is null || Exchange is null)
            {
                return NotOk();
            }
            if (Exchange.IsContainQueue(Queue.name,request.RoutingKey)) return NotOk();

            Queue.routingKey = request.RoutingKey;
            Exchange.AddQueue(Queue,request.RoutingKey);
            return Ok();

        }
        public override Task<Response> SendMessage(SendMessageRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"отправка сообщения по ключу {request.RoutingKey}");
            if (request.Exchange == string.Empty)
            {
                var queue = QueueStorage.GetQueue(request.RoutingKey);
                if (queue is null) return NotOk();
                queue.AddMessageInQueue(request.Message.ToArray());
                return Ok();
            }
            var exchange = ExchangeStorage.GetExchange(request.Exchange);
            if (exchange is null) return NotOk();
            exchange.SendMessageInQueues(request.RoutingKey, request.Message.ToArray());
            return Ok();
        }

        public override Task<ReadQueueMessageResponse> ReadQueueMessage(ReadQueueMessageRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"чтение сообщения из очереди {request.QueueName}");
            
            var queue = QueueStorage.GetQueue(request.QueueName);
            if (queue is null) return Task.FromResult(new ReadQueueMessageResponse { Message = ByteString.Empty });
            var message = queue.ReadMessage();
            if (message is null) return Task.FromResult(new ReadQueueMessageResponse { Message = ByteString.Empty });
            var res = ByteString.CopyFrom(message.ToArray());
            return Task.FromResult(new ReadQueueMessageResponse { Message = res });
        }


        protected Task<Response> Ok()
        {
            return Task.FromResult(new Response { Answer = true});
        }
        protected Task<Response> Ok(bool answer)
        {
            return Task.FromResult(new Response { Answer = answer });
        }
        protected Task<Response> NotOk()
        {
            return Task.FromResult(new Response { Answer = false });
        }
    }
}
