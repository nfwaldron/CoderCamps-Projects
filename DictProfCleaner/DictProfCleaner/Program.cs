using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Create a program that 

namespace DictProfCleaner
{
    class ProfanityCleaner
    {
        public static string Clean(string input)
        {
            //SETUP 

            // The first thing you want to do is split the string into an array of strings.
            // Use the Regex language to split the array whenever a punctuation mark is encountered.
            var inputArray = Regex.Split(input, @"\b");

            // Next we create a dictionary that has keys and values for our profanity words.

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("frack", "f***");
            dictionary.Add("shint", "s***");
            dictionary.Add("dooger", "d***");

            // Next we will create a collection of strings to which we will store the result of 
            // our program output.

            var result = new List<string>();

            // Next we will use a foreach loop to iterate through our array 'inputArray'
            // The foreach loop looks at every item in our array...

            foreach (var item in inputArray)
            {
                // for each item in our array 'inputArray', if the dictionary containts the a key
                // that matches the string value of the particular item being examined by the
                // foreachloop...
                if (dictionary.ContainsKey(item))
                {
                    // ...Add to the list of strings 'result' the value of the key that the corresponding
                    // string being evaluated is equivalent to.
                    result.Add(dictionary[item]);
                }

                else
                {
                    result.Add(item);
                }

            }
           
            // Call the static method Join on the string class
            var finalResult = String.Join("", result);

            return finalResult;

        }

        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Enter your message: ");
                var message = Console.ReadLine();

                var finalMessage = ProfanityCleaner.Clean(message);

                Console.WriteLine("Edited message: {0}", finalMessage);
                Console.ReadLine();

            }
        }
    }
}
