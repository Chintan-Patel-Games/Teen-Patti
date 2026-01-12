namespace TeenPatti.StateMachine
{
    public enum GameLoopState
    {
        None,
        DistributingCards,
        CheckForWinner,
        GameResults,
        ReshuffleCards
    }
}