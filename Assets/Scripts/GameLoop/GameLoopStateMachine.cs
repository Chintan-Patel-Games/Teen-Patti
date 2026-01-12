using System;
using TeenPatti.GameLoop.States;
using TeenPatti.StateMachine;

namespace TeenPatti.GameLoop
{
    public class GameLoopStateMachine : StateMachine<GameLoopController>
    {
        public GameLoopStateMachine(GameLoopController Owner) : base(Owner) => CreateStates();

        public void Initialize(Enum initialState) => ChangeState(initialState);

        private void CreateStates()
        {
            States.Add(GameLoopState.DistributingCards, new DistributeCardsState());
            States.Add(GameLoopState.CheckForWinner, new CheckForWinnerState());
            States.Add(GameLoopState.GameResults, new GameResultState());
            States.Add(GameLoopState.ReshuffleCards, new ReshuffleCardsState());
        }
    }
}