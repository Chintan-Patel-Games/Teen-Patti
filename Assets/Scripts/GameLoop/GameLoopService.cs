using TeenPatti.Card;
using TeenPatti.StateMachine;

namespace TeenPatti.GameLoop
{
    public class GameLoopService
    {
        private GameLoopController gameLoopController;

        public GameLoopService(CardService cardService) =>
            gameLoopController = new GameLoopController(GameLoopState.DistributingCards, cardService);

        public void StartGameLoop() => gameLoopController.StartGameLoop();
        public void CheckForWinner() => gameLoopController.CheckForWinner();
        public void ShowGameResults() => gameLoopController.ShowGameResults();
        public void ReshuffleCards() => gameLoopController.ReshuffleCards();

        public void TickUpdate() => gameLoopController.TickUpdate();
    }
}