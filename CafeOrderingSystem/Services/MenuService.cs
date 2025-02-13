using CafeOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Servieces
{
    public static class MenuService
    {

       public static void ShowMenu(Dish[]dishes)
        {
            Console.WriteLine("MENU:");
            foreach (var dish in dishes) 
            {
                Console.WriteLine($"\tDish: {dish.Name}");
                Console.WriteLine($"\tIngredients:{string.Join(",", dish.Ingredients.Select(x => x.Name))}");
                Console.WriteLine($"\tPrice: {dish.Price}$\n");
                
            } 
        }
    }
}
