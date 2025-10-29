using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Factories.DishFactory;

public class TomatoeSoupFactory : IDishFactory
{
    public Dish CreateDish()
    {
        var ingredients = new[]
        {
            new Ingredient("Water", 0.50m),
            new Ingredient("Potato", 2.00m),
            new Ingredient("Onion", 2.00m),
            new Ingredient("Carrot", 2.00m),
            new Ingredient("Salt", 1.00m),
            new Ingredient("Pepper", 1.00m)
        };

        return new Dish(
            "Tomatoe soup",
            "Tasty healthy soup",
            13,
            ingredients
        );
    }
}