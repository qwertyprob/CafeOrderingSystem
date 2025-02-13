using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Models
{
    public class Dish
    {
        public string Name { get;  }

        public string Description { get;  }

        public decimal Price { get;  }

        public int EstimatedMinutes { get;  }
        public Ingredient[] Ingredients { get;  }


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
