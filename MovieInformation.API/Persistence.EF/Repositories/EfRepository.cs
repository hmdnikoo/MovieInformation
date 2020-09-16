using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieInformation.API.Persistence.EF.Contracts;
using MovieInformation.Domain;

namespace MovieInformation.API.Persistence.EF.Repositories
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DbContext _db;
        public EfRepository(DbContext dbContext) => _db = dbContext;
        public async Task<Guid> AddAsync(TEntity entity)
        {
            await _db.Set<TEntity>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity.Id;
        }

        public void Delete(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
            _db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }
        public virtual Task<TEntity> GetByIdAsync(Guid id)
            => _db.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<TEntity>> GetAll()
            => await _db.Set<TEntity>().ToListAsync();
    }
}
