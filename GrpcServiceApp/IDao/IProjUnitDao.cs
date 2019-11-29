using GrpcServiceApp.Common.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServiceApp.IDao
{
    public interface IProjUnitDao
    {
        public DataSet QueryAllProjUnit();
    }
}
