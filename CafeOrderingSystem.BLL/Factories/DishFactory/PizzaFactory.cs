using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Factories.DishFactory;

public class PizzaFactory : IDishFactory
{
    public Dish CreateDish()
    {
        var ingredients = new[]
        {
            new Ingredient("Pizza Sauce", 1m),
            new Ingredient("Cheeze", 2m),
            new Ingredient("Pepperoni", 5m),
            new Ingredient("Oregano", 1m)
        };

        return new Dish(
            "Pizza",
            "Delicious cheesy pizza with pepperoni",
            12,
            ingredients
        );
    }
}