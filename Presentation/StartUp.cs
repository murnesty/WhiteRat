﻿using Microsoft.Extensions.DependencyInjection;

namespace Presentation;

public static class StartUp
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}
