namespace DesignPatterns.Structural.Bridge;

public abstract class Vehicle
{
    protected readonly IWorkshop workshop1;
    protected readonly IWorkshop workshop2;

    public Vehicle(IWorkshop workshop1, IWorkshop workshop2)
    {
        this.workshop1 = workshop1;
        this.workshop2 = workshop2;
    }

    abstract public void Create();
}