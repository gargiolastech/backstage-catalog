using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Modules.{{ moduleName }}.Application.Abstractions;
using MyApp.Modules.{{ moduleName }}.Infrastructure.Time;

namespace MyApp.Modules.{{ moduleName }}.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection Add{{ moduleName }}Infrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddSingleton<IClock, SystemClock>();
        return services;
    }
}
