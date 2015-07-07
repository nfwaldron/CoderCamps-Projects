using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a sentence
            Console.WriteLine("Please enter a sentence: ");
            
            // Create variable to store the user input 
            var userInput = Console.ReadLine();

            // Use the .Split() method to split the string whenever it encounters a  " " character, 
            // and store the result as an array in the string array splitStringArray.
            string [] splitStringArray = userInput.Split();

            // Utilize the Array.Reverse method, which takes a string as an arguement, and reverses it. 
            Array.Reverse(splitStringArray);

            // Utilize the String.Join() method to turn the array back into a string. The Join() method concatenates the
            // elements in an array, using the specified separator between two elements. It takes two arguements, separator to be used
            // and the name of the array that will be joined, and turned into a string.
            var x = String.Join(" ", splitStringArray);

            Console.WriteLine(x);
        }
    }
}

