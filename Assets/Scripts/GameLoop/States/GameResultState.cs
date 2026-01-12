using TeenPatti.StateMachine;

namespace TeenPatti.GameLoop.States
{
    public class GameResultState : IState<GameLoopController>
    {
        public GameLoopController Owner { get; set; }

        public void OnEnterState() { }
        public void UpdateState() { }
        public void OnExitState() { }
    }
}