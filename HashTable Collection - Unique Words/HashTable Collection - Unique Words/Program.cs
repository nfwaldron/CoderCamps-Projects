using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receive user input
            var input = Console.ReadLine();
            
            // Split the string and return a string [] array
            var words = input.Split(' ');

            // Create a new hashtable
            var hashTable = new Hashtable(); 

            // Loop through each item in the string array 'words'
            foreach (var item in words)
            {
                // If the hastable does not contain the item....
                if (!hashTable.ContainsKey(item))
                {
                    // Add the item to the hashtable
                    hashTable.Add(item, item);
                }
                


            }


        }
    }
}
