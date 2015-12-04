using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public bool IsDivisibleByThree(int input)
        {
            return (input % 3) == 0;
        }

        public bool IsDivisibleByFive(int input)
        {
            return (input % 5) == 0;
        }

        public string GetTextForNumber(int input)
        {
            if (IsDivisibleByThree(input) && IsDivisibleByFive(input))
            { 
                return "FizzBuzz";
            }
            if (IsDivisibleByFive(input))
            {
                return "Buzz";
            }
            if (IsDivisibleByThree(input))
            {
                return "Fizz";
            }
            else
            {
                return input.ToString();
            }
        }

        public string DoTheWholeThing(int howHighToDo)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= howHighToDo; i++)
            {
                sb.AppendFormat("{0}", GetTextForNumber(i));
            }
            return sb.ToString();
        }
    }
}