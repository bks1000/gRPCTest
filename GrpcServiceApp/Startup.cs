using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcServiceApp.Common.Db;
using GrpcServiceApp.Dao;
using GrpcServiceApp.IDao;
using GrpcServiceApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GrpcServiceApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            AutoMapper.Mapper.Initialize(conf => conf.AddConditionalObjectMapper());    //初始化Mapper
            this.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //gRPC
            services.AddGrpc();
            //oracle
            //Oracle.EntityFrameworkCore
            services.AddDbContext<OracleDbContext>(opts=>opts.UseOracle(Configuration.GetConnectionString("oracon")));
            
            //oracle.ManagedDataAccess.Core
            services.AddSingleton<OracleDataBase>(new OracleDataBase(Configuration.GetConnectionString("oracon")));
            //mysql
            services.AddDbContext<MysqlDbContext>(opts => opts.UseMySQL(Configuration.GetConnectionString("mysqlconstr")));

            //IOC
            services.AddTransient<IProjUnitDao, ProjUnitDao>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GreeterService>();
                endpoints.MapGrpcService<UserServiceImpl>();
                endpoints.MapGrpcService<XmkProjUnitImpl>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
    }
}
