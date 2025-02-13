using CafeOrderingSystem.Factories;
using CafeOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Servieces
{
    public static class MenuService
    {
        public static Dish[] AllDishes = CreateDishesFromFactory();

        public static Dish[] CreateDishesFromFactory()
        {
            Dish[] dishes = new Dish[]
            {
                DishFactory.CreateDish("salad"),
                DishFactory.CreateDish("soup"),
                DishFactory.CreateDish("sandwich"),
                DishFactory.CreateDish("steak"),
                DishFactory.CreateDish("pizza"),
                DishFactory.CreateDish("omelette"),
                DishFactory.CreateDish("burger"),
                DishFactory.CreateDish("pasta"),

            };

            return dishes;
        }
            

        public static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MENU:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var dish in AllDishes) 
            {
                Console.WriteLine($"\tDish: {dish.Name}");
                Console.WriteLine($"\tIngredients:{string.Join(",", dish.Ingredients.Select(x => x.Name))}");
                Console.WriteLine($"\tPrice: {dish.Price}$\n");
                
            } 
        }
    }
}
