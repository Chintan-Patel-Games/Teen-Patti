using UnityEngine;

namespace TeenPatti.Card
{
    public class CardController
    {
        private CardModel cardModel;

        public CardModel InitializeCard(CardHouse cardHouse, CardNumber cardNumber, CardSO cardSO)
        {
            cardModel = new CardModel(cardHouse, cardNumber);

            cardModel.Image = SetCardImage(cardSO, cardHouse, cardModel.Name);

            return cardModel;
        }

        private Sprite SetCardImage(CardSO cardSO, CardHouse cardHouse, string cardName)
        {
            switch (cardHouse)
            {
                case CardHouse.club:
                    return GetCardImageFromArray(cardSO.clubCardImages, cardName);
                case CardHouse.diamond:
                    return GetCardImageFromArray(cardSO.diamondCardImages, cardName);
                case CardHouse.heart:
                    return GetCardImageFromArray(cardSO.heartCardImages, cardName);
                case CardHouse.spade:
                    return GetCardImageFromArray(cardSO.spadeCardImages, cardName);
                default:
                    Debug.LogError("Invalid card house!");
                    return null;
            }
        }

        private Sprite GetCardImageFromArray(Sprite[] cardImages, string cardName)
        {
            foreach (var cardImage in cardImages)
            {
                if (cardImage.name == cardName)
                    return cardImage;
            }
            return null;
        }

        public CardModel GetCardModel() => cardModel;
    }
}