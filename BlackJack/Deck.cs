using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BlackJack
{
    class Deck
    {
        public List<Card> Cards;
        private string[] suits = new[] {"C", "S", "D", "H"};
        private string[] ranks = new[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};


        public Deck()
        {
            Cards = new List<Card>();

            foreach (var suite in suits)
            {
                foreach (var rank in ranks)
                {
                    Cards.Add(new Card(rank, suite));
                }
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(x => rnd.Next()).ToList();
        }

        public Card GetCard()
        {
            //takes the last card from the list
            // removes it from the list
            // returns it

            Card LastCard = Cards[Cards.Count - 1];
            // otrs variants Card LastCard = Card.Last();

            Cards.Remove(LastCard);

            return LastCard;
        }
    }
}
