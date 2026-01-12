namespace TeenPatti.Card
{
    public class CardService
    {
        private CardController cardController;

        public CardService() => cardController = new CardController();

        public void InitializeCard(CardHouse cardHouse, CardNumber cardNumber) =>
            cardController.InitializeCard(cardHouse, cardNumber);
    }
}