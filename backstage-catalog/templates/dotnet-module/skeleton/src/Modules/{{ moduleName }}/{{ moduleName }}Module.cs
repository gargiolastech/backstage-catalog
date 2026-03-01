using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Modules.{{ moduleName }}.Application;
using MyApp.Modules.{{ moduleName }}.Infrastructure;
using MyApp.Modules.{{ moduleName }}.Persistence;

namespace MyApp.Modules.{{ moduleName }};

public static class {{ moduleName }}Module
{
    public static IServiceCollection Add{{ moduleName }}Module(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .Add{{ moduleName }}Application()
            .Add{{ moduleName }}Infrastructure(configuration)
            .Add{{ moduleName }}Persistence(configuration);

        return services;
    }
}
