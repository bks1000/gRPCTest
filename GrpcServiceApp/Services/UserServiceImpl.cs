using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using GrpcServiceApp.Dao;
using Microsoft.Extensions.Logging;

namespace GrpcServiceApp.Services
{
    public class UserServiceImpl : UserService.UserServiceBase
    {
        private MysqlDbContext Ctx = null;
        private readonly ILogger<UserServiceImpl> _logger;

        public UserServiceImpl(MysqlDbContext ctx, ILogger<UserServiceImpl> logger)
        {
            this.Ctx = ctx;
            this._logger = logger;
        }

        public override Task<RespGetAllUser> GetAllUser(ReqsNull request, ServerCallContext context)
        {
            _logger.LogInformation("当前调用的是GetAllUser()");
            return Task.FromResult(Query());
        }

        public override Task<RespGetOneUser> GetOneUser(ReqsGetOneUser request, ServerCallContext context)
        {
            Dao.User user = this.Ctx.User.Find(new object[] { request.Condition });

            //1.Auto Mapper，只是RespGetOneUser中含有User这样转换不行
            //Mapper.Initialize(x => x.CreateMap<User, RespGetOneUser>());
            //RespGetOneUser respuser = AutoMapper.Mapper.Map<RespGetOneUser>(user);

            //2.可以的(Initialize是静态方法，只需要执行一次即可)
            //Mapper.Initialize(x => x.CreateMap<gRPCLibServer.User, gRPCLib.User>());
            //gRPCLib.User respuser = AutoMapper.Mapper.Map<gRPCLib.User>(user);

            //3.在启动时，初始化Mapper，以后就可以通过这样的方式转换了，还是比较方便的。
            GrpcServiceApp.User respuser = Mapper.Map<Dao.User, GrpcServiceApp.User>(user);

            return Task.FromResult(new RespGetOneUser
            {
                User = respuser
            });
        }

        public override Task<SaveResult> Save(GrpcServiceApp.User request, ServerCallContext context)
        {

            //启动时已经初始化了Mapper，直接转换即可
            Dao.User user = Mapper.Map<GrpcServiceApp.User, Dao.User>(request);

            if (user.Id == "")
            {
                user.Id = Guid.NewGuid().ToString();
                this.Ctx.User.Add(user);
            }
            else
            {
                this.Ctx.User.Update(user);
            }

            int cnt = this.Ctx.SaveChanges();
            return Task.FromResult(new SaveResult { Result = cnt > 0 });

        }

        public override Task<SaveResult> Delete(GrpcServiceApp.User request, ServerCallContext context)
        {
            Dao.User user = Mapper.Map<GrpcServiceApp.User, Dao.User>(request);
            this.Ctx.User.Remove(user);

            int cnt = this.Ctx.SaveChanges();
            return Task.FromResult(new SaveResult { Result = cnt > 0 });
        }



        public RespGetAllUser Query()
        {
            RespGetAllUser resp = new RespGetAllUser();
            foreach (var item in this.Ctx.User)
            {
                GrpcServiceApp.User user = Mapper.Map<Dao.User, GrpcServiceApp.User>(item);
                resp.Users.Add(user);
            }
            return resp;
        }
    }
}
