using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyApp.Modules.{{ moduleName }}.Domain.Example;

namespace MyApp.Modules.{{ moduleName }}.Persistence.Configurations;

public sealed class ExampleAggregateConfiguration : IEntityTypeConfiguration<ExampleAggregate>
{
    public void Configure(EntityTypeBuilder<ExampleAggregate> builder)
    {
        builder.ToTable("example_aggregates");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
    }
}
