using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Factories.DishFactory;

public class SandwishFactory:IDishFactory
{
    public Dish CreateDish()
    {
        var ingredients = new Ingredient[]
        {
            new Ingredient("Bread", 2.00m),
            new Ingredient("Turkey", 4.00m),
            new Ingredient("Bacon", 3.00m),
            new Ingredient("Cheese", 2.00m),
            new Ingredient("Lettuce", 1.00m),
            new Ingredient("Tomato", 1.00m),
            new Ingredient("Mayonnaise", 1.00m)
        };
        
        return new Dish("Sandwich", "Classic sandwich with turkey, bacon, and cheese", 5,ingredients);
    }
}