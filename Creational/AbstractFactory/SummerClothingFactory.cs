using DesignPatterns.Creational.AbstractFactory.Clothes;
using DesignPatterns.Creational.AbstractFactory.Shoes;

namespace DesignPatterns.Creational.AbstractFactory;

public class SummerClothingFactory : IAbstractFactory
{
    public IClothes CreateClothes()
    {
        return new TankTop();
    }

    public IShoes CreateShoes()
    {
        return new FlipFlops();
    }
}