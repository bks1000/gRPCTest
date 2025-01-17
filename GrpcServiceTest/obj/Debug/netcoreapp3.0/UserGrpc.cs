// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: user.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServiceApp {
  public static partial class UserService
  {
    static readonly string __ServiceName = "UserService";

    static readonly grpc::Marshaller<global::GrpcServiceApp.ReqsGetOneUser> __Marshaller_ReqsGetOneUser = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.ReqsGetOneUser.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServiceApp.RespGetOneUser> __Marshaller_RespGetOneUser = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.RespGetOneUser.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServiceApp.ReqsNull> __Marshaller_ReqsNull = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.ReqsNull.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServiceApp.RespGetAllUser> __Marshaller_RespGetAllUser = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.RespGetAllUser.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServiceApp.User> __Marshaller_User = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.User.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServiceApp.SaveResult> __Marshaller_SaveResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServiceApp.SaveResult.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServiceApp.ReqsGetOneUser, global::GrpcServiceApp.RespGetOneUser> __Method_GetOneUser = new grpc::Method<global::GrpcServiceApp.ReqsGetOneUser, global::GrpcServiceApp.RespGetOneUser>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOneUser",
        __Marshaller_ReqsGetOneUser,
        __Marshaller_RespGetOneUser);

    static readonly grpc::Method<global::GrpcServiceApp.ReqsNull, global::GrpcServiceApp.RespGetAllUser> __Method_GetAllUser = new grpc::Method<global::GrpcServiceApp.ReqsNull, global::GrpcServiceApp.RespGetAllUser>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllUser",
        __Marshaller_ReqsNull,
        __Marshaller_RespGetAllUser);

    static readonly grpc::Method<global::GrpcServiceApp.User, global::GrpcServiceApp.SaveResult> __Method_Save = new grpc::Method<global::GrpcServiceApp.User, global::GrpcServiceApp.SaveResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Save",
        __Marshaller_User,
        __Marshaller_SaveResult);

    static readonly grpc::Method<global::GrpcServiceApp.User, global::GrpcServiceApp.SaveResult> __Method_Delete = new grpc::Method<global::GrpcServiceApp.User, global::GrpcServiceApp.SaveResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_User,
        __Marshaller_SaveResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServiceApp.UserReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for UserService</summary>
    public partial class UserServiceClient : grpc::ClientBase<UserServiceClient>
    {
      /// <summary>Creates a new client for UserService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UserServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UserService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UserServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UserServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UserServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServiceApp.RespGetOneUser GetOneUser(global::GrpcServiceApp.ReqsGetOneUser request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOneUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServiceApp.RespGetOneUser GetOneUser(global::GrpcServiceApp.ReqsGetOneUser request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOneUser, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.RespGetOneUser> GetOneUserAsync(global::GrpcServiceApp.ReqsGetOneUser request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOneUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.RespGetOneUser> GetOneUserAsync(global::GrpcServiceApp.ReqsGetOneUser request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOneUser, null, options, request);
      }
      public virtual global::GrpcServiceApp.RespGetAllUser GetAllUser(global::GrpcServiceApp.ReqsNull request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServiceApp.RespGetAllUser GetAllUser(global::GrpcServiceApp.ReqsNull request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllUser, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.RespGetAllUser> GetAllUserAsync(global::GrpcServiceApp.ReqsNull request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.RespGetAllUser> GetAllUserAsync(global::GrpcServiceApp.ReqsNull request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllUser, null, options, request);
      }
      public virtual global::GrpcServiceApp.SaveResult Save(global::GrpcServiceApp.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Save(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServiceApp.SaveResult Save(global::GrpcServiceApp.User request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Save, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.SaveResult> SaveAsync(global::GrpcServiceApp.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SaveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.SaveResult> SaveAsync(global::GrpcServiceApp.User request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Save, null, options, request);
      }
      public virtual global::GrpcServiceApp.SaveResult Delete(global::GrpcServiceApp.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServiceApp.SaveResult Delete(global::GrpcServiceApp.User request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.SaveResult> DeleteAsync(global::GrpcServiceApp.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServiceApp.SaveResult> DeleteAsync(global::GrpcServiceApp.User request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override UserServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UserServiceClient(configuration);
      }
    }

  }
}
#endregion
