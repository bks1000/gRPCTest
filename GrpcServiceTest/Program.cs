using Grpc.Net.Client;
using GrpcServiceApp;
using System;

namespace GrpcServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new UserService.UserServiceClient(channel);
            var reply = client.Add(
                              new AddRequest { A = 1,B=6 }) ;
            Console.WriteLine(reply.C);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
