using TeenPatti.Card;
using TeenPatti.StateMachine;

namespace TeenPatti.GameLoop
{
    public class GameLoopController
    {
        private GameLoopStateMachine gameLoopStateMachine;

        private CardService cardService;

        public GameLoopController(GameLoopState initialState, CardService cardService)
        {
            this.cardService = cardService;
            gameLoopStateMachine = new GameLoopStateMachine(this);
            gameLoopStateMachine.Initialize(initialState);
        }

        public void StartGameLoop() =>
            gameLoopStateMachine.ChangeState(GameLoopState.DistributingCards);

        public void CheckForWinner() =>
            gameLoopStateMachine.ChangeState(GameLoopState.CheckForWinner);

        public void ShowGameResults() =>
            gameLoopStateMachine.ChangeState(GameLoopState.GameResults);

        public void ReshuffleCards() =>
            gameLoopStateMachine.ChangeState(GameLoopState.ReshuffleCards);

        public void TickUpdate() =>
            gameLoopStateMachine.Update();
    }
}