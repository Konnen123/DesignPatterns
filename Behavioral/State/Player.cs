namespace DesignPatterns.Behavioral.State;

public class Player
{
    private IPlayerState playerState;

    public Player(IPlayerState playerState)
    {
        this.playerState = playerState;
    }

    public void ChangeState(IPlayerState playerState)
    {
        this.playerState = playerState;
    }

    public void HandleRequest()
    {
        playerState.HandleRequest();
    }

}