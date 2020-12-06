using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface IUserService
    {
        User GetById(int id);

        void Create(User entity);

        void Update(User entity);

        void Delete(User entity);

        User Login(User entity);
    }
}
