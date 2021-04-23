using System;
using System.Collections.Generic;
using System.Text;
using MFC.Jwt.Entities.Interfaces;

namespace MFC.Jwt.Entities.Concrete
{
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public List<AppUserRole> AppUserRoles { get; set; }

    }
}
