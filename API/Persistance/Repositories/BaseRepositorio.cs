using System.Collections.Generic;
using System.Threading.Tasks;
using API.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.Persistance.Repositories
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly Contexto _contexto;

        public BaseRepositorio(Contexto republicManagerContext)
        {
            _contexto = republicManagerContext;
        }

        public void Add(TEntity item)
        {
            _contexto.Set<TEntity>().Add(item);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _contexto.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _contexto.Set<TEntity>().ToListAsync();
        }

        public void Remove(int id)
        {
            var entity = _contexto.Set<TEntity>().Find(id);
            _contexto.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity item)
        {
            _contexto.Set<TEntity>().Update(item);
        }
        public void SetModifiedState(TEntity entity)
        {
            //This is the same doing the following ------->  db.Entry(person).State = EntityState.Modified;
            _contexto.Entry(entity).State = EntityState.Modified;
        }
    }
}
