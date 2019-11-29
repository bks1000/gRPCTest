using GrpcServiceApp.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServiceApp.Dao
{
    //Oracle.EntityFrameworkCore
    //oracle数据库连不上，服务端必须是12版本以上，参考：https://dba.stackexchange.com/questions/142085/ora-01017-invalid-username-passwordlogon-denied
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions<OracleDbContext> options)
            : base(options)
        { }

        //在Startup.cs中配置了
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle();
            }
        }*/

        public DbSet<YS_T_XMKPROJUNIT> YS_T_XMKPROJUNIT { get; set; }
    }
}
