using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Convert2Date
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter the current date.

            Console.WriteLine("Please enter the current date. The required format is mm/dd/yyyy: ");
            
            var date = Console.ReadLine();

            var dateTime = DateTime.Parse(date);

            Console.WriteLine( "The date is " + dateTime.ToString("D"));

            Console.WriteLine("Enter a decimal: ");

            // Check to see if a number is a decimal

            var number = Console.ReadLine();

            var isNumber = Regex.IsMatch(number, @"\d+");

            // String Builder

            var stringBuilder = new StringBuilder();
            for (var i = 0; i < 100; i++)
            {
                stringBuilder.Append("Hello World");
            }


        }
    }
}
