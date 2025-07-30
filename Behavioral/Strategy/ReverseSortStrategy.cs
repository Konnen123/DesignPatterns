namespace DesignPatterns.Behavioral.Strategy;

public class ReverseSortStrategy : IStrategy
{
    public void HandleAlgorithm(in List<int> numbers)
    {
        numbers.Sort();
        numbers.Reverse();
    }
}