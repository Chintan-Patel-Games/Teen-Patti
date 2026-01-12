namespace TeenPatti.Card
{
    public class CardController
    {
        private CardModel cardModel;
        private CardView cardView;

        public void InitializeCard(CardHouse cardHouse, CardNumber cardNumber)
        {
            cardModel = new CardModel(cardHouse, cardNumber);
            cardView = new CardView();
        }
    }
}