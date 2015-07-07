using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        
        // Modify calculator so that it supports a variable number of aruguements.
        // A parameter array enables you to accept zero to an infinite number of arguments. 
        // The parameter array must be the last parameter listed as parameters that a method can accept. 
        public double CalculateSum ( params double [] numberArray)
        {
            double sum = 0;

            // Create a for loop to loop through the array
            for (int i = 0; i < numberArray.Length; i++)
            {
                // Add the sum of the elements in the array
                sum += numberArray[i];
            }
            // return the sum
            return sum; 
        }
    }
}
