using AutoMapper;
using Grpc.Core;
using gRPCLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gRPCLibServer
{
    public class UserServiceImpl:UserService.UserServiceBase
    {
        public override Task<RespGetAllUser> GetAllUser(ReqsNull request, ServerCallContext context)
        {
            return Task.FromResult(Query());
        }

        public override Task<RespGetOneUser> GetOneUser(ReqsGetOneUser request, ServerCallContext context)
        {
            using (MysqlDbContext ctx = new MysqlDbContext())
            {
                User user = ctx.User.Find(request.Condition);

                //1.Auto Mapper，只是RespGetOneUser中含有User这样转换不行
                //Mapper.Initialize(x => x.CreateMap<User, RespGetOneUser>());
                //RespGetOneUser respuser = AutoMapper.Mapper.Map<RespGetOneUser>(user);

                //2.可以的(Initialize是静态方法，只需要执行一次即可)
                //Mapper.Initialize(x => x.CreateMap<gRPCLibServer.User, gRPCLib.User>());
                //gRPCLib.User respuser = AutoMapper.Mapper.Map<gRPCLib.User>(user);

                //3.在启动时，初始化Mapper，以后就可以通过这样的方式转换了，还是比较方便的。
                gRPCLib.User respuser = Mapper.Map<gRPCLibServer.User, gRPCLib.User>(user);

                return Task.FromResult(new RespGetOneUser
                {
                    User = respuser
                });
            }
        }

        public override Task<SaveResult> Save(gRPCLib.User request, ServerCallContext context)
        {
            using (MysqlDbContext ctx = new MysqlDbContext())
            {
                //启动时已经初始化了Mapper，直接转换即可
                gRPCLibServer.User user = Mapper.Map<gRPCLib.User, gRPCLibServer.User>(request);

                if (user.Id == "")
                {
                    user.Id = Guid.NewGuid().ToString();
                    ctx.Add(user);
                }
                else
                {
                    ctx.User.Update(user);
                }

                int cnt = ctx.SaveChanges();
                return Task.FromResult(new SaveResult { Result = cnt > 0 });
            }
        }



        public RespGetAllUser Query()
        {
            using (MysqlDbContext ctx = new MysqlDbContext())
            {
                RespGetAllUser resp = new RespGetAllUser();
                foreach (var item in ctx.User)
                {
                    gRPCLib.User user = Mapper.Map<gRPCLibServer.User, gRPCLib.User>(item);
                    resp.Users.Add(user);
                }
                return resp;
            }
        }
    }
}
