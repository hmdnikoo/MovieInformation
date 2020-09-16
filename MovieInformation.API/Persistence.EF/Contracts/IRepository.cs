using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieInformation.Domain;

namespace MovieInformation.API.Persistence.EF.Contracts
{
    public interface IRepository<TEntity>
    {
        Task<Guid> AddAsync(TEntity entity);

        void Delete(TEntity entity);
        void Update(TEntity entity);
        Task<TEntity> GetByIdAsync(Guid id);
        Task<List<TEntity>> GetAll();
    }
}
