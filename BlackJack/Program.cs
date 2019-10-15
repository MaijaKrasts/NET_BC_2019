using ConsoleHelpers;
using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.StartNewGame();
                game.Loop();

                Console.WriteLine();
                if (!ConsoleInput.GetBool("Play again? y/n: "))
                {
                    Environment.Exit(0);
                    break;
                }
            }

            Console.Read();
        }
    }
}
