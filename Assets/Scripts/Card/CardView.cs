using UnityEngine;

namespace TeenPatti.Card
{
    public class CardView : MonoBehaviour
    {
        [SerializeField] private CardSO cardSO;

        public void SetCardImage(CardHouse cardHouse, string cardName)
        {
            switch (cardHouse)
            {
                case CardHouse.club:
                    SetCardImageFromArray(cardSO.clubCardImages, cardName);
                    break;
                case CardHouse.diamond:
                    SetCardImageFromArray(cardSO.diamondCardImages, cardName);
                    break;
                case CardHouse.heart:
                    SetCardImageFromArray(cardSO.heartCardImages, cardName);
                    break;
                case CardHouse.spade:
                    SetCardImageFromArray(cardSO.spadeCardImages, cardName);
                    break;
                default:
                    Debug.LogError("Invalid card house!");
                    break;
            }
        }

        private void SetCardImageFromArray(Sprite[] cardImages, string cardName)
        {
            foreach (var cardImage in cardImages)
            {
                if (cardImage.name == cardName)
                {
                    GetComponent<SpriteRenderer>().sprite = cardImage;
                    return;
                }
            }
            Debug.LogError($"Card image with name {cardName} not found in the specified house!");
        }
    }
}