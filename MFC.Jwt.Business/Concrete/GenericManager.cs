using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MFC.Jwt.Business.Interfaces;
using MFC.Jwt.DataAccess.Interfaces;
using MFC.Jwt.Entities.Interfaces;

namespace MFC.Jwt.Business.Concrete
{
    public class GenericManager<TEntity>:IGenericService<TEntity> where TEntity:class,IEntity,new()
    {
        private readonly IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task<List<TEntity>> GetAll()
        {
            return await _genericDal.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _genericDal.GetById(id);
        }

        public async Task Update(TEntity entity)
        {
            await _genericDal.Update(entity);
        }

        public async Task Add(TEntity entity)
        {
            await _genericDal.Add(entity);
        }

        public async Task Remove(TEntity entity)
        {
            await _genericDal.Remove(entity);

        }
    }
}
