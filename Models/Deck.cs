namespace NewCardGame.Models
{
    public class Deck : Hand
    {
        public Deck()
        {
        }

        public Deck(bool randomCards)
        {
            Cards = new List<Card>();

            var suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };

            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Cards.Add(new Card(i, suit));
                }
            }

            if (randomCards)
            {
                RandomCard();
            }

        }

    }
}
