using Domain.Entities;
using Infrastructure.Commons.Repositories;
using Infrastructure.Database;

namespace Application.Hotels.Repositories
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        public HotelRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
