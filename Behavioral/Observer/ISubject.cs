namespace DesignPatterns.Behavioral.Observer;

public interface ISubject
{
    public string Name { get; init; }
    public string VideoName { get; set; }
    public void AddObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
}