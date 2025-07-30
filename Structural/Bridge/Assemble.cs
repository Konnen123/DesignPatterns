namespace DesignPatterns.Structural.Bridge;

public class Assemble : IWorkshop
{
    public void Work()
    {
        Console.WriteLine("Assemble ");
    }
}