using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        public static int DivideNumbers(int val1, int val2)
        {
            // guard clauses
            if (val2==0)
            {
                throw new ArgumentOutOfRangeException("Value 2 cannot be zero.");
            }

            else
            {
                return val1 / val2;
            }
        }

        static void Main(string[] args)
        {
            // When building robust code, you want to prevent developers from misusing your code.
            // Throwing your own exception is helpful because you can provide detailed messages to 
            // other developers to allow them to understand why what they did is wrong.

            var result = DivideNumbers(1,0);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
