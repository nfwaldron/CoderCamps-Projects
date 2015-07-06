using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 8;
            var b = 0;

            // Debug.Assert() checks a condition, and if the condition is false, outputs a message to the user
            Debug.Assert(b != 0, "b can't be zero!");

            var result = a / b;
        
        }

    }
}
