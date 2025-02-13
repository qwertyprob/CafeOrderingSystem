#region Task
/*
- Write a console application
- Try to write clean and maintainable code
Let's assume we need to write a simple ordering system for a café.
For the system we identified classes with following fields (feel free to add additional, if see need):
Cook: name
Ingredient: name, price
Dish: name, description, price, estimated cooking time (int minutes)

1. Menu: on application start, show list of all dishes: name, description, contents (comma-
separated list of ingredients), price (sum of all ingredients + 20%).

2. Order dish
• Enter name of dish
• Order should be assigned to a cook (any) with least number of dishes in progress.
• Cook can't be assigned more than 5 dishes.
• As response, return estimated cooking finish time (depends on how many dishes are
assigned to cook).
• In case all the cookers are busy show message “No cooks available”.

It's ok if you implemented only part of requirements. Try do what you can and have fun!
*/
#endregion

using CafeOrderingSystem.Factories;
using CafeOrderingSystem.Models;
using CafeOrderingSystem.Services;
using CafeOrderingSystem.Servieces;
using CafeOrderingSystem.Commands;

namespace CafeOrderingSystem
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
             
            MenuService.ShowMenu();

            try
            {
                Commands.Commands.Start();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ResetColor();



        }

    }
}