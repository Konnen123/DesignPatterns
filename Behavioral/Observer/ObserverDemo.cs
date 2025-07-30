namespace DesignPatterns.Behavioral.Observer;

public class ObserverDemo
{
    public ObserverDemo()
    {
        Channel channel = new Channel()
        {
            Name = "Channel",
        };
        channel.VideoName = "My first video";

        List<IObserver> observers = new List<IObserver>()
        {
            new User()
            {
                Name = "User",
            },
            new User()
            {
                Name = "User2",
            }
        };

        foreach (var observer in observers)
        {
            channel.AddObserver(observer);
        }
        
        channel.NotifyObservers();
    }
}