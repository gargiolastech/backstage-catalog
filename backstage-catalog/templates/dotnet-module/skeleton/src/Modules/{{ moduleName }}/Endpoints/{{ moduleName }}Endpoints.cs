using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace MyApp.Modules.{{ moduleName }}.Endpoints;

public static class {{ moduleName }}Endpoints
{
    public static IEndpointRouteBuilder Map{{ moduleName }}Endpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/api/{{ moduleName | lower }}")
            .WithTags("{{ moduleName }}");

        group.MapGet("/health", () =>
            Results.Ok(new { module = "{{ moduleName }}", status = "ok" }));

        return endpoints;
    }
}
