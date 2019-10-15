using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Card
    {
        // 2, 3, .., 10, A, Q, K, J
        private string Rank { get; set; }
        // C - Clubs, D - Diamonds, S - Spades, H - Hearts
        private string Suite { get; set; }

        public Card (string rank, string suite)
        {
            Rank = rank;
            Suite = suite;
        }

        public string GetTitle()
        {
            string title = "";
            switch (Suite)
            {
                case "S":
                    title = "pīķis";
                    break;
                case "D":
                    title = "kāravs";
                    break;
                case "C":
                    title = "kreicis";
                    break;
                case "H":
                    title = "ercens";
                    break;
            }

            return String.Join(" ", title, Rank);
        }

        public int GetPoints()
        {
            switch (Rank)
            {
                case "A":
                    return 11;
                case "K":
                case "Q":
                case "J":
                    return 10;
                default:
                    return int.Parse(Rank);
            }
        }
    }
}
