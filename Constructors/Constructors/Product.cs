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
    class Product
    {
        // Class Properties 
        public int UnitsInStock { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description  { get; set; }

        // Class Methods

        // Constructor is a method with the same name as a class name, that is called automatically when the class is created.

        // To create a constructor quickly, hit 'ctor' and 'tab'
        // You can create a constructor with parameters in order to force a user to provide certain information when creating a class.
        // In the parameter field, type the data type and the name of the parameter you want to use.
        
        public Product(string name, decimal price, int unitsInStock)
        {
            this.Name = name;
            this.Price = price;
            this.UnitsInStock = unitsInStock;
            this.Description = "Undefined";

            Console.WriteLine("These are the default properties of your class: Name = " + Name + " Price = " + Price + " Units in Stock = "+ UnitsInStock + " Description = " + Description);
        }
       

       

    }
}
