using PizzaShop.Repositories.Interfaces;
using PizzaShop.Services.Interfaces;

namespace PizzaShop.Services;

public class ApplicationMenuService : IApplicationMenuService
{
    private readonly ILocationRepository _locationRepository;

    public ApplicationMenuService(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }
    
    public void DisplayMenu()
    {
        Console.WriteLine("Select a location to place an order");

        foreach (var location in _locationRepository.GetLocations())
        {
            Console.WriteLine($"{location.Id}: {location.Name}");
        }

        var locationId = Console.ReadLine();
        
        Console.WriteLine(int.TryParse(locationId, out var result)
            ? $"The user selected: {result}"
            : "Invalid input provided by the user");
    }
}
