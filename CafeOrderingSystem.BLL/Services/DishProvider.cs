using CafeOrderingSystem.BLL.Factories.DishFactory;
using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Services;

public static class DishProvider
{
    public static List<Dish> GetMenu()
    {
        var dishes = new List<Dish>();

        IDishFactory factory;

        factory = new PizzaFactory();
        dishes.Add(factory.CreateDish());

        factory = new BurgerFactory();
        dishes.Add(factory.CreateDish());

        factory = new TomatoeSoupFactory();
        dishes.Add(factory.CreateDish());

        factory = new SaladFactory();
        dishes.Add(factory.CreateDish());
        
        factory = new OmeletteFactory();
        dishes.Add(factory.CreateDish());
        
        factory = new SandwishFactory();
        dishes.Add(factory.CreateDish());

        return dishes;
    }
}