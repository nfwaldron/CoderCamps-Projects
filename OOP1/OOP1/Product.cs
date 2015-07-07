using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product
    {
        // To create a class property, type 'prop' tab, tab.
        // Property is the price of the profuct
        public decimal Price { get; set; }

        // Name of the Product
        public string Name { get; set; }

        // Create a method to calculate tax and discounts (if applicable)
        // A new feature of C# allows you to supply default values for paramenters. Syntax is 
        // public decimal CalculateTax( decimal taxRate = 0.08m, decimal discount = 2.00m)
        public decimal CalculateTax( decimal taxRate = 0.08m, decimal discount = 2.00m)
        {
            // The this keyword refers to the current instance of the class.
            // It essentially acts as a placeholder, that references to the object itself
            return this.Price + (this.Price * taxRate - discount);
        }

    }
}
