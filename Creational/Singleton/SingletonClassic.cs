namespace DesignPatterns.Creational.Singleton;

public sealed class SingletonClassic
{
    private static SingletonClassic Instance { get; set; }
    private static object _locker = new object();

    private SingletonClassic()
    {
        
    }

    public static SingletonClassic GetInstance()
    {
        if (Instance == null)
        {
            lock (_locker)
            {
                if(Instance == null)
                    Instance = new SingletonClassic();
            }
        }
        
        return Instance;
    }

    public void Print()
    {
        Console.WriteLine("SingletonClassic Print");
    }
}