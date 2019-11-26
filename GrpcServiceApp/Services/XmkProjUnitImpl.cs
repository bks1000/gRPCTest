using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using GrpcServiceApp.Dao;

namespace GrpcServiceApp.Services
{
    public class XmkProjUnitImpl:XmkProjUnitService.XmkProjUnitServiceBase
    {
        private OracleDbContext Ctx = null;

        public XmkProjUnitImpl(OracleDbContext ctx) 
        {
            this.Ctx = ctx;
        }

        public override Task<XmkProjUnit> QueryProjUnit(QueryProjUnitRequest request, ServerCallContext context)
        {
            //List<Dto.XMKPROJUNIT> xMKPROJUNIT = this.Ctx.ProjUnit.AsQueryable().Where(u => u.ProCode == request.ProCode).ToList();
            Dto.YS_T_XMKPROJUNIT xMKPROJUNIT = this.Ctx.ProjUnit.ToList().Find(u => u.ProCode == request.ProCode);
            GrpcServiceApp.XmkProjUnit resp = Mapper.Map<Dto.YS_T_XMKPROJUNIT, GrpcServiceApp.XmkProjUnit>(xMKPROJUNIT);
            return Task.FromResult(resp);
        }
    }
}
