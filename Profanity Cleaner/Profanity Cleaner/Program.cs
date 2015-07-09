using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Profanity_Cleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for input
            Console.WriteLine("Please enter your comment: ");

            //Store input in variable 'input'
            var input = Console.ReadLine();

            var punctation = new char[' ', ',','!','.'];

            // Split contents of the string 'input' wherever a space is encountered, and store in the string [] array words
            //var words = input.Split();
            var words = Regex.Split(input, @"\b");

            // Create a new Dictionary of strings
            // 
            var profanityCleaner = new Dictionary<string, string>();

            // Add your profane words to the dictionary
            // So this is the way a Dictionary works...a Dictionary has keywords, or 'keys' and values/definitions
            // 
            // 
            profanityCleaner.Add("darn", "d**n");
            profanityCleaner.Add("gosh", "g**h");
            profanityCleaner.Add("yuck", "y**k");

            var result = new List<string>();

            // For each item in the array words...
            foreach (var item in words)
            {
                // As I go through each word in the list of words, if the word is in the profanity dictionary, 
                // add the replacement word to result, else add the original word to result.
                if (profanityCleaner.ContainsKey(item))
                {
                    result.Add(profanityCleaner[item]);
                }

                else
                {
                    result.Add(item);
                }
            } 

            var finalResult = String.Join(" ", result);

            Console.WriteLine(finalResult);
            Console.ReadLine();



        }
    }
}
