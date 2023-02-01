namespace Your_Garage.Watercrafts;

public class Superboat : Watercraft
{
    public Superboat(string name)
    {
        Name = name;
    }
    public void SelfDock()
    {
        Console.WriteLine("Self docking...");
    }
}