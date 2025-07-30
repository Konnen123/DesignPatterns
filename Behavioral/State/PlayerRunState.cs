namespace DesignPatterns.Behavioral.State;

public class PlayerRunState : IPlayerState
{
    public void HandleRequest()
    {
        Console.WriteLine("Player run state");
    }
}