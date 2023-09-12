// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/secret/v3/sds.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Service.Secret.V3 {
  public static partial class SecretDiscoveryService
  {
    static readonly string __ServiceName = "envoy.service.secret.v3.SecretDiscoveryService";

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
    static readonly grpc::Marshaller<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest> __Marshaller_envoy_service_discovery_v3_DeltaDiscoveryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> __Marshaller_envoy_service_discovery_v3_DeltaDiscoveryResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Envoy.Service.Discovery.V3.DiscoveryRequest> __Marshaller_envoy_service_discovery_v3_DiscoveryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Envoy.Service.Discovery.V3.DiscoveryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Envoy.Service.Discovery.V3.DiscoveryResponse> __Marshaller_envoy_service_discovery_v3_DiscoveryResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Envoy.Service.Discovery.V3.DiscoveryResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> __Method_DeltaSecrets = new grpc::Method<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DeltaSecrets",
        __Marshaller_envoy_service_discovery_v3_DeltaDiscoveryRequest,
        __Marshaller_envoy_service_discovery_v3_DeltaDiscoveryResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse> __Method_StreamSecrets = new grpc::Method<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamSecrets",
        __Marshaller_envoy_service_discovery_v3_DiscoveryRequest,
        __Marshaller_envoy_service_discovery_v3_DiscoveryResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse> __Method_FetchSecrets = new grpc::Method<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FetchSecrets",
        __Marshaller_envoy_service_discovery_v3_DiscoveryRequest,
        __Marshaller_envoy_service_discovery_v3_DiscoveryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Service.Secret.V3.SdsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SecretDiscoveryService</summary>
    [grpc::BindServiceMethod(typeof(SecretDiscoveryService), "BindService")]
    public abstract partial class SecretDiscoveryServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task DeltaSecrets(grpc::IAsyncStreamReader<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task StreamSecrets(grpc::IAsyncStreamReader<global::Envoy.Service.Discovery.V3.DiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Service.Discovery.V3.DiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Envoy.Service.Discovery.V3.DiscoveryResponse> FetchSecrets(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SecretDiscoveryService</summary>
    public partial class SecretDiscoveryServiceClient : grpc::ClientBase<SecretDiscoveryServiceClient>
    {
      /// <summary>Creates a new client for SecretDiscoveryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SecretDiscoveryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SecretDiscoveryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SecretDiscoveryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SecretDiscoveryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SecretDiscoveryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> DeltaSecrets(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeltaSecrets(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> DeltaSecrets(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DeltaSecrets, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse> StreamSecrets(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamSecrets(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse> StreamSecrets(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamSecrets, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Envoy.Service.Discovery.V3.DiscoveryResponse FetchSecrets(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchSecrets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Envoy.Service.Discovery.V3.DiscoveryResponse FetchSecrets(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FetchSecrets, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Envoy.Service.Discovery.V3.DiscoveryResponse> FetchSecretsAsync(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchSecretsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Envoy.Service.Discovery.V3.DiscoveryResponse> FetchSecretsAsync(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FetchSecrets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SecretDiscoveryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SecretDiscoveryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SecretDiscoveryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeltaSecrets, serviceImpl.DeltaSecrets)
          .AddMethod(__Method_StreamSecrets, serviceImpl.StreamSecrets)
          .AddMethod(__Method_FetchSecrets, serviceImpl.FetchSecrets).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SecretDiscoveryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DeltaSecrets, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse>(serviceImpl.DeltaSecrets));
      serviceBinder.AddMethod(__Method_StreamSecrets, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse>(serviceImpl.StreamSecrets));
      serviceBinder.AddMethod(__Method_FetchSecrets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse>(serviceImpl.FetchSecrets));
    }

  }
}
#endregion
