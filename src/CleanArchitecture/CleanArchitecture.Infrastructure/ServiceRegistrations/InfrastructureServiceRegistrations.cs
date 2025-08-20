using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.ServiceRegistrations;

public static class InfrastructureServiceRegistrations
{
    public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
    {

        //services.AddScoped<IBaseDbContext, BaseDbContext>();

        return services;
    }
    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        //app.UseMiddleware<EventualConsistencyMiddleware>();
        return app;
    }

}