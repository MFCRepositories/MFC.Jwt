using System;
using System.Collections.Generic;
using System.Text;
using MFC.Jwt.Business.Interfaces;
using MFC.Jwt.DataAccess.Interfaces;
using MFC.Jwt.Entities.Concrete;

namespace MFC.Jwt.Business.Concrete
{
    public class AppUserManager:GenericManager<AppUser>,IAppUserService
    {
        public AppUserManager(IGenericDal<AppUser> genericDal) : base(genericDal)
        {
        }
    }
}
