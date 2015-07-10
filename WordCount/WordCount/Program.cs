using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordCounter = new CountWord();
            Console.WriteLine("Hello! Please enter a sentence: ");
            var input = Console.ReadLine();

            var wordNumber = wordCounter.WordCounter(input);
            Console.WriteLine("Words in string = {0}", wordNumber);
            Console.Read();
        }
    }
}
