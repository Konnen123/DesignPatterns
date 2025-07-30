namespace DesignPatterns.Creational.Builder;

public class House
{
    public int Doors { get; init; }
    public int Walls { get; init; }
    public int Windows { get; init; }
    
    public bool HasPool { get; init; }
    public bool HasGarden { get; init; }
    public bool HasStatue { get; init; }

    public House(HouseBuilder builder)
    {
        Doors = builder.Doors;
        Walls = builder.Walls;
        Windows = builder.Windows;
        HasPool = builder.HasPool;
        HasGarden = builder.HasGarden;
        HasStatue = builder.HasStatue;
    }

    public override string ToString()
    {
        return $"Doors: {Doors} | Walls: {Walls} | Windows: {Windows} | HasPool: {HasPool} | HasGarden: {HasGarden} | HasStatue: {HasStatue}";
    }
}