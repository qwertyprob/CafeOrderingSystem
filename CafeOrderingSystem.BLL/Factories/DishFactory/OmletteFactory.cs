using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Factories.DishFactory;

public class OmeletteFactory:IDishFactory
{
    public Dish CreateDish()
    {
        var ingredients = new Ingredient[]
        {
            new Ingredient("Eggs", 3.00m),
            new Ingredient("Milk", 1.00m),
            new Ingredient("Cheese", 3.00m),
            new Ingredient("Salt", 0.50m),
            new Ingredient("Pepper", 0.50m),
            new Ingredient("Butter", 1.00m)
        };
        
        return new Dish("Omelette", "Fluffy omelette with cheese", 10, ingredients);
    }
}