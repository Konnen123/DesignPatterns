namespace DesignPatterns.Structural.Bridge;

public class Bike : Vehicle
{
    public Bike(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2)
    {
    }

    public override void Create()
    {
        Console.WriteLine("Bike ");
        workshop1.Work();
        workshop2.Work();
    }
}