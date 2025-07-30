namespace DesignPatterns.Behavioral.State;

public class StateDemo
{
    public StateDemo()
    {
        IPlayerState state = new PlayerIdleState();
        Player player = new Player(state);
        
        player.HandleRequest();
        IPlayerState walk = new PlayerWalkState();
        player.ChangeState(walk);
        player.HandleRequest();
    }
}