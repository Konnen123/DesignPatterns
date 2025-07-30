namespace DesignPatterns.Creational.Builder;

public class BuilderDemo
{
    public BuilderDemo()
    {
        HouseBuilder builder = new HouseBuilder(2, 4, 5)
            .WithGarden()
            .WithPool();
        
        House house = builder.Build();
        Console.WriteLine(house);
    }
}