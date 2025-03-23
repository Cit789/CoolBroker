// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class grpcService
  {
    static readonly string __ServiceName = "grpcService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.CreateQueueRequest> __Marshaller_CreateQueueRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.CreateQueueRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Response> __Marshaller_Response = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Response.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.CreateExchangeRequest> __Marshaller_CreateExchangeRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.CreateExchangeRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.BindQueueRequest> __Marshaller_BindQueueRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.BindQueueRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.SendMessageRequest> __Marshaller_SendMessageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.SendMessageRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.ReadQueueMessageRequest> __Marshaller_ReadQueueMessageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.ReadQueueMessageRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.ReadQueueMessageResponse> __Marshaller_ReadQueueMessageResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.ReadQueueMessageResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.CreateQueueRequest, global::GrpcService.Response> __Method_CreateQueue = new grpc::Method<global::GrpcService.CreateQueueRequest, global::GrpcService.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateQueue",
        __Marshaller_CreateQueueRequest,
        __Marshaller_Response);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.CreateExchangeRequest, global::GrpcService.Response> __Method_CreateExchange = new grpc::Method<global::GrpcService.CreateExchangeRequest, global::GrpcService.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateExchange",
        __Marshaller_CreateExchangeRequest,
        __Marshaller_Response);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.BindQueueRequest, global::GrpcService.Response> __Method_BindQueue = new grpc::Method<global::GrpcService.BindQueueRequest, global::GrpcService.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BindQueue",
        __Marshaller_BindQueueRequest,
        __Marshaller_Response);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.SendMessageRequest, global::GrpcService.Response> __Method_SendMessage = new grpc::Method<global::GrpcService.SendMessageRequest, global::GrpcService.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendMessage",
        __Marshaller_SendMessageRequest,
        __Marshaller_Response);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.ReadQueueMessageRequest, global::GrpcService.ReadQueueMessageResponse> __Method_ReadQueueMessage = new grpc::Method<global::GrpcService.ReadQueueMessageRequest, global::GrpcService.ReadQueueMessageResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadQueueMessage",
        __Marshaller_ReadQueueMessageRequest,
        __Marshaller_ReadQueueMessageResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of grpcService</summary>
    [grpc::BindServiceMethod(typeof(grpcService), "BindService")]
    public abstract partial class grpcServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Response> CreateQueue(global::GrpcService.CreateQueueRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Response> CreateExchange(global::GrpcService.CreateExchangeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Response> BindQueue(global::GrpcService.BindQueueRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Response> SendMessage(global::GrpcService.SendMessageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.ReadQueueMessageResponse> ReadQueueMessage(global::GrpcService.ReadQueueMessageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(grpcServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateQueue, serviceImpl.CreateQueue)
          .AddMethod(__Method_CreateExchange, serviceImpl.CreateExchange)
          .AddMethod(__Method_BindQueue, serviceImpl.BindQueue)
          .AddMethod(__Method_SendMessage, serviceImpl.SendMessage)
          .AddMethod(__Method_ReadQueueMessage, serviceImpl.ReadQueueMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, grpcServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateQueue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.CreateQueueRequest, global::GrpcService.Response>(serviceImpl.CreateQueue));
      serviceBinder.AddMethod(__Method_CreateExchange, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.CreateExchangeRequest, global::GrpcService.Response>(serviceImpl.CreateExchange));
      serviceBinder.AddMethod(__Method_BindQueue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.BindQueueRequest, global::GrpcService.Response>(serviceImpl.BindQueue));
      serviceBinder.AddMethod(__Method_SendMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.SendMessageRequest, global::GrpcService.Response>(serviceImpl.SendMessage));
      serviceBinder.AddMethod(__Method_ReadQueueMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.ReadQueueMessageRequest, global::GrpcService.ReadQueueMessageResponse>(serviceImpl.ReadQueueMessage));
    }

  }
}
#endregion
