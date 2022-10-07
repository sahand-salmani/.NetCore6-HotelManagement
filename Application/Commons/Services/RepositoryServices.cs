using Application.Hotels.Repositories;
using Infrastructure.Commons.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Commons.Services
{
    public static class RepositoryServices
    {
        public static void AddRepositoryService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPersistence, Persistence>();
            serviceCollection.AddTransient<IHotelRepository, HotelRepository>();
        }
    }
}
