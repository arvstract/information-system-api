using IS.Application.Interfaces.Services;
using IS.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IS.Infrastructure
{
    public static class DependencyInjectionApplication
    {
        public static IServiceCollection Add(this IServiceCollection services)
        {
            // Register application services
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
