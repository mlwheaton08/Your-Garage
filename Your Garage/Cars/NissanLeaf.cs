using Your_Garage.Interfaces;

namespace Your_Garage.Cars;

public class NissanLeaf : Vehicle, IGround
{
    public int CoolFactor { get; set; }
    public NissanLeaf(string name)
    {
        Name = name;
    }

    public void Drive()
    {
        Console.WriteLine($"{Name} Nissan Leaf driving.");
    }

    public void Brake()
    {
        Console.WriteLine($"{Name} Nissan Leaf braking.");
    }
}