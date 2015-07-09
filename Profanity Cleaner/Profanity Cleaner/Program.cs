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

            // Split contents of the string 'input' wherever a punctuation is encountered, 
            // and store in the string [] array words. This is accomplished using the Regex.Split() method. This method
            // takes as arguements the string that is to be split, and the Regex code for the characters at which
            // to split the string, before placing it into the array words.
            var words = Regex.Split(input, @"\b");

            // Create a new Dictionary of strings
            // So this is the way a Dictionary works...a Dictionary has keywords, or 'keys' and values/definitions
            // When you create a dictionary, you enter as arguements the data type of the key, or the word, and the 
            // data type of the definition, or the value.
            var profanityCleaner = new Dictionary<string, string>();

            // Add your profane words to the dictionary.
            // This is how the profanity cleaner works...we are going to add to the dictionary
            // our swear words. These bad words will be the the key, and the word we want to change it to  
            // will be the value.
            profanityCleaner.Add("darn", "d**n");
            profanityCleaner.Add("gosh", "g**h");
            profanityCleaner.Add("yuck", "y**k");

            // Here we are going to create our dynamic collection List which is a list of string objects.
            var result = new List<string>();

            // For each item in the array words...
            foreach (var item in words)
            {
                //...We are going to check to see if that item matches with a key in our dictionary.
                // If the..............
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
