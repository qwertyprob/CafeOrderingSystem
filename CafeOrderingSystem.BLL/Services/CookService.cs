using CafeOrderingSystem.BLL.Factories.CookFactory;
using CafeOrderingSystem.BLL.InterfacesUi;
using CafeOrderingSystem.DTO;
using CafeOrderingSystem.BLL.Services;

namespace CafeOrderingSystem.BLL.Services;

public static class CookService
{
    private static Cook[] _cooks = GetCooks();

    private static IUi _ui;
    
    public static void Init(IUi ui)
    {
        _ui = ui;
    }
    
    public static async Task TakeOrder(Order order)
    {
        var tasks = new List<Task>();
        _ui.ShowMessageAsync($"\t\n Cassier: Wait {order.TotalTime} seconds");
        await Task.Delay(800); 
        _ui.ShowMessageAsync(".");
        await Task.Delay(800); 
        _ui.ShowMessageAsync(".");
        await Task.Delay(800); 
        _ui.ShowMessageAsync(".");
        await Task.Delay(800); 
        while (order.OrderDishes.Count > 0)
        {
            foreach (var cook in _cooks)
            {
                if (cook.isBusy) continue; 

                if (order.OrderDishes.TryDequeue(out var dish))
                {
                    tasks.Add(GiveDishToCook(cook, dish));
                }
            }

            await Task.Delay(800); 
        }

        await Task.WhenAll(tasks);
        await _ui.ShowMessageAsync("\t\n Cassier: Your order is done!\n");
            
        
    }


    private static Cook[] GetCooks()
    {
        var factory = new CookFactory();
        return factory.CreateCooks();
    }

    private static async Task GiveDishToCook(Cook cook, Dish dish)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        await _ui.ShowMessageAsync($"\t\n Kitchen: {cook.Name} took:{dish.Name}!");
        
        cook.isBusy = true;
        await Task.Delay(dish.TimeToCook * 1000);
        
        
        Console.ForegroundColor = ConsoleColor.Green;
        await _ui.ShowMessageAsync($"\t\n Kitchen: {cook.Name} finished {dish.Name}");
        cook.isBusy = false;
        Console.ResetColor();
        
        
    }
    
}