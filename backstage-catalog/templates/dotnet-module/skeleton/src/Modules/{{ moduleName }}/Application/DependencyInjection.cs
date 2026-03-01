using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Modules.{{ moduleName }}.Application;

public static class DependencyInjection
{
    public static IServiceCollection Add{{ moduleName }}Application(this IServiceCollection services)
    {
        // Register CQRS handlers, validators, pipeline behaviors, etc.
        return services;
    }
}
