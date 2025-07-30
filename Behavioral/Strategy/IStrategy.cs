namespace DesignPatterns.Behavioral.Strategy;

public interface IStrategy
{
    public void HandleAlgorithm(in List<int> numbers);
}