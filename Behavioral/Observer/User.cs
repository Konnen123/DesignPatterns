namespace DesignPatterns.Behavioral.Observer;

public class User : IObserver
{
    public required string Name { get; init; }
    public void Update(string videoName)
    {
        Console.WriteLine($"A new video has been published: {videoName}");
    }
}