using GrpcServiceApp.Common.Db;
using GrpcServiceApp.IDao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServiceApp.Dao
{
    public class ProjUnitDao:IProjUnitDao
    {
        private OracleDataBase odb;

        public ProjUnitDao(OracleDataBase db)
        {
            this.odb = db;
        }

        public DataSet QueryAllProjUnit()
        {
            string sql = "select * from YS_T_XMKPROJUNIT";
            return odb.Query(sql);
        }
    }
}
