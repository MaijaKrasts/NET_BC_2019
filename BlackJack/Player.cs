using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Player : BasePlayer
    {
        public override string GetName()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }

            return ConsoleInput.GetText("Enter your name ");
        }

        public override bool WantCard()
        {
            //Console.WriteLine("Do you want another card? y/n? ");
            //string answ = Console.ReadLine().ToLower();
            //return answ == "y";

            return ConsoleInput.GetBool("Another card? y/n: ");
        }

        public override void GiveCard(Card card)
        {
            base.GiveCard(card);
            Console.WriteLine("Your new card is: {0}", card.GetTitle());
            Console.WriteLine("Your current points are: {0}", CountPoints());
        }
    }
}
