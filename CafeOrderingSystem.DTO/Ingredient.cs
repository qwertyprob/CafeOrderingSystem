namespace CafeOrderingSystem.DTO;

public class Ingredient
{
    public Ingredient(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; }

    public decimal Price { get; }
}