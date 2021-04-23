using System;
using System.Collections.Generic;
using System.Text;
using MFC.Jwt.DataAccess.Interfaces;
using MFC.Jwt.Entities.Concrete;

namespace MFC.Jwt.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public  class EfProductRepository:EfGenericRepository<Product>,IProductDal
    {
    }
}
