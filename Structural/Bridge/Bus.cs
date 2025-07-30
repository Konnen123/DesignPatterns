namespace DesignPatterns.Structural.Bridge;

public class Bus : Vehicle
{
    public Bus(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2)
    {
    }

    public override void Create()
    {
        Console.WriteLine("Bus ");
        workshop1.Work();
        workshop2.Work();
    }
}