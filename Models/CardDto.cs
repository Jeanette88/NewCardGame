namespace NewCardGame.Models
{
    public class CardDto
    {
        public Guid Id { get; set; }
        public int CardId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string? Suit { get; set; }

        public string Image { get; set; }

    }
}
