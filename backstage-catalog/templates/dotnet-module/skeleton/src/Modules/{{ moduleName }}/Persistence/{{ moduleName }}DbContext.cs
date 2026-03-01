using Microsoft.EntityFrameworkCore;

namespace MyApp.Modules.{{ moduleName }}.Persistence;

public sealed class {{ moduleName }}DbContext : DbContext
{
    public const string Schema = "{{ schemaName }}";

    public {{ moduleName }}DbContext(DbContextOptions<{{ moduleName }}DbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schema);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof({{ moduleName }}DbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
