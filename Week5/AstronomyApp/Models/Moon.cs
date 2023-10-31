namespace AstronomyApp.Models;

public class Moon : CelestialBody
{
    // Property
    public Planet ParentPlanet { get; set; }

    // Constructor
    public Moon(string name, double mass, double radius, Planet parentPlanet) : base(name, mass, radius)
    {
        ParentPlanet = parentPlanet;
    }

    // Methods
    public override void Describe()
    {
        throw new NotImplementedException();
    }
}