namespace DesignPatterns.Behavioral.State;

public class PlayerWalkState : IPlayerState
{
    public void HandleRequest()
    {
        Console.WriteLine("Player walk state");
    }
}