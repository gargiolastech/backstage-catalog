namespace MyApp.Modules.{{ moduleName }}.Domain.Abstractions;

public interface IDomainEvent
{
    DateTimeOffset OccurredOnUtc { get; }
}
