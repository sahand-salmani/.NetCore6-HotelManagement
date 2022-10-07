using Domain.Common;

namespace Infrastructure.Commons.Repositories
{
    public interface IRepository<T>
        where T : Entity
    {
        Task<T> GetById(Guid id, CancellationToken cancellationToken = new());
        Task<T> GetByIdAsNoTracking(Guid id, CancellationToken cancellationToken = new());
        Task<List<T>> GetAll(CancellationToken cancellationToken = new());
        Task<List<T>> GetAllAsNoTracking(CancellationToken cancellationToken = new());
        Task AddAsync(T entity, CancellationToken cancellationToken = new());
        IQueryable<T> GetAllAsQueryable();
        void Update(T entity);
        void Delete(T entity);
    }
}
