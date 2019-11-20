using Grpc.Core;
using GRPCDemo;
using System;


namespace gRPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:9007", ChannelCredentials.Insecure);

            var client = new gRPC.gRPCClient(channel);
            var reply = client.SayHello(new HelloRequest { Name = "Zhang San" });
            Console.WriteLine("来自" + reply.Message);

            var reqult = client.Add(new AddRequest { A = 3, B = 5 });
            Console.WriteLine(reqult.C);
            Console.WriteLine(reqult.Msg);

            var client2 = new QueryServie.QueryServieClient(channel);
            var resp = client2.query(new SearchRequest { Query = "", PageNumber = 1, ResultPerPage = 20, Corpus = SearchRequest.Types.Corpus.Web });
            Console.WriteLine(resp);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
