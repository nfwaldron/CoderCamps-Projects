using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            
            var htmlSanitizer = new Security();

            Console.WriteLine("Please Enter Content: ");
            var htmlStr = Console.ReadLine();

            // var htmlStr = "<b>hello</b><Script>evil</Script>"; // Initialize string variable with string content
            
            var result = htmlSanitizer.SanitizeHTML(htmlStr); // Run test method to ensure proper functioning
            Console.WriteLine("Original String: {0}", htmlStr);
            Console.WriteLine("Sanitized String: {0}", result);
            Console.ReadLine();
        }
    }
}
