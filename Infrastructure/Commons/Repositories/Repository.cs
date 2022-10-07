using Domain.Common;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
#pragma warning disable CS8603

namespace Infrastructure.Commons.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : Entity, new()
    {
        private readonly DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<T> GetById(Guid id, CancellationToken cancellationToken = new())
        {
            return await _context.Set<T>().SingleOrDefaultAsync(e => e.Id == id, cancellationToken);
        }

        public async Task<T> GetByIdAsNoTracking(Guid id, CancellationToken cancellationToken = new())
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(e => e.Id == id, cancellationToken);
        }

        public async Task<List<T>> GetAll(CancellationToken cancellationToken = new())
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }

        public async Task<List<T>> GetAllAsNoTracking(CancellationToken cancellationToken = new())
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken = new())
        {
            if (entity is null)
            {
                throw new ArgumentNullException();
            }

            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.Set<T>().AddAsync(entity, cancellationToken);
        }

        public IQueryable<T> GetAllAsQueryable()
        {
            return _context.Set<T>();
        }

        public void Update(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException();
            }
            entity.UpdatedAt = DateTime.Now;
            _context.Update(entity);
        }

        public void Delete(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException();
            }

            _context.Remove(entity);
        }

    }
}
