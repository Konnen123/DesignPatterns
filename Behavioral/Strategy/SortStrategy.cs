namespace DesignPatterns.Behavioral.Strategy;

public class SortStrategy : IStrategy
{
    public void HandleAlgorithm(in List<int> numbers)
    {   
        numbers.Sort();
    }
}