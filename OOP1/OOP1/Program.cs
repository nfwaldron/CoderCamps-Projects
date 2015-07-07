using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the class Product.
            var product1 = new Product();
            product1.Name = "Tesla";
            product1.Price = 123000.00m;

            // Another syntax for creating a new instance of an class Product.
            // *** This is the recommended syntax, per Steve Walther ***
            var eggs = new Product
            {
                Name = "Eggs",
                Price = 3.50m
            };

            // display the name and tax

            // Named arguements in C# allow you to label the arguements
            var tax = eggs.CalculateTax(taxRate:0.08m, discount:0.0m);
            Console.WriteLine("Tax is " + tax.ToString("c"));

            // pause
            Console.ReadLine();

        }
    }
}
