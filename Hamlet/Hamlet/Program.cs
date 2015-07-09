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


            
        }
    }
}
