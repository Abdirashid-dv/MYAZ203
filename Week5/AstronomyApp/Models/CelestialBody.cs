namespace AstronomyApp.Models;

public abstract class CelestialBody
{

    // Constructor
    public CelestialBody(string name, double mass, double radius)
    {
        Name = name;
        Mass = mass;
        Radius = radius;
    }
    // Property
    public string Name { get; set; }
    public double Mass { get; set; }
    public double Radius { get; set; }

    // Methods
    public abstract void Describe();
}