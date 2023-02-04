using Your_Garage.Interfaces;

namespace Your_Garage.Cars;

public class Corolla : Vehicle, IGround
{
    public int BatteryCapacity { get; set; }
    public Corolla(string name)
    {
        Name = name;
    }

    public void Drive()
    {
        Console.WriteLine($"{Name} Corolla driving.");
    }

    public void Brake()
    {
        Console.WriteLine($"{Name} Corolla braking.");
    }
}