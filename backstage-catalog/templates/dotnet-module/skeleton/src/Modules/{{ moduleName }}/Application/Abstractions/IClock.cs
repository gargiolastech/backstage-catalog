namespace MyApp.Modules.{{ moduleName }}.Application.Abstractions;

public interface IClock
{
    DateTimeOffset UtcNow { get; }
}
