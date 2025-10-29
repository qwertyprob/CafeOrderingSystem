namespace CafeOrderingSystem.BLL.InterfacesUi;

public class ConsoleUi:IUi
{
    public async Task ShowMessageAsync(string message)
    {
        Console.Write(message);
    }
}