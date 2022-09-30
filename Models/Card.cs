namespace NewCardGame.Models
{
    public class Card 
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Value { get; set; }
        public string? Suit { get; set; }
        public string? Image { get; set; }
        public bool ItsOK { get; set; } = false;


        public Card(int value, string suit)
        {
            Value = value;

            switch (value)
            {
                case 1:
                    Name = "Ace";
                    break;
                case 11:
                    Name = "Jack";
                    break;
                case 12:
                    Name = "Queen";
                    break;
                case 13:
                    Name = "King";
                    break;
                default:
                    Name = value.ToString();
                    break;
            }

            Suit = suit;

            if (value != 10)
            {
                Image = string.Format("{0}{1}.png", Name[0], Suit[0]);
            }
            else
            {
                Image = string.Format("10{0}.png", Suit[0]);
            }
        }

        public Card()
        {
        }
    }
}
