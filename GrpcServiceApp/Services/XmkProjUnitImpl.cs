using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using GrpcServiceApp.Dao;
using GrpcServiceApp.IDao;
using Newtonsoft.Json;

namespace GrpcServiceApp.Services
{
 
    /// <summary>
    /// 两种数据库访问方式都可行
    /// </summary>
    public class XmkProjUnitImpl:XmkProjUnitService.XmkProjUnitServiceBase
    {
        private IProjUnitDao dao;
        private OracleDbContext Ctx = null;

        public XmkProjUnitImpl(IProjUnitDao dao, OracleDbContext ctx)
        {
            this.dao = dao;
            this.Ctx = ctx;
        }

        /// <summary>
        /// 采用Oracle.ManagedDataAccess.Core
        /// 手写ADO.NET方式
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<Data> QueryProjUnitAll(Nvl request, ServerCallContext context)
        {
            DataSet ds = dao.QueryAllProjUnit();
            string result = JsonConvert.SerializeObject(ds.Tables[0]);
            return Task.FromResult(new Data { Data_ = result });
        }

        /// <summary>
        /// 采用Oracle.EntityFrameworkCore
        /// EF Core方式
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<XmkProjUnit> QueryProjUnit(QueryProjUnitRequest request, ServerCallContext context)
        {
            List<Dto.YS_T_XMKPROJUNIT> xMKPROJUNIT = this.Ctx.YS_T_XMKPROJUNIT.ToList();
            Dto.YS_T_XMKPROJUNIT dto = xMKPROJUNIT.Find(u => u.PROCODE == request.ProCode);
            GrpcServiceApp.XmkProjUnit resp = Mapper.Map<Dto.YS_T_XMKPROJUNIT, GrpcServiceApp.XmkProjUnit>(dto);
            return Task.FromResult(resp);
        }
    }
}
