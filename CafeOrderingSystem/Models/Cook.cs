using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Models
{
    public class Cook
    {
        public string Name { get; }
        public Cook(string name)
        {
            Name = name;
        }
        public bool CanTakeOrderFlag { get { return OrderCount < 5; } }
        public List<Dish> Orders { get; } = new List<Dish>();
        public int OrderCount { get { return Orders.Count; } }

        public void AddOrder(Dish dish)
        {
            if (!CanTakeOrderFlag)
            {
                throw new Exception("No cooks available");
            }
            Orders.Add(dish);

        }
        public void OrderMessage()
        {
            Console.WriteLine($"Order is taken by {Name}.\n Time to wait:{EstimateTimeFromOrders} minutes..");

        }

        public int EstimateTimeFromOrders
        {
            get { return Orders.Sum(x => x.EstimatedMinutes); }

        }
    }
}
