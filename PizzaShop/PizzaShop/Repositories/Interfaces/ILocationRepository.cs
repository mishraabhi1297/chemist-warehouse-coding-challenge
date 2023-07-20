using PizzaShop.Models;

namespace PizzaShop.Repositories.Interfaces;

public interface ILocationRepository
{
    void Add(Location location);
    List<Location> GetLocations();
}
