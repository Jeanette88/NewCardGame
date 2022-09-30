using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NewCardGame.Data;
using NewCardGame.Pages;
using System.Xml.Linq;

namespace NewCardGame.Models
{
    public class Hand
    {

        public List<Card> Cards { get; set; } = new List<Card>();

        public void GetCards()
        {
            Cards.ToList();
        }

        public void RandomCard()
        {
            var randomCards = Cards.OrderBy(h => Guid.NewGuid()).ToList();
            Cards = randomCards.ToList();
        }

        public Card Deal(bool cardOK)
        {
            Card thisCard = Cards.Last();
            Cards.Remove(thisCard);

            thisCard.ItsOK = cardOK;

            return thisCard;
        }

        public void DeleteCard()
        {
            Card thisCard = Cards.Last();
            Cards.Remove(thisCard);
           
        }

        public void History()
        {

            var his = (from h in Cards


                         select new CardDto
                         {
                             Id = h.Id,
                             Name = h.Name,
                             Value = h.Value,
                             Suit = h.Suit,

                         }).OrderByDescending(g => g.CardId).ToList();

        }

    }
}
