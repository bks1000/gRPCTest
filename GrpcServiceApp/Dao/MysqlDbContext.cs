using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServiceApp.Dao
{
    public class MysqlDbContext:DbContext
    {
        public MysqlDbContext(DbContextOptions<MysqlDbContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
