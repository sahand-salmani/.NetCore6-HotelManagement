using Infrastructure.Database;

namespace Infrastructure.Commons.Repositories
{
    public class Persistence : IPersistence
    {
        private readonly DatabaseContext _context;

        public Persistence(DatabaseContext context)
        {
            _context = context;
        }


        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
