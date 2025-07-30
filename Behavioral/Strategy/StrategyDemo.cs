namespace DesignPatterns.Behavioral.Strategy;

public class StrategyDemo
{
    public StrategyDemo()
    {
        List<int> numbers = new List<int>() { 1, 2, 39, 12, 321, 8, 1, -3 };
        IStrategy sortStrategy = new SortStrategy();
        SortService sortService = new SortService(sortStrategy);
        sortService.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.Write(number + ", ");
        }
        Console.WriteLine();
        sortService.SetStrategy(new ReverseSortStrategy());
        sortService.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.Write(number + ", ");
        }
    }
}