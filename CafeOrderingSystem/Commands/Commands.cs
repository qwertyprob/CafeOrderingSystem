using CafeOrderingSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Commands
{
    public static class Commands
    {
        
        public static void Start()
        {
            string choice;
            Console.WriteLine("Cashier: Hi! What would you like to order?(pasta,burger,pizza,steak,soup,salad,omelette,sandwich)\n");
            do
            {
                Console.Write("\nYou: ");
                choice = Console.ReadLine() ?? string.Empty;
                
                //to valid
                string[] dishes = choice.Split(new[] { ',', ' ',')','(' }, StringSplitOptions.RemoveEmptyEntries);
                if (dishes == null || dishes.Length == 0)
                {
                    Console.WriteLine(("Please,write your order!"));
                    continue;
                }
                
                var service = new OrderService();
                
                service.GetTheOrder(dishes);

                service.DiscardOrderInfo();
                service.ReceiveOrder();
                

            }
            while (choice != "q");
        }
    }
}
