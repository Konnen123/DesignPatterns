namespace DesignPatterns.Creational.Factory.FactorySolid;

public class FactorySolidDemo
{
    public FactorySolidDemo()
    {
        var aroFactory = new AroFactory();
        var client = new VehicleClient(aroFactory);
        client.Vehicle.Print();
        
        var daciaFactory = new DaciaFactory();
        var daciaClient = new VehicleClient(daciaFactory);
        daciaClient.Vehicle.Print();
    }
}