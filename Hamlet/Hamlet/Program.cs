using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that determines the most used word in Hamlet. Exclude boring words such as "the", "a", "an".
namespace Hamlet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a string variable that stored the URL of the Hamlet text file.
            string hamletTxtPath = @"c:\Users\Nathan\Desktop\CoderCamps Projects\Hamlet\Hamlet\Hamlet.txt";

            // The try-catch statement consists of a try block followed by one or more catch clauses,
            // which specify handlers for different exceptions.
            // Use this method to ensure proper reading of the file.  
            try
            {
                using (StreamReader sr = new StreamReader(hamletTxtPath))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine("The file was successfully read.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            // Utilize the File.ReadALlText() method to open a text file, read all lines of the file, and then close the file.
            // This method returns a string which is stored in the variable read text.
            string readText = File.ReadAllText(hamletTxtPath);

            /* For the task of sorting the We can use the different words in the text for keys, 
             * and the value for each key would be the number of occurrences for each word in our text.
             * 
             * The algorithm for counting the words is the following: we read the text word by word. 
             * For each word we check if it already exists in the dictionary. 
             * If the answer is no, we add a new element in the dictionary with a value of 1. 
             * If the answer is yes – we increase the old value of the element by one, 
             * so as to count the last occurrence.
             * 
             * In order to remove the 'boring' words from the text, create an array of characters that you
             * want to be stripped from the text
             */

            //In order to remove the 'boring' words from the text, create an array of characters that you
            //want to be stripped from the text
            string[] stripChars = { "the", "a", "an", "for" };

            //For every item in stripChars, read through the Hamlet text stored in readText, and replace
            // it with a space.
            foreach (string character in stripChars)
            {
                readText = readText.Replace(character, " ");
            }

            // Create a object of the class Dictionary.The key arguement is a string which represents the word occurence, and the 
            // value is an int which represents the amount of times the key is encountered.
            var wordCounter = new Dictionary<string, int>();

            foreach (string word in readText)
            {
                if (wordCounter.ContainsKey(word))
                {
                    wordCounter[word]++;
                }

                else
                {
                    wordCounter[word] = 1;
                }
            }





            
        }
    }
}
