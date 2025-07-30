namespace DesignPatterns.Behavioral.State;

public class PlayerIdleState : IPlayerState
{
    public void HandleRequest()
    {
        Console.WriteLine("Player idle state");
    }
}