using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Factories.CookFactory;

public class CookFactory:ICookFactory
{
    public Cook[] CreateCooks()
    {
        return new Cook[]
        {
            new Cook("Andrew"),
            new Cook("Toma"),
            new Cook("Antonio")
        };
        
    }
}