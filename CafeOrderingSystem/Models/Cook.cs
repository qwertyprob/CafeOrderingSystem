using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Models
{
    public class Cook
    {
        private Queue<Dish> Orders = new Queue<Dish>();
        public string Name { get; }
        public Cook(string name)
        {
            Name = name;
        }

        public bool IsAvailable { get { return Orders.Count < 5; } }

        public void AssignOrder(Dish dish)
        {
            if (IsAvailable)
            {
                Orders.Enqueue(dish);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t{Name} received: {dish.Name}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public int GetTotalWorkload()
        {
            return Orders.Sum(d => d.EstimatedMinutes);
        }

        


    }
}
