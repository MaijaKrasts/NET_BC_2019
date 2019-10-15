using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Dealer : BasePlayer
    {
        private const string DEALER_NAME = "JACK";
        public override string GetName()
        {
            return DEALER_NAME;
        }

        public override bool WantCard()
        {
            return CountPoints() < 17;
        }
    }
}
