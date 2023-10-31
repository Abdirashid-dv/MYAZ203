namespace AstronomyApp.Models;

public abstract class SpaceShip
{
    // Constructor
    protected SpaceShip(string name, double mass, double fuel, int crewCapacity, double thrust, double specificImpulse)
    {
        Name = name;
        Mass = mass;
        Fuel = fuel;
        CrewCapacity = crewCapacity;
        Thrust = thrust;
        SpecificImpulse = specificImpulse;
    }


    // Properties
    public string Name { get; set; }

    public double Mass { get; set; }

    public double Fuel { get; set; }

    public int CrewCapacity { get; set; }

    public double Thrust { get; set; }

    public double SpecificImpulse { get; set; }


    // Methods
    public abstract void Launch();

    public abstract void Land();

    public void TravelTo(Planet planet)
    {

        var travelTime =
       planet.Distance / CalculateTravelDistance(CalculateDeltaV(planet.Gravity));
        System.Console.WriteLine($"Travel Time to {planet.Name}: {travelTime}");

    }

    protected double CalculateDeltaV(double Gravity)
    {
        var deltaV = SpecificImpulse + Gravity * Math.Log((Mass + Fuel) / Mass);

        return deltaV;
    }

    protected double CalculateTravelDistance(double deltaV)
    {
        var TravelDistance = 2 * deltaV / (Thrust * 1000);

        return TravelDistance;
    }



}