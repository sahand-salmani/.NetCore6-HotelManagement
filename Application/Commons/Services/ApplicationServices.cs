using System.Reflection;
using Application.Commons.JwtTokenSettings;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Commons.Services
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            var setting = new JwtSetting();
            var value = configuration.GetSection(nameof(JwtSetting));
            setting.Secret = value["Secret"];
            services.AddSingleton(setting);
            return services;
        }
    }
}
