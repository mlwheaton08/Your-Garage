using Your_Garage.Interfaces;

namespace Your_Garage.Aircrafts;

public class Plane : Vehicle, IFlying
{
    public Plane(string name)
    {
        Name = name;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} plane flying.");
    }

    public void Land()
    {
        Console.WriteLine($"{Name} plane landing.");
    }
}