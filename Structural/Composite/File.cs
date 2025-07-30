namespace DesignPatterns.Structural.Composite;

public class File : ITask
{
    public required string Name { get; init; }
    public void Display()
    {
        Console.WriteLine($"{nameof(File)}: {Name}");
    }
}