using Your_Garage.Interfaces;

namespace Your_Garage.Aircrafts;

public class Helicopter : Vehicle, IFlying
{
    public Helicopter(string name)
    {
        Name = name;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} helicopter flying.");
    }

    public void Land()
    {
        Console.WriteLine($"{Name} helicopter landing.");
    }
}