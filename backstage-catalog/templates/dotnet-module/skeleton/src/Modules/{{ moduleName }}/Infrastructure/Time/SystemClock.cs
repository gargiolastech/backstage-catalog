using MyApp.Modules.{{ moduleName }}.Application.Abstractions;

namespace MyApp.Modules.{{ moduleName }}.Infrastructure.Time;

public sealed class SystemClock : IClock
{
    public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
}
