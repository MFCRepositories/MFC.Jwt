using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MFC.Jwt.Entities.Interfaces;

namespace MFC.Jwt.Business.Interfaces
{
    public interface IGenericService<TEntity>
    where TEntity:class,IEntity,new()
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Update(TEntity entity);
        Task Add(TEntity entity);
        Task Remove(TEntity entity);
    }
}
