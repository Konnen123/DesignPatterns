using DesignPatterns.Creational.Factory.FactoryClassic;

namespace DesignPatterns.Creational.Factory.FactorySolid;

public class AroFactory : IFactoryVehicle
{
    public IVehicle CreateVehicle()
    {
        return new Aro();
    }
}