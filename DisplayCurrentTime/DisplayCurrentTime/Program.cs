using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayCurrentTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now.ToShortTimeString();
            Console.WriteLine("The time is " + time);

            Console.ReadLine();
        }

        static int DivideNumbers(int num1, int num2)
        {
            Debug.Assert(num2 != 0, "Cannot Divide By Zero");

            return num1 / num2;
        }
    }
}
