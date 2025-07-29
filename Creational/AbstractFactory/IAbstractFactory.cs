using DesignPatterns.Creational.AbstractFactory.Clothes;
using DesignPatterns.Creational.AbstractFactory.Shoes;

namespace DesignPatterns.Creational.AbstractFactory;

public interface IAbstractFactory
{
    public IClothes CreateClothes();
    
    public IShoes CreateShoes();
}