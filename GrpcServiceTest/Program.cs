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
            var reply = client.GetAllUser(new ReqsNull { });
            Console.WriteLine(reply.Users.Count);
            Console.WriteLine(reply.Users[reply.Users.Count - 1].Name);
            

            //oracle 需要 12以上版本
            /*var c2 = new XmkProjUnitService.XmkProjUnitServiceClient(channel);
            var r2 = c2.QueryProjUnit(new QueryProjUnitRequest { ProCode = "101-0401-YSN-BLFR" });
            Console.WriteLine(r2.ItemId);*/


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
