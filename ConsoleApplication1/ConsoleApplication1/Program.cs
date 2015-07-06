using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an new instance of the class Random(), and name it randNumber
            var randNumber = new Random();

            // Perform the .Next() method on the randNumber object
            var number = randNumber.Next(10);
            
            
            //Output information to the screen
            Console.WriteLine("Your random number is " + number);

            //Receive input from the user
            Console.ReadLine();
        }
    }
}
