namespace DesignPatterns.Structural.Composite;

public class Folder : ITask
{
    public required string Name { get; init; }
    public List<ITask> Files { get; init; }

    public Folder()
    {
        Files = new List<ITask>();
    }

    public void AddTask(ITask file)
    {
        Files.Add(file);
    }

    public void AddTasks(List<ITask> files)
    {
        Files.AddRange(files);
    }

    public void Display()
    {
        Console.WriteLine($"{nameof(Folder)}: {Name}");
        Console.WriteLine($"Files: ");
        foreach (var file in Files)
        {
            file.Display();
        }
        Console.WriteLine();
    }
}