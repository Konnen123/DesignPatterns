using DesignPatterns.Creational.Factory.FactoryClassic;

namespace DesignPatterns.Creational.Factory.FactorySolid;

public class VehicleClient
{
    public IVehicle Vehicle { get; init; }

    public VehicleClient(IFactoryVehicle factoryVehicle)
    {
        Vehicle = factoryVehicle.CreateVehicle();
    }
    
    
}