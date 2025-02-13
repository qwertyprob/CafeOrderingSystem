using CafeOrderingSystem.Factories;
using CafeOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CafeOrderingSystem.Services
{
    public class OrderService
    {

        public Queue<Dish> Orders = new Queue<Dish>();

        //Cookers
        private List<Cook> cookTeam = CookFactory.CreateCookTeam("Josh");

        public Queue<Dish> GetTheOrder(params string[] names)
        {
            Console.WriteLine("Cashier: Your Order INFO:\n");
            foreach (var name in names)
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    Orders.Enqueue(DishFactory.CreateDish(name));
                }
            }
            return Orders;
        }
        public void DiscardOrderInfo()
        {
            int counter = 1;
            decimal priceForAll = 0;
            int timeCounter = 0;

            foreach (Dish dish in Orders)
            {
                
                    priceForAll += dish.Price;
                
                timeCounter += dish.EstimatedMinutes;
                Console.Write($"\t#{counter}: {string.Join(",", dish.Name)}");
                Console.WriteLine($"\t\tPrice: {dish.Price}$");

                counter++;
            }
            Console.WriteLine($"\tWait Time: {timeCounter} minutes\t\tTotal: {priceForAll}$");

    
            
        
        }
        public void ReceiveOrder()
        {
            
            Console.WriteLine("\nSystem: Order is received!\n");
            foreach (Dish dish in Orders)
            {
                Cook? availableCook = cookTeam
                .Where(c => c.IsAvailable)
                .OrderBy(c => c.GetTotalWorkload())
                .FirstOrDefault();

                if (availableCook != null)
                {
                    availableCook.AssignOrder(dish); 
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception($"\tNo cooks available");
                    
                }
            }
            


        }
        


    }
}
