namespace AstronomyApp.Models;

public class Rocket : SpaceShip
{
    public Rocket(string name, double mass, double fuel, int crewCapacity, double thrust, double specificImpulse) : base(name, mass, fuel, crewCapacity, thrust, specificImpulse)
    {
    }

    public override void Land()
    {
        throw new NotImplementedException();
    }

    public override void Launch()
    {
        throw new NotImplementedException();
    }

}