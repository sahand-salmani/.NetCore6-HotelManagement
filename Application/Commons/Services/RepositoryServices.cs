using Application.Hotels.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Commons.Services
{
    public static class RepositoryServices
    {
        public static void AddRepositoryService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IHotelRepository, HotelRepository>();
        }
    }
}
