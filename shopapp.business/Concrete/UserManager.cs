using shopapp.business.Abstract;
using shopapp.dataaccess.Absract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Concrete
{
    public class UserManager : IUserService
    {

        private IUserRepository userRepository;

        public UserManager(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public void Create(User entity)
        {



            userRepository.Create(entity);
        }

        public void Delete(User entity)
        {

            userRepository.Delete(entity);

        }

        public User GetById(int id)
        {
           return  userRepository.GetById(id);
        }


        public void Update(User entity)
        {

            userRepository.Update(entity);

        }
    }
}
