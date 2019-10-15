using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Game
    {
        private int CurrentNumber; // current number player guesses
        private IPlayer PlayerOne;
        private IPlayer PlayerTwo;

        public void StartNewGame()
        {
            CurrentNumber = new Random().Next(1, 501);
            PlayerOne = new User();
            PlayerTwo = new Robot();
        }

        public void Loop()
        {
            while (true)
            {
                Console.WriteLine("Player one turn");
                //player one wins
                if (PlayerTurn(PlayerOne))
                {
                    break;
                }

                Console.WriteLine("Player two turn");
                //player two wins
                if (PlayerTurn(PlayerTwo))
                {
                    break;
                }

            }

        }

        private bool PlayerTurn(IPlayer player)
        {
            player.GuessNumber();
            bool IsGuessed = player.IsNumberGuessed(CurrentNumber);

            if (IsGuessed)
            {
                Console.WriteLine("Player {0} wins", player.GetName());
            }

            return IsGuessed;
        }
    }
}
