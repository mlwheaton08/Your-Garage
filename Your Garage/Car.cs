namespace Your_Garage;

public class Car : Vehicle
{
    public int BatteryCapacity { get; set; } = 100; //just a reminder can set default value like this

    public void Drive(string name)
    {
        Console.WriteLine($"{name} driving");
    }
    public void Brake()
    {
        Console.WriteLine("Braking");
    }
}