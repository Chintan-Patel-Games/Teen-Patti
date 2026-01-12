using TeenPatti.StateMachine;

namespace TeenPatti.GameLoop.States
{
    public class CheckForWinnerState : IState<GameLoopController>
    {
        public GameLoopController Owner { get; set; }

        public void OnEnterState() => GameService.Instance.CheckForWinner();
        public void UpdateState() { }
        public void OnExitState() { }
    }
}