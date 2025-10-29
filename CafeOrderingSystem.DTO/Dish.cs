namespace CafeOrderingSystem.DTO;

public class Dish
{
    public Dish(string name, string description, int minutes, Ingredient[] ingredients)
    {
        Name = name;
        Description = description;
        Ingredients = ingredients;
        Price = GetPrice(ingredients);
        TimeToCook = minutes;
    }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public int TimeToCook { get; set; }

    public Ingredient[] Ingredients { get; set; }

    public decimal GetPrice(Ingredient[] ingredients)
    {
        return ingredients.Sum(ingredient => ingredient.Price) + 20.0m / 100.0m;
    }
}