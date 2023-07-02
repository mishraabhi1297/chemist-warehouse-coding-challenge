using Microsoft.Extensions.DependencyInjection;

namespace PizzaShop;

public static class Startup
{
    public static IServiceCollection ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<App>();

        return services;
    }
}
