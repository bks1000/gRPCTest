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

            //mysql
            var client = new UserService.UserServiceClient(channel);
            var reply = client.GetAllUser(new ReqsNull { });
            Console.WriteLine(reply.Users.Count);
            Console.WriteLine(reply.Users[reply.Users.Count - 1].Name);

            //oracle
            var c2 = new XmkProjUnitService.XmkProjUnitServiceClient(channel);
            //oracle ado.net
            var r2 = c2.QueryProjUnit(new QueryProjUnitRequest { ProCode = "101-0401-YSN-BLFR" });
            Console.WriteLine(r2.ItemId);

            //oracle entity framework
            var r3 = c2.QueryProjUnitAll(new Nvl { });
            Console.WriteLine(r3.Data_);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
