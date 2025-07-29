using DesignPatterns.Creational.Factory.FactoryClassic;

namespace DesignPatterns.Creational.Factory.FactorySolid;

// By creating a concrete factory for each vehicle, the Factory design pattern respects the SOLID principle
public interface IFactoryVehicle
{
    public IVehicle CreateVehicle();
}