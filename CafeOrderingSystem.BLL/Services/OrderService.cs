using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.BLL.Services;

public static class OrderService
{
    private static Order _order;

    public static Order GetOrder()
    {
        if(_order == null)
        {
            throw new InvalidOperationException("No active order.");
        }
        
        return _order;
        
    }

    public static async Task<bool> MakeOrder(string order)
    {
        try
        {
            
            if (string.IsNullOrEmpty(order))
                throw new Exception("Order please!");

            var orderNamesList = NormalizeDishNames(order);
    
            var dishes = GetMenuFromService(orderNamesList);
            
            if(dishes.Count == 0)
                throw new Exception("We don't have so dishes! May you order smth from our menu?");
            
            var totalPrice = dishes.Sum(dish => dish.Price);

            var totalTime = dishes.Sum(dish => dish.TimeToCook);
            
            _order = new Order(dishes, new Random().Next(1,1000), totalPrice,totalTime);
            
            
            return true;

        }
        catch (Exception e)
        {
            throw;
        }
    }

    
    private static List<string> NormalizeDishNames(string order)
    {
        var orderNamesList = order.Split(',').ToList();

        for (int i = 0; i < orderNamesList.Count; i++)
        {
            var word = orderNamesList[i].Trim().ToCharArray();

            if (word.Length > 0) word[0] = char.ToUpper(word[0]);

            orderNamesList[i] = new string(word);
        }

        return orderNamesList;
    }
    private static Queue<Dish> GetMenuFromService(List<string> orderedMenu)
    {
        var dishes = MenuService.GetMenu()
            .Where(dish => orderedMenu.Contains(dish.Name));
        
        return new Queue<Dish>(dishes);


    } 
}