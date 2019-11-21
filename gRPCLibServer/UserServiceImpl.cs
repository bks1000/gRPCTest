using AutoMapper;
using Grpc.Core;
using gRPCLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gRPCLibServer
{
    public class UserServiceImpl:UserService.UserServiceBase
    {
        MysqlDbContext ctx = new MysqlDbContext();
        
        public override Task<RespGetAllUser> GetAllUser(ReqsNull request, ServerCallContext context)
        {
            return Task.FromResult(Query());
        }

        public override Task<RespGetOneUser> GetOneUser(ReqsGetOneUser request, ServerCallContext context)
        {
            User user = ctx.User.Find(request.Condition);

            //Auto Mapper，只是RespGetOneUser中含有User这样转换不行
            //Mapper.Initialize(x => x.CreateMap<User, RespGetOneUser>());
            //RespGetOneUser respuser = AutoMapper.Mapper.Map<RespGetOneUser>(user);

            //可以的
            Mapper.Initialize(x => x.CreateMap<gRPCLibServer.User, gRPCLib.User>());
            gRPCLib.User respuser = AutoMapper.Mapper.Map<gRPCLib.User>(user);

            return Task.FromResult(new RespGetOneUser { 
                User = respuser
            });
        }



        public RespGetAllUser Query()
        {
            RespGetAllUser resp = new RespGetAllUser();
            foreach (var item in ctx.User)
            {
                resp.Users.Add(new gRPCLib.User { 
                    Id = item.Id,
                    Name = item.Name,
                    Age = item.Age,
                    Address = item.Address,
                    Phone = item.Phone
                });
            }
            return resp;
        }
    }
}
