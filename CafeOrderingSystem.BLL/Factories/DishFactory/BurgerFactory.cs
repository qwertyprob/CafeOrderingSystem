using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Factories.DishFactory;

public class BurgerFactory : IDishFactory
{
    public Dish CreateDish()
    {
        var ingredients = new[]
        {
            new Ingredient("Bun", 2.00m),
            new Ingredient("Beef Patty", 6.00m),
            new Ingredient("Cheese", 2.00m),
            new Ingredient("Lettuce", 1.50m),
            new Ingredient("Tomato", 1.50m),
            new Ingredient("Onion", 1.00m),
            new Ingredient("Sauce", 1.00m)
        };

        return new Dish(
            "Burger",
            "Juicy beef burger with cheese",
            7,
            ingredients
        );
    }
}