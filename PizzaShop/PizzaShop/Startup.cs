using Microsoft.Extensions.DependencyInjection;
using PizzaShop.Repositories;
using PizzaShop.Repositories.Interfaces;
using PizzaShop.Services;
using PizzaShop.Services.Interfaces;

namespace PizzaShop;

public static class Startup
{
    public static IServiceCollection ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<App>();
        
        services.AddScoped<IApplicationMenuService, ApplicationMenuService>();

        services.AddScoped<ILocationRepository, LocationRepository>();

        return services;
    }
}
