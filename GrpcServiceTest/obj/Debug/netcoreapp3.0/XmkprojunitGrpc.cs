// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: xmkprojunit.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServiceApp {
  public static partial class XmkProjUnitService
  {
    static readonly string __ServiceName = "xmk.XmkProjUnitService";

    static readonly grpc::Marshaller<global::GrpcServiceApp.QueryProjUnitRequest> __Marshaller_xmk_QueryProjUnitRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.QueryProjUnitRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServiceApp.XmkProjUnit> __Marshaller_xmk_XmkProjUnit = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.XmkProjUnit.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServiceApp.Nvl> __Marshaller_xmk_Nvl = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.Nvl.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServiceApp.Data> __Marshaller_xmk_Data = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.Data.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServiceApp.QueryProjUnitRequest, global::GrpcServiceApp.XmkProjUnit> __Method_QueryProjUnit = new grpc::Method<global::GrpcServiceApp.QueryProjUnitRequest, global::GrpcServiceApp.XmkProjUnit>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryProjUnit",
        __Marshaller_xmk_QueryProjUnitRequest,
        __Marshaller_xmk_XmkProjUnit);

    static readonly grpc::Method<global::GrpcServiceApp.Nvl, global::GrpcServiceApp.Data> __Method_QueryProjUnitAll = new grpc::Method<global::GrpcServiceApp.Nvl, global::GrpcServiceApp.Data>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryProjUnitAll",
        __Marshaller_xmk_Nvl,
        __Marshaller_xmk_Data);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServiceApp.XmkprojunitReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for XmkProjUnitService</summary>
    public partial class XmkProjUnitServiceClient : grpc::ClientBase<XmkProjUnitServiceClient>
    {
      /// <summary>Creates a new client for XmkProjUnitService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public XmkProjUnitServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for XmkProjUnitService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public XmkProjUnitServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected XmkProjUnitServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected XmkProjUnitServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServiceApp.XmkProjUnit QueryProjUnit(global::GrpcServiceApp.QueryProjUnitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryProjUnit(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServiceApp.XmkProjUnit QueryProjUnit(global::GrpcServiceApp.QueryProjUnitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueryProjUnit, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.XmkProjUnit> QueryProjUnitAsync(global::GrpcServiceApp.QueryProjUnitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryProjUnitAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.XmkProjUnit> QueryProjUnitAsync(global::GrpcServiceApp.QueryProjUnitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueryProjUnit, null, options, request);
      }
      public virtual global::GrpcServiceApp.Data QueryProjUnitAll(global::GrpcServiceApp.Nvl request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryProjUnitAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServiceApp.Data QueryProjUnitAll(global::GrpcServiceApp.Nvl request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueryProjUnitAll, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.Data> QueryProjUnitAllAsync(global::GrpcServiceApp.Nvl request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryProjUnitAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.Data> QueryProjUnitAllAsync(global::GrpcServiceApp.Nvl request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueryProjUnitAll, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override XmkProjUnitServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new XmkProjUnitServiceClient(configuration);
      }
    }

  }
}
#endregion
