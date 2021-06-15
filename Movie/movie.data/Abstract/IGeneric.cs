using System.Collections.Generic;

namespace movie.data.Abstract
{
    public interface IGeneric<TEntity>
    {
         List<TEntity> GetAll();
         TEntity GetById(int id);
         void Update(TEntity entity);
         void Delete(int id);
         void Add(TEntity entity);
    }
}