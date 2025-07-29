namespace DesignPatterns.Creational.AbstractFactory;

public class AbstractFactoryDemo
{
    public AbstractFactoryDemo()
    {
        IAbstractFactory summerFactory = new SummerClothingFactory();
        var summerClothes = summerFactory.CreateClothes();
        summerClothes.Print();
        
        IAbstractFactory winterFactory = new WinterClothingFactory();
        var winterClothes = winterFactory.CreateClothes();
        winterClothes.Print();
    }
}