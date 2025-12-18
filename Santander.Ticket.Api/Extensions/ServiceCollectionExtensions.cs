using Santander.Ticket.Infrastructure;
using Santander.Ticket.Application;

namespace Santander.Ticket.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        services.AddOpenApi();
        services.AddInfrastructure(configuration);
        services.AddApplication();
        services.AddRouting(options =>
        {
            options.LowercaseUrls = true;
        });

        return services;
    }

    public static IServiceCollection AddUseCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll",
                policy => policy
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });

        return services;
    }
}
