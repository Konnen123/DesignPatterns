namespace DesignPatterns.Behavioral.Strategy;

public class SortService
{
    private IStrategy strategy;

    public SortService(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void Sort(in List<int> numbers)
    {
        strategy.HandleAlgorithm(numbers);
    }
}