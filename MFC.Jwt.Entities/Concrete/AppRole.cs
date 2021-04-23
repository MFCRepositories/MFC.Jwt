using System;
using System.Collections.Generic;
using System.Text;
using MFC.Jwt.Entities.Interfaces;

namespace MFC.Jwt.Entities.Concrete
{
    public class AppRole:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AppUserRole> AppUserRoles { get; set; }
    }
}
