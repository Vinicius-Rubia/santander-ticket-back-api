using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Santander.Ticket.Infrastructure.DataAccess;

namespace Santander.Ticket.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
    }

    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SantanderDbContext>(x => x.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }
}
