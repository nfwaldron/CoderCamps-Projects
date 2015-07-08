using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsHeadlines = new ArrayList();

            newsHeadlines.Add("Nathan got a job at Microsoft!");
            newsHeadlines.Add("Lindsey got a job at Nordstrom!");
            newsHeadlines.Add("Conner got a job at Boeing!");
            newsHeadlines.Add("Joshua got a job at Amazon...Traitor");

            var random = new Random();
            var i = random.Next(newsHeadlines.Count);

            Console.WriteLine(newsHeadlines[i]);
            Console.ReadLine();   

        }
    }
}
