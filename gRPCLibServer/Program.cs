using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace gRPCLibServer
{
    class Program
    {
        const int Port = 9007;
        static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { gRPCLib.UserService.BindService(new UserServiceImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("gRPC server listening on port " + Port);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
