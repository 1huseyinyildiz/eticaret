using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.entity
{
    public class User :IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public int CompanyId { get; set; }

        public int RoleId { get; set; }




    }
}
