using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatingArguements
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product
            {
                Price = 10.00m,
                Name = "Milk"
            };
            
            // Within Range
            var result = product1.CalculateTotalPriceWithTax(.07m);

            // Out of Range High
            // var result = product1.CalculateTotalPriceWithTax(.11m);

            // Out of Range Low
            //var result = product1.CalculateTotalPriceWithTax(-5.00m);

            Console.WriteLine("The price of {0} = {1:c} ", product1.Name, result);
            Console.Read();
        }
    }
}
