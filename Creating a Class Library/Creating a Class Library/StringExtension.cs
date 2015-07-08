using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_a_Class_Library
{
    public static class StringExtension
    {
        // Static methods means that you do not need to instantiate an object in order to call the method.
        public static string CleanInput(this string input) // this is saying I want to extend a string, with the CleanInput method
        {
            return input.ToLowerInvariant().Trim();
        }
    }
}
