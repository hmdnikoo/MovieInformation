using MovieInformation.Domain;
using System;
using System.Threading.Tasks;

namespace MovieInformation.Persistence.EF.Contracts
{
    public interface IGenericRepository<TAggregate> : IRepository where TAggregate : Entity, IAggregateRoot
    {
        Task AddAsync(TAggregate entity);

        void Update(TAggregate entity);

        void Delete(TAggregate entity);

        Task<TAggregate> GetByIdAsync(Guid id);
    }
}
