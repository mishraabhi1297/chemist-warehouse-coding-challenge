using PizzaShop.Models;
using PizzaShop.Repositories.Interfaces;
using PizzaShop.Services.Interfaces;

namespace PizzaShop;

public class App
{
    private readonly IApplicationMenuService _applicationMenuService;
    private readonly ILocationRepository _locationRepository;

    public App(IApplicationMenuService applicationMenuService,
        ILocationRepository locationRepository)
    {
        _applicationMenuService = applicationMenuService;
        _locationRepository = locationRepository;
    }
    
    public async Task Run()
    {
        var loc1 = new Location
        {
            Id = 1000,
            Name = "Preston Pizzeria"
        };
        loc1.AvailablePizzas.Add(GetPizza(1001, "Capricciosa", 20));
        loc1.AvailablePizzas.Add(GetPizza(1002, "Mexicana", 18));
        loc1.AvailablePizzas.Add(GetPizza(1003, "Margherita", 22));
        
        var loc2 = new Location
        {
            Id = 2000,
            Name = "Southbank Pizzeria"
        };
        loc1.AvailablePizzas.Add(GetPizza(2001, "Capricciosa", 25));
        loc1.AvailablePizzas.Add(GetPizza(2002, "Vegetarian", 17));
        
        _locationRepository.Add(loc1);
        _locationRepository.Add(loc2);
        
        _applicationMenuService.DisplayMenu();
    }

    private static Pizza GetPizza(long id, string name, decimal price)
    {
        return new Pizza
        {
            Id = id,
            Name = name,
            Price = price
        };
    }
}
