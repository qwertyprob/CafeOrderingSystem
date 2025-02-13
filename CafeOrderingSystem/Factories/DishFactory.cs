using CafeOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Factories
{
    public static class DishFactory
    {
        public static Dish CreateDish(string name) 
        {
            var dishes = new Dictionary<string, Dish>
            {
                { "pasta", new Dish("Pasta", "Tasty Italian pasta",15 ,new Ingredient[]
                    {
                        new Ingredient("Pasta", 5.00m),
                        new Ingredient("Cheese", 5.00m),
                        new Ingredient("Tomato Sauce", 5.00m)
                    })
                },

                { "salad", new Dish("Salad", "Tasty healthy salad", 5 ,new Ingredient[]
                    {
                        new Ingredient("Lettuce", 1.00m),
                        new Ingredient("Cucumber", 2.00m),
                        new Ingredient("Tomato", 2.00m),
                        new Ingredient("Olive Oil", 3.00m),
                        new Ingredient("Salt", 1.00m),
                        new Ingredient("Pepper", 1.00m)
                    })
                },
                    { "soup", new Dish("Tomate Soup", "Tasty healthy soup", 10 ,new Ingredient[]
                        {
                            new Ingredient("Water", 0.50m),
                            new Ingredient("Potato", 2.00m),
                            new Ingredient("Onion", 2.00m),
                            new Ingredient("Carrot", 2.00m),
                            new Ingredient("Salt", 1.00m),
                            new Ingredient("Pepper", 1.00m)
                        })
                    },
                { "burger", new Dish("Cheeseburger", "Juicy beef burger with cheese", 15, new Ingredient[]
                    {
                        new Ingredient("Bun", 2.00m),
                        new Ingredient("Beef Patty", 6.00m),
                        new Ingredient("Cheese", 2.00m),
                        new Ingredient("Lettuce", 1.50m),
                        new Ingredient("Tomato", 1.50m),
                        new Ingredient("Onion", 1.00m),
                        new Ingredient("Sauce", 1.00m)
                    })
                },

                { "pizza", new Dish("Pepperoni Pizza", "Delicious cheesy pizza with pepperoni", 20, new Ingredient[]
                    {
                        new Ingredient("Pizza Dough", 5.00m),
                        new Ingredient("Tomato Sauce", 3.00m),
                        new Ingredient("Cheese", 4.00m),
                        new Ingredient("Pepperoni", 5.00m),
                        new Ingredient("Oregano", 1.00m)
                    })
                },

                { "omelette", new Dish("Cheese Omelette", "Fluffy omelette with cheese", 10, new Ingredient[]
                    {
                        new Ingredient("Eggs", 3.00m),
                        new Ingredient("Milk", 1.00m),
                        new Ingredient("Cheese", 3.00m),
                        new Ingredient("Salt", 0.50m),
                        new Ingredient("Pepper", 0.50m),
                        new Ingredient("Butter", 1.00m)
                    })
                },

                { "steak", new Dish("Grilled Steak", "Perfectly grilled steak with sides", 25, new Ingredient[]
                    {
                        new Ingredient("Beef Steak", 15.00m),
                        new Ingredient("Salt", 1.00m),
                        new Ingredient("Pepper", 1.00m),
                        new Ingredient("Garlic", 1.50m),
                        new Ingredient("Butter", 2.00m),
                        new Ingredient("Rosemary", 1.50m)
                    })
                },

                { "sandwich", new Dish("Club Sandwich", "Classic sandwich with turkey, bacon, and cheese", 12, new Ingredient[]
                    {
                        new Ingredient("Bread", 2.00m),
                        new Ingredient("Turkey", 4.00m),
                        new Ingredient("Bacon", 3.00m),
                        new Ingredient("Cheese", 2.00m),
                        new Ingredient("Lettuce", 1.00m),
                        new Ingredient("Tomato", 1.00m),
                        new Ingredient("Mayonnaise", 1.00m)
                    })
},


            };

            if (dishes.TryGetValue(name, out Dish dish))
                return dish;

            throw new Exception($"There is no dish as {name} in our cafe. Try something either.."); 
        }

        
    }
}
