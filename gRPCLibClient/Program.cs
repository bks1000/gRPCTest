using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace gRPCLibClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:9007", ChannelCredentials.Insecure);

            var client = new gRPCLib.UserService.UserServiceClient(channel);
            var reply =  await client.GetAllUserAsync(new gRPCLib.ReqsNull { });
            Console.WriteLine(reply.Users.Count);
            foreach (var item in reply.Users)
            {
                Console.WriteLine("id:{0},name:{1},age:{2},address:{3},phone:{4}", new object[] { item.Id, item.Name, item.Age, item.Address, item.Phone });
            }

            var user = client.GetOneUser(new gRPCLib.ReqsGetOneUser { 
                Condition = reply.Users[2].Id
            });
            Console.WriteLine("Get index 2 user data :{0}", user.User.Name);

            //save
            /*gRPCLib.User u = new gRPCLib.User();
            //u.Id = Guid.NewGuid().ToString();
            u.Id = "";
            u.Name = "gRpcTest";
            u.Address = "中华大街自强路";
            u.Age = 35;
            u.Phone = "13300009999";
            var r = await client.SaveAsync(u);
            Console.WriteLine(r.Result);*/

            //update
            user.User.Address = "gRPCupdate";
            var r = await client.SaveAsync(user.User);
            Console.WriteLine(r.Result);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
