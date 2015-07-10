using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSSDefender
{
    // Goal of Lab is to Ensure that You Are Writing Unit Tests 
    class Program
    {
        static void Main(string[] args)
        {
            var htmlStr = "<b>hello</b><Script>evil</Script>";
            var security = new Security();
            var result = security.SanitizeHTML(htmlStr);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
