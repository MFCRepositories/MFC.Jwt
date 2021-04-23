using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MFC.Jwt.Entities.Concrete;
using MFC.Jwt.Entities.Interfaces;

namespace MFC.Jwt.DataAccess.Interfaces
{
    public interface IProductDal : IGenericDal<Product>
    {
    }
}
