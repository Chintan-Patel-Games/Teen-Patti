using TeenPatti.StateMachine;

namespace TeenPatti.GameLoop.States
{
    public class DistributeCardsState : IState<GameLoopController>
    {
        public GameLoopController Owner { get; set; }

        public void OnEnterState() => GameService.Instance.InitializePlayerCards();
        public void UpdateState() { }
        public void OnExitState() { }
    }
}