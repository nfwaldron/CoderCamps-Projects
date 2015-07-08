using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var mars = "Martians Attack!";
            var sea = "Seahawks Win Superbowl!";
            var con = "Conner Destroys Hackathon Competition!";

            var headlines = new string[] { mars, sea, con };

            Console.WriteLine(headlines.GetRandom());
            Console.ReadLine();

            

        }
    }
}
