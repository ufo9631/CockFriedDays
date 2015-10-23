using IBLL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class UsersBLL:BaseBLL<Users>, IUsersBLL
    {
      public IUsersDAL UsersDAL { get; set; }
      public UsersBLL(IUsersDAL _UsersDAL)
      {
          UsersDAL = _UsersDAL;
          Initialize();
      }

      public override void Initialize()
      {
          DAL = UsersDAL;
      }
    }
}
