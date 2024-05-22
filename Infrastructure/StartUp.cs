using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class StartUp
{
    public static IServiceCollection AddInfrastructure (this IServiceCollection services)
    {
        return services;
    }
}
