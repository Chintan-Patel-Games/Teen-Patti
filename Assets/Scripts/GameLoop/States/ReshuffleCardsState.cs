using TeenPatti.StateMachine;

namespace TeenPatti.GameLoop.States
{
    public class ReshuffleCardsState : IState<GameLoopController>
    {
        public GameLoopController Owner { get; set; }

        public void OnEnterState() { }
        public void UpdateState() { }
        public void OnExitState() { }
    }
}