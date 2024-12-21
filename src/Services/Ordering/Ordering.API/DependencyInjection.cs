using BuildingBlocks.Exceptions.Handler;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Ordering.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            
            return services;
        }

        public static WebApplication UseApiServices(this WebApplication app)
        {
            

            return app;
        }
    }
}
