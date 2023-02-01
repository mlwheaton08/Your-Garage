namespace Your_Garage;

public class Aircraft : Vehicle
{
    public void Fly(string name)
    {
        Console.WriteLine($"{name} flying");
    }
    public void Land(string name)
    {
        Console.WriteLine($"{name} landing");
    }
}