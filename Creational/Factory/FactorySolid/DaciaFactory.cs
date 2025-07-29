using DesignPatterns.Creational.Factory.FactoryClassic;

namespace DesignPatterns.Creational.Factory.FactorySolid;

public class DaciaFactory : IFactoryVehicle
{
    public IVehicle CreateVehicle()
    {
        return new Dacia();
    }
}