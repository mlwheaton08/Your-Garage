namespace Your_Garage;

public abstract class Vehicle //abstract means can't be instantiated (can't say new Vehicle)
{
    public int FuelCapacity { get; set; }
    public string Color { get; set; }
    public int PassengerOccupancy { get; set; }
    public string Name { get; set; }

    public void Refuel()
    {
        Console.WriteLine("Refueling");
    }
}