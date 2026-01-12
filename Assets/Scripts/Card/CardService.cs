using UnityEngine;

namespace TeenPatti.Card
{
    public class CardService
    {
        private CardController cardController;
        private CardModel cardModel;
        private CardSO cardSO;

        public CardService(CardSO cardSO)
        {
            this.cardSO = cardSO;
            cardController = new CardController();
        }

        public CardModel InitializeCard() =>
            cardModel = cardController.InitializeCard(GetRandomHouse(), GetRandomNumber(), cardSO);

        private CardHouse GetRandomHouse()
        {
            CardHouse[] houses = (CardHouse[])System.Enum.GetValues(typeof(CardHouse));
            return houses[Random.Range(0, houses.Length)];
        }

        private CardNumber GetRandomNumber()
        {
            CardNumber[] numbers = (CardNumber[])System.Enum.GetValues(typeof(CardNumber));
            return numbers[Random.Range(0, numbers.Length)];
        }

        public CardModel GetCard() => cardController.GetCardModel();
    }
}