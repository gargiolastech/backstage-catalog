using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "{{ values.appName }}",
        Version = "v1"
    });

    options.AddServer(new OpenApiServer
    {
        Url = "{{ values.routePrefix }}"
    });
});

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders =
        ForwardedHeaders.XForwardedFor |
        ForwardedHeaders.XForwardedProto |
        ForwardedHeaders.XForwardedHost;
});

var app = builder.Build();

app.UseForwardedHeaders();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.RoutePrefix = "swagger";
    options.SwaggerEndpoint("./v1/swagger.json", "{{ values.appName }} v1");
});

app.MapGet("/health", () => Results.Ok(new
{
    status = "ok",
    utc = DateTime.UtcNow
}))
.WithName("Health")
.WithOpenApi();

app.MapGet("/api/info", (IConfiguration configuration) => Results.Ok(new
{
    environment = configuration["ASPNETCORE_ENVIRONMENT"] ?? "Unknown",
    app = "{{ values.projectName }}"
}))
.WithName("Info")
.WithOpenApi();

app.Run();
