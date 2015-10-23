using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbEntities : DbContext
    {
        public IDbSet<Users> Users { get; set; }
    }
}
