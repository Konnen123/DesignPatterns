namespace DesignPatterns.Creational.AbstractFactory.Shoes;

public class Boots : IShoes
{
    public void Print()
    {
        Console.WriteLine("Boots for the winter");
    }
}