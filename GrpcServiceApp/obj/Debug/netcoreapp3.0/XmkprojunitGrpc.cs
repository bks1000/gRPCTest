// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/xmkprojunit.proto
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

    static readonly grpc::Method<global::GrpcServiceApp.QueryProjUnitRequest, global::GrpcServiceApp.XmkProjUnit> __Method_QueryProjUnit = new grpc::Method<global::GrpcServiceApp.QueryProjUnitRequest, global::GrpcServiceApp.XmkProjUnit>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryProjUnit",
        __Marshaller_xmk_QueryProjUnitRequest,
        __Marshaller_xmk_XmkProjUnit);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServiceApp.XmkprojunitReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of XmkProjUnitService</summary>
    [grpc::BindServiceMethod(typeof(XmkProjUnitService), "BindService")]
    public abstract partial class XmkProjUnitServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcServiceApp.XmkProjUnit> QueryProjUnit(global::GrpcServiceApp.QueryProjUnitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(XmkProjUnitServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_QueryProjUnit, serviceImpl.QueryProjUnit).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, XmkProjUnitServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_QueryProjUnit, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServiceApp.QueryProjUnitRequest, global::GrpcServiceApp.XmkProjUnit>(serviceImpl.QueryProjUnit));
    }

  }
}
#endregion
