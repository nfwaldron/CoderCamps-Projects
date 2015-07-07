using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Day_One_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for the date, take the date, and display it in the long format
            
            // Prompt user for date
            Console.WriteLine("Please enter the date. Use the format mm/dd/yyyy");

            //Store the user input
            var userInput = Console.ReadLine();

            //Converts string representation of date and time to its System.DateTime equivalent 
            var dateTime = DateTime.Parse(userInput);

            //Convert current System.DateTime object to its equivalent long date string representation.

            Console.WriteLine("The date is " + dateTime.ToLongDateString());




            
        }
    }
}
