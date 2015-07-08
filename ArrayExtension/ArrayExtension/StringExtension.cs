using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    public static class StringExtension
    {
        public static string GetRandom(this string[] input)
        {
            // Create a new object of the random class
            var random = new Random();
            
            // the Next method returns a non-negative random number that is less than the specified maximum
            // the int returned is stored in the variable 'i'
            var i = random.Next(input.Length);

            // Output the result. The random number generated will also serve as the index of the element in the array.
            return input[i];
        }
    }
}
