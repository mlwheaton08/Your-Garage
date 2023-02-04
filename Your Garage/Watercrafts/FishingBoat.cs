using Your_Garage.Interfaces;

namespace Your_Garage.Watercrafts;

public class FishingBoat : Vehicle, IWater
{
    public FishingBoat(string name)
    {
        Name = name;
    }

    public void Drive()
    {
        Console.WriteLine($"{Name} fishing boat driving.");
    }

    public void Dock()
    {
        Console.WriteLine($"{Name} fishing boat docking.");
    }
}