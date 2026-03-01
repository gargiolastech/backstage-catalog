using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Modules.{{ moduleName }}.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection Add{{ moduleName }}Persistence(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var cs = configuration.GetConnectionString("Default")
                 ?? throw new InvalidOperationException("Missing ConnectionStrings:Default");

        services.AddDbContext<{{ moduleName }}DbContext>(opt =>
        {
            opt.UseNpgsql(cs, npgsql =>
            {
                // migrations per module (optional but recommended)
                npgsql.MigrationsAssembly(typeof(MigrationsAssemblyMarker).Assembly.FullName);
                npgsql.MigrationsHistoryTable("__EFMigrationsHistory", {{ moduleName }}DbContext.Schema);
            });
        });

        return services;
    }
}
