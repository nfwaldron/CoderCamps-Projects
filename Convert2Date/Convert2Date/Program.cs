using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert2Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current date. The required format is mm/dd/yyyy: ");
            
            var date = Console.ReadLine();

            var dateTime = DateTime.Parse(date);

            Console.WriteLine( "The date is " + dateTime.ToString("D"));

            Console.ReadLine();


        }
    }
}
