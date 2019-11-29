using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServiceApp.Common.Db
{
    public class OracleDataBase
    {
        private readonly string connectionString;

        public OracleDataBase(string connString)
        {
            this.connectionString = connString;
        }

        public DataSet Query(string sql)
        {
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd))
                    {
                        dataAdapter.Fill(ds);
                    }
                }
            }
            return ds;
        }
    }
}
