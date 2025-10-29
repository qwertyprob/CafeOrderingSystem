using CafeOrderingSystem.BLL.InterfacesUi;
using CafeOrderingSystem.BLL.Services;
using CafeOrderingSystem.DTO;

namespace CafeOrderingSystem.ConsoleUI.Commands;

public static class ConsoleCommand
{
    private static int _counter = 1;

    private static readonly List<Dish> Dishes = MenuService.GetMenu();
    private static string Choice { get; set; } = " ";

    public static async Task Start()
    {
        Console.WriteLine("Cashier: Hi! What would you like to order? [y] - Yes / [n] - No\n");
        ListOfDishes();

        
        while (true)
        {
            Choice = Console.ReadLine() ?? string.Empty;

            if (Choice.Trim() == "q")
            {
                GreenConsoleText("Cassier");
                Console.WriteLine(": Have a nice day!");
                return;
            }

            var flag = await OrderService.MakeOrder(Choice);

            if (flag)
            {
                var order = OrderService.GetOrder();

                await GetOrderOnConsole(order);
                CookService.Init(new ConsoleUi());
                _ = CookService.TakeOrder(order);
            }
            else
            {
                Console.WriteLine($"Cassier : error");
            }

        }
    }

    private static async Task GetOrderOnConsole(Order order)
    {

        string line = new string('=', 30);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t{line}");
        Console.WriteLine($"\t=== Your Order ===");
        Console.WriteLine($"\t{line}");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\tOrder ID: {order.OrderId}");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\tOrdered dishes:");
        Console.ResetColor();

        foreach (var dish in order.OrderDishes)
        {
            Console.WriteLine($"\t - {dish.Name} : ${dish.Price:F2}");
        }

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\tTotal Price: ${order.TotalPrice:F2}");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\tTotal Time: {order.TotalTime} seconds");
        Console.ResetColor();

        // Нижняя рамка
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t{line}");
        Console.ResetColor();

    }

    private static void ListOfDishes()
    {
        Console.WriteLine();
        Console.WriteLine($"\t{new string('=', 76)}");
        Console.Write("\t| ");
        GreenConsoleText("MENU");
        Console.WriteLine();
        Console.WriteLine($"\t{new string('=', 76)}");

        foreach (var dish in Dishes)
        {
            Console.WriteLine($"\t| [{_counter}] {dish.Name}");
            Console.WriteLine($"\t|     Ingredients: {string.Join(',', dish.Ingredients.Select(x => x.Name))}");
            Console.WriteLine($"\t|     Price: {dish.Price}$\n");


            _counter++;
        }

        Console.WriteLine($"\t{new string('=', 76)}");
        Console.WriteLine();
        Console.WriteLine($"\t{new string('=', 76)}");
        Console.WriteLine();
    }

    private static void GreenConsoleText(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(text);
        Console.ResetColor();
    }

    private static void RedConsoleText(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(text);
        Console.ResetColor();
    }
}