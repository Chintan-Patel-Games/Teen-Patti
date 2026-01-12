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

            SetCardImage();
        }

        public void SetCardImage()
        {
            string cardName = cardModel.Name;
            cardView.SetCardImage(cardModel.House, cardName);
        }
    }
}