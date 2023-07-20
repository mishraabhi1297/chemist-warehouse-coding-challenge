using PizzaShop.Models;
using PizzaShop.Repositories.Interfaces;

namespace PizzaShop.Repositories;

public class LocationRepository : ILocationRepository
{
    private readonly List<Location> _locations = new();

    public void Add(Location location)
    {
        _locations.Add(location);
    }

    public List<Location> GetLocations()
    {
        return _locations;
    }
}
