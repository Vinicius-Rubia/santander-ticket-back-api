using Microsoft.Extensions.DependencyInjection;

namespace Santander.Ticket.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddUseCases(services);
    }

    private static void AddUseCases(IServiceCollection services)
    {

    }
}
