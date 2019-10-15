using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public abstract class BasePlayer : IPlayer
    {
        protected string Name;
        protected int CurrentGuess;
        protected int NextGuess;

        public BasePlayer()
        {
            // 1. Constructor that sets ‘Name’ as GetName() returned string
            Name = GetName();
        }

        // 1. Abstract method without body.
        public abstract string GetName();

        // 1. Abstract method without body.
        public abstract int GuessNumber();

        public virtual bool IsNumberGuessed(int number)
        {
            // 1. Checks and returns bool result if ‘number’ is equal ‘CurrentGuess’
           if (number > CurrentGuess)
            {
                Console.WriteLine("{0} is less than number", CurrentGuess);
                NextGuess = 1;
            }

           else if (number < CurrentGuess)
            {
                Console.WriteLine("{0} is more than number", CurrentGuess);
                NextGuess = -1;
            }

            return number == CurrentGuess;

        }
    }
}
