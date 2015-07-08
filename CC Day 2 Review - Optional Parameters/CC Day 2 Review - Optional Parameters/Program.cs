using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Day_2_Review___Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product
            {
                Name = "Milk",
                Price = 2.99m
            };

            // Price without tax and without a discount
            var totalWithoutTax = product1.CalculateTotal();
            Console.WriteLine("Product: {0}, Price: {1:c}", product1.Name, totalWithoutTax);

            var totalWithTax = product1.CalculateTotal(taxRate:0.07m);
            Console.WriteLine("Product: {0}, Price: {1:c}", product1.Name, totalWithTax);

        }
    }
}
