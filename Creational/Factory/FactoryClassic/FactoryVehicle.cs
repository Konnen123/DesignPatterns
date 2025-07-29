namespace DesignPatterns.Creational.Factory.FactoryClassic;

// This Factory implementation does violate Open/Close Principle
// If we want to add new items to the dictionary, we need to modify the class
public static class FactoryVehicle
{
    public static IDictionary<string, Func<IVehicle>> Vehicles = new Dictionary<string, Func<IVehicle>>();

    private static void InitializeVehiclesDictionary()
    {
        Vehicles.Add(nameof(Dacia), new Func<IVehicle>(() => new Dacia()));
        Vehicles.Add(nameof(Aro), new Func<IVehicle>(() => new Aro()));
    }
    public static IVehicle CreateVehicle(string model)
    {
        if (!Vehicles.Any())
        {
            InitializeVehiclesDictionary();
        }

        if (Vehicles.TryGetValue(model, out var func))
        {
            return func();
        }
        
        throw new ArgumentException($"Model {model} not found");
    }
}