using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a Product class that satisfies the following requirements
 * You should not be able to create a product without providing a value for the Name, Price, and UnitsInStock properties.
 * You should be able to create a product without specifying a product Description.
 * You should be able to modify the Name, Price, and UnitsInStock properties after the product is created.
 */ 

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("Spring Water", 1.05m, 3);

            product1.Description = "From the Islands of Fiji. Natural Artesian Water";
            product1.Price = 3.50m;

            Console.WriteLine("These are the updated properties of your class: Description = " + product1.Description + " Price = " + product1.Price);
           
        }
    }
}
