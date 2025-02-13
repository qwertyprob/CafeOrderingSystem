using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Models
{
    public class Dish
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int EstimatedMinutes { get; set; }
        public Ingredient[] Ingredients { get; set; }


        public Dish(string name, string description, int estimatedMinutes, Ingredient[] ingredients)
        {
            Description = description;
            Name = name;
            EstimatedMinutes = estimatedMinutes;
            Ingredients = ingredients;
            Price = GetPrice(ingredients);
        }

        private decimal GetPrice(Ingredient[] ingredients) => ingredients.Sum(i => i.Price) * 1.2m;




    }

}
