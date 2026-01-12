using UnityEngine;

namespace TeenPatti.Card
{
    [CreateAssetMenu(fileName = "CardSO", menuName = "ScriptableObjects/CardSO")]
    public class CardSO : ScriptableObject
    {
        public Sprite[] clubCardImages;
        public Sprite[] diamondCardImages;
        public Sprite[] heartCardImages;
        public Sprite[] spadeCardImages;
    }
}