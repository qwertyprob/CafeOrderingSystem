namespace CafeOrderingSystem.DTO;

public class Order
{
    public Order(Queue<Dish> orderDishes,int orderId, decimal totalPrice,int totalTime)
    {
        OrderId = orderId;
        OrderDishes = orderDishes;
        TotalPrice = totalPrice;
        TotalTime = totalTime;
    }

    public int OrderId { get; set; }
    public Queue<Dish> OrderDishes { get; set; }
    public decimal TotalPrice { get; set; }

    public int TotalTime { get; set; }
}