using Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbEntities : DbContext
    {
        public DbEntities()
        {
        }
        public DbEntities(DbConnection connection, bool contextOwnsConnection) 
            : base(connection, contextOwnsConnection) 
        {
        }

        public IDbSet<Users> Users { get; set; }
        public IDbSet<UsersInfo> UsersInfo { get; set; }
        public IDbSet<ShoppingCarts> ShoppingCarts { get; set; }
        public IDbSet<Category> Category { get; set; }

    }
}
