using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays Class is an object used to store a list of related items.
            var zoo = new string[] {"Lions", "Tigers", "Bears"};

            // Create an array of 3 news items that that contains headlines such as "Life Discovered on Mars!".
            // Randomly select one news item and display the news item

            // Declare and Define the elements in an array
            var newsHeadlinesArray = new string[] {"Nathan Plays Bass!", "Jim Stinnett Crafts New Le Fay Bass!", "Conner Rhoden Takes the Cake!"};

            // Create a new object of the class Random and name it 'randomNumber'
            var randomNumber = new Random();

            var i = randomNumber.Next(newsHeadlinesArray.Length); // Call the .Next method on the randomNumber object and assign the upper bound to the number of items in the array by calling the .Length method on the array, 'newsHeadlinesArray'.

            Console.WriteLine(newsHeadlinesArray[i]);
            Console.ReadLine();

            






        }
    }
}
