using MyApp.Modules.{{ moduleName }}.Domain.Abstractions;

namespace MyApp.Modules.{{ moduleName }}.Domain.Example;

public sealed class ExampleAggregate : IAggregateRoot
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; } = "example";

    private ExampleAggregate() { }

    public static ExampleAggregate Create(string name) => new() { Name = name };
}
