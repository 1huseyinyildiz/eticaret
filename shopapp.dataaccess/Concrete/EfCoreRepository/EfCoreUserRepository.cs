using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shopapp.dataaccess.Absract;
using shopapp.entity;
namespace shopapp.dataaccess.Concrete.EfCoreRepository
{
    public class EfCoreUserRepository : EfCoreGerenericRepository<User, EfShopContext>, IUserRepository
    {
        public User Login(User user)
        {

            User _user = new User()
            {
                Password = "x15471547x",
                UserName = "1huseyinyildiz",
                Email = "huseyin_yildiz35@hotmail.com",
                Name = "Huseyin",
                Surname = "YILDIZ",
                IsActive = true
            };

            using (var context = new EfShopContext())
            {
                //var result = context.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).SingleOrDefault();
                return (_user.Password == user.Password && _user.UserName == user.UserName) ? 
                       _user : null;
                //return result != null ? result : null;
            }
        }
    }
}
