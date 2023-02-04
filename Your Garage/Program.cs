using Your_Garage;
using Your_Garage.Aircrafts;
using Your_Garage.Cars;
using Your_Garage.Interfaces;
using Your_Garage.Watercrafts;


// Build a collection of all vehicles that fly
List<IFlying> aircraftVehicles = new List<IFlying>()
{
    new Helicopter("HeliMaster3000"),
    new Plane("Boeing 555555555555")
};
// With a single `foreach`, have each vehicle Fly()
aircraftVehicles.ForEach(x => x.Fly());


// Build a collection of all vehicles that operate on roads
List<IGround> carVehicles = new List<IGround>()
{
    new Corolla("corolla 1"){BatteryCapacity = 85},
    new NissanLeaf("nissan leaf 1")
};
// With a single `foreach`, have each road vehicle Drive()
carVehicles.ForEach(x => x.Drive());


// Build a collection of all vehicles that operate on water
List<IWater> waterVehicles = new List<IWater>()
{
    new FishingBoat("Ol' Reliable"),
    new Superboat("Wave Destroyer")
};
// With a single `foreach`, have each water vehicle Drive()
waterVehicles.ForEach(x => x.Dock());