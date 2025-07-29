namespace DesignPatterns.Creational.Singleton;

public sealed class SingletonLazy
{
    public static readonly Lazy<SingletonLazy> Instance = new Lazy<SingletonLazy>(() => new SingletonLazy());

    private SingletonLazy()
    {
        
    }

    public void Print()
    {
        Console.WriteLine("SingletonLazy Print");
    }
}