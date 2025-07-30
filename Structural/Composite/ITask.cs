namespace DesignPatterns.Structural.Composite;

public interface ITask
{
    public string Name { get; init; }
    public void Display();
}