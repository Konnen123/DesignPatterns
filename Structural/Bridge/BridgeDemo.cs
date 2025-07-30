namespace DesignPatterns.Structural.Bridge;

public class BridgeDemo
{
    public BridgeDemo()
    {
        IWorkshop produce = new Produce();
        IWorkshop assemble = new Assemble();
        Bike bike = new Bike(produce, assemble);
        Bus bus = new Bus(produce, assemble);
        
        bike.Create();
        bus.Create();
    }
}