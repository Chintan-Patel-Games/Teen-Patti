namespace TeenPatti.Card
{
    public class CardModel
    {
        public CardNumber Number { get; private set; }
        public CardHouse House { get; private set; }
        public string Name { get; private set; }

        public CardModel(CardHouse house, CardNumber number)
        {
            House = house;
            Number = number;
            Name = $"{house}_{number}";
        }
    }
}