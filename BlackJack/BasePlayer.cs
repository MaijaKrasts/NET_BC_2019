using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{ 
    abstract class BasePlayer : IBlackjackPlayer
    {
        protected string Name { get; set; }
        protected List<Card> Cards { get; set; }

        public BasePlayer()
        {
            Cards = new List<Card>();
            Name = GetName();
        }

        public List<Card> GetCards()
        {
            return Cards;
        }

        public virtual void GiveCard(Card card)
        {
            Cards.Add(card);
        }

        public abstract string GetName();
        public abstract bool WantCard();

        public int CountPoints()
        {
            int points = Cards.Sum(c => c.GetPoints());

            if (points > 21)
            {
                int aceCount = Cards.Count(c => c.GetPoints() == 11);

                while (aceCount > 0 && points > 21)
                {
                    points -= 10;
                    aceCount--;
                }
            }

            //foreach (var card in Cards) { points += card.GetPoints();}

            return points;
        }

        public bool IsGameCompleted()
        {
            if (CountPoints() >= 21)
            {
                return true;
            }

            else
            {
                return false;
            }

            //return CountPoints() > 21;
        }
    }
}
