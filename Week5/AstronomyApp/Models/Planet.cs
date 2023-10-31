namespace AstronomyApp.Models;

public class Planet : CelestialBody
{

    // Constructor
    public Planet(string name, double mass, double radius, double distance) : base(name, mass, radius)
    {
        Distance = distance;
    }

    // Properties
    public double Distance { get; set; }

    // Methods
    public override void Describe()
    {
        throw new NotImplementedException();
    }
}