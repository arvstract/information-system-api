using IS.Domain.Interfaces;
using IS.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace IS.Infrastructure
{
    public static class DependencyInjectionInfrastucture
    {
        public static IServiceCollection Add(this IServiceCollection services)
        {
            // Register application services
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
