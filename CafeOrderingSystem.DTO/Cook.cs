namespace CafeOrderingSystem.DTO;

public class Cook
{
    public string Name { get; set; }
    
    public bool isBusy { get; set; }

    public Cook(string name)
    {
        Name = name;
        isBusy = false;
    }

}