using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.SeedWork
{
    public interface IRepository<TEntity, TId> where TEntity : class, IEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetById(TId id);
        Task Insert(TEntity entity);
        void Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
