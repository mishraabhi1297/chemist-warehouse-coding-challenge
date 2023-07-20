namespace PizzaShop.Models;

public class Location
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Pizza> AvailablePizzas { get; set; } = new();
}
