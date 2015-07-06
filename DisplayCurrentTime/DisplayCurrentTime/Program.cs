using System;
using System.Collections.Generic;
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
    }
}
