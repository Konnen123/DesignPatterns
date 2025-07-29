using DesignPatterns.Creational.AbstractFactory.Clothes;
using DesignPatterns.Creational.AbstractFactory.Shoes;

namespace DesignPatterns.Creational.AbstractFactory;

public class WinterClothingFactory : IAbstractFactory
{
    public IClothes CreateClothes()
    {
        return new Jacket();
    }

    public IShoes CreateShoes()
    {
        return new Boots();
    }
}