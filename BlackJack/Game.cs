using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Game
    {
        private IBlackjackPlayer PlayerOne;
        private IBlackjackPlayer PlayerTwo;
        private Deck Deck;
        
        public void StartNewGame()
        {
           
            PlayerOne = new Player();
            PlayerTwo = new Dealer();

            Deck = new Deck();
            Deck.Shuffle();

            PlayerOne.GiveCard(Deck.GetCard());
            PlayerOne.GiveCard(Deck.GetCard());

            PlayerTwo.GiveCard(Deck.GetCard());
            PlayerTwo.GiveCard(Deck.GetCard());

            //garākais variants:
            //Card card1 = Deck.GetCard();
            //PlayerOne.GiveCard(card1);
        }

        public void Loop()
        {
            //player one turn
            while (!PlayerOne.IsGameCompleted() && PlayerOne.WantCard())
            {
                PlayerOne.GiveCard(Deck.GetCard());
            }

            if (PlayerOne.CountPoints() > 21)
            {
                Console.WriteLine("Player one lost the game!");
            }

            else if (PlayerOne.CountPoints() == 21)
            {
                Console.WriteLine("Player wins!");
            }

            else
            {
                //player two turn
                Console.WriteLine("Dealers turn!");
                while (!PlayerTwo.IsGameCompleted() && PlayerTwo.WantCard())
                {
                    PlayerTwo.GiveCard(Deck.GetCard());
                }

                Console.WriteLine("Player one points: {0}", PlayerOne.CountPoints());
                Console.WriteLine("Dealer points: {0}", PlayerTwo.CountPoints());

                int playerPoints = PlayerOne.CountPoints();
                int dealerPoints = PlayerTwo.CountPoints();

                if (dealerPoints > 21 || playerPoints > dealerPoints)
                {
                    Console.WriteLine("Player one wins ");
                }

                else
                {
                    Console.WriteLine("Dealer wins!");
                }

                // īsā versija: 
                // Console.WriteLine(dealerPoints > 21 || playerPoints > dealerPoints ? "You win" : "Dealer wins");
            }
        }
    }
}
