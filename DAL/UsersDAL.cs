using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDAL : BaseDAL<Users>, IUsersDAL
    {
        public int IsExistLoginCode(string loginCode)
        {
        int count=  dbContext.Users.Where(p => p.LoginCode.Equals(loginCode)).Count();

            return count;
        }
    }
}
