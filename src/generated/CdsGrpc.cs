// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/cluster/v3/cds.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Service.Cluster.V3 {
  /// <summary>
  /// Return list of all clusters this proxy will load balance to.
  /// </summary>
  public static partial class ClusterDiscoveryService
  {
    static readonly string __ServiceName = "envoy.service.cluster.v3.ClusterDiscoveryService";

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
    static readonly grpc::Marshaller<global::Envoy.Service.Discovery.V3.DiscoveryRequest> __Marshaller_envoy_service_discovery_v3_DiscoveryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Envoy.Service.Discovery.V3.DiscoveryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Envoy.Service.Discovery.V3.DiscoveryResponse> __Marshaller_envoy_service_discovery_v3_DiscoveryResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Envoy.Service.Discovery.V3.DiscoveryResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest> __Marshaller_envoy_service_discovery_v3_DeltaDiscoveryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> __Marshaller_envoy_service_discovery_v3_DeltaDiscoveryResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse> __Method_StreamClusters = new grpc::Method<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamClusters",
        __Marshaller_envoy_service_discovery_v3_DiscoveryRequest,
        __Marshaller_envoy_service_discovery_v3_DiscoveryResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> __Method_DeltaClusters = new grpc::Method<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DeltaClusters",
        __Marshaller_envoy_service_discovery_v3_DeltaDiscoveryRequest,
        __Marshaller_envoy_service_discovery_v3_DeltaDiscoveryResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse> __Method_FetchClusters = new grpc::Method<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FetchClusters",
        __Marshaller_envoy_service_discovery_v3_DiscoveryRequest,
        __Marshaller_envoy_service_discovery_v3_DiscoveryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Service.Cluster.V3.CdsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClusterDiscoveryService</summary>
    [grpc::BindServiceMethod(typeof(ClusterDiscoveryService), "BindService")]
    public abstract partial class ClusterDiscoveryServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task StreamClusters(grpc::IAsyncStreamReader<global::Envoy.Service.Discovery.V3.DiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Service.Discovery.V3.DiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task DeltaClusters(grpc::IAsyncStreamReader<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Envoy.Service.Discovery.V3.DiscoveryResponse> FetchClusters(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ClusterDiscoveryService</summary>
    public partial class ClusterDiscoveryServiceClient : grpc::ClientBase<ClusterDiscoveryServiceClient>
    {
      /// <summary>Creates a new client for ClusterDiscoveryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ClusterDiscoveryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ClusterDiscoveryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ClusterDiscoveryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ClusterDiscoveryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ClusterDiscoveryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse> StreamClusters(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamClusters(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse> StreamClusters(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamClusters, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> DeltaClusters(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeltaClusters(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse> DeltaClusters(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DeltaClusters, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Envoy.Service.Discovery.V3.DiscoveryResponse FetchClusters(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchClusters(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Envoy.Service.Discovery.V3.DiscoveryResponse FetchClusters(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FetchClusters, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Envoy.Service.Discovery.V3.DiscoveryResponse> FetchClustersAsync(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchClustersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Envoy.Service.Discovery.V3.DiscoveryResponse> FetchClustersAsync(global::Envoy.Service.Discovery.V3.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FetchClusters, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ClusterDiscoveryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClusterDiscoveryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ClusterDiscoveryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_StreamClusters, serviceImpl.StreamClusters)
          .AddMethod(__Method_DeltaClusters, serviceImpl.DeltaClusters)
          .AddMethod(__Method_FetchClusters, serviceImpl.FetchClusters).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ClusterDiscoveryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_StreamClusters, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse>(serviceImpl.StreamClusters));
      serviceBinder.AddMethod(__Method_DeltaClusters, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Service.Discovery.V3.DeltaDiscoveryRequest, global::Envoy.Service.Discovery.V3.DeltaDiscoveryResponse>(serviceImpl.DeltaClusters));
      serviceBinder.AddMethod(__Method_FetchClusters, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Envoy.Service.Discovery.V3.DiscoveryRequest, global::Envoy.Service.Discovery.V3.DiscoveryResponse>(serviceImpl.FetchClusters));
    }

  }
}
#endregion
