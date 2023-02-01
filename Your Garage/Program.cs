using Your_Garage;
using Your_Garage.Aircrafts;
using Your_Garage.Cars;
using Your_Garage.Watercrafts;


// Build a collection of all vehicles that fly
List<Aircraft> aircraftVehicles = new List<Aircraft>()
{
    new Helicopter("HeliMaster3000"),
    new Plane("Boeing 555555555555")
};
// With a single `foreach`, have each vehicle Fly()
aircraftVehicles.ForEach(x => x.Fly(x.Name));


// Build a collection of all vehicles that operate on roads
List<Car> carVehicles = new List<Car>()
{
    new Corolla("corolla 1"){BatteryCapacity = 85},
    new NissanLeaf("nissan leaf 1")
};
// With a single `foreach`, have each road vehicle Drive()
carVehicles.ForEach(x => x.Drive(x.Name));


// Build a collection of all vehicles that operate on water
List<Watercraft> waterVehicles = new List<Watercraft>()
{
    new FishingBoat("Ol' Reliable"),
    new Superboat("Wave Destroyer")
};
// With a single `foreach`, have each water vehicle Drive()
waterVehicles.ForEach(x => x.Drive(x.Name));