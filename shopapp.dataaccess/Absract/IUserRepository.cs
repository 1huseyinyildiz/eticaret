using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.dataaccess.Absract
{
   public interface IUserRepository : IRepository<User>
    {
        User Login(User user);
    }
}
