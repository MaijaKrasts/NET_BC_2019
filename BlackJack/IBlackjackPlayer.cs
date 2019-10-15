using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    interface IBlackjackPlayer
    {
        string GetName();

        List<Card> GetCards();

        int CountPoints();

        bool IsGameCompleted();

        bool WantCard();

        void GiveCard(Card card);

    }
}