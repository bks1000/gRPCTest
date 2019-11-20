using Grpc.Core;
using GRPCDemo;
using System;
using System.Threading.Tasks;

namespace gRPCServer
{
    class Program
    {
        const int Port = 9007;
        static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { gRPC.BindService(new gRPCImpl()),QueryServie.BindService(new QueryImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("gRPC server listening on port " + Port);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();

        }

        class gRPCImpl : gRPC.gRPCBase
        {
            // 实现SayHello方法
            public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
            {
                return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
            }

            public override Task<AddReply> Add(AddRequest request, ServerCallContext context)
            {
                return Task.FromResult(new AddReply { C = request.A + request.B, Msg = "{\"result\":\"ok\"}" });
            }
        }

        class QueryImpl : QueryServie.QueryServieBase
        {
            public override Task<SearchResponse> query(SearchRequest request, ServerCallContext context)
            {
                return Task.FromResult(queryData());
            }

            private SearchResponse queryData()
            {
                SearchResponse resp = new SearchResponse();
                resp.Results.Add(new Result { Url = "sina.com", Title = "新浪"});
                resp.Results.Add(new Result { Url = "baidu.com", Title = "百度" });
                resp.Results.Add(new Result { Url = "taobao.com", Title = "淘宝" });
                return resp;
            }
        }
    }
}
