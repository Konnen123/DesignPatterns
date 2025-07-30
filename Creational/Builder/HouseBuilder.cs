namespace DesignPatterns.Creational.Builder;

public class HouseBuilder
{
    public int Doors { get; init; }
    public int Walls { get; init; }
    public int Windows { get; init; }
    
    public bool HasPool { get; private set; }
    public bool HasGarden { get; private set; }
    public bool HasStatue { get; private set; }

    public HouseBuilder(int doors, int walls, int windows)
    {
        Doors = doors;
        Walls = walls;
        Windows = windows;
    }

    public HouseBuilder WithPool()
    {
        HasPool = true;
        return this;
    }

    public HouseBuilder WithGarden()
    {
        HasGarden = true;
        return this;
    }

    public HouseBuilder WithStatue()
    {
        HasStatue = true;
        return this;
    }

    public House Build()
    {
        return new House(this);
    }
}