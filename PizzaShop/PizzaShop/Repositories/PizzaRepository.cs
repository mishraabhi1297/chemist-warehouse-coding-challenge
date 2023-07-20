using PizzaShop.Models;

namespace PizzaShop.Repositories;

public class PizzaRepository
{
    private readonly List<Pizza> _pizzas = new();

    public void Add(Pizza pizza)
    {
        _pizzas.Add(pizza);
    }
}
