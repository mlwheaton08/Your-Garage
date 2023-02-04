using Your_Garage.Interfaces;

namespace Your_Garage.Watercrafts;

public class Superboat : Vehicle, IWater
{
    public Superboat(string name)
    {
        Name = name;
    }

    public void Drive()
    {
        Console.WriteLine($"{Name} superboat driving.");
    }

    public void Dock()
    {
        Console.WriteLine($"{Name} superboatboat docking.");
    }

    public void SelfDock()
    {
        Console.WriteLine("Self docking...");
    }
}