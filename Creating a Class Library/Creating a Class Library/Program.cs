using MyUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_a_Class_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var utility = new FormUtilities();

            //var cleanName = utility.CleanInput("  StEPheN WALthEr ");

            Console.WriteLine("   AlICe".CleanInput());
            Console.ReadLine();
        }
    }
}
