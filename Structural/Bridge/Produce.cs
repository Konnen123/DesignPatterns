namespace DesignPatterns.Structural.Bridge;

public class Produce : IWorkshop
{
    public void Work()
    {
        Console.WriteLine("Produce ");
    }
}