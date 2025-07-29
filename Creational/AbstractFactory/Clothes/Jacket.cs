namespace DesignPatterns.Creational.AbstractFactory.Clothes;

public class Jacket : IClothes
{
    public void Print()
    {
        Console.WriteLine("Jacket for the winter");
    }
}