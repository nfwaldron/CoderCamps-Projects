using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new object of the Calculator class
            var calculator = new Calculator();
            // Call the CalculateSum method, and assign the value returned to the variable 'result'
            var result = calculator.CalculateSum(3,3,3);
            // Output the result
            Console.WriteLine("Result is " + result);
            // Pause the program
            Console.ReadLine();

        }
    }
}
