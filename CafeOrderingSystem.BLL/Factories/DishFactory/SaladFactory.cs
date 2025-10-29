using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Factories.DishFactory;

public class SaladFactory : IDishFactory
{
    public Dish CreateDish()
    {
        var ingredients = new[]
        {
            new Ingredient("Lettuce", 1m),
            new Ingredient("Cucumber", 2m),
            new Ingredient("Tomato", 2m),
            new Ingredient("Olive Oil", 3m),
            new Ingredient("Salt", 1m),
            new Ingredient("Pepper", 1m)
        };

        return new Dish(
            "Salad",
            "Tasty healthy salad",
            5,
            ingredients
        );
    }
}