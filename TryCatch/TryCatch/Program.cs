using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try Catch Block...Another method of writing robust code.
            // Should only use for instances where you have an external dependancy where things can go wrong
            // i.e. Reading from a file, Database access, Network quereys.
            // Never do this when WEB DEVELOPING!!!!!
            try
            {
                var a = 2;
                var b = 0;
                var result = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not do it..." + ex.Message);
                Console.ReadLine();
                
                throw;
            }
        }
    }
}
