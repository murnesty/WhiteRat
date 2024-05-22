using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class StartUp
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(StartUp).Assembly;

        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(assembly));

        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}
