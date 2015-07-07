using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a customer class and add the following properties to the class. First Name, Last Name, Age, Birthdate. Ensure that you are
// using the right data types for each property.
namespace OOP___Customer_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local variables are in camelCase.
            // The following method of object instantiation is the method recommended by Steve Walther.
            var sally = new Customer
            {
                FirstName = "Sally",
                LastName = "Williams",
                BirthYear = 2028,
                Age = 23
            };

            Debug.Assert(sally.Age == 23, "Sally is 23");

            var mike = new Customer
            {   
                FirstName = "Mike",
                LastName = "Harrison",
                Age = 10,
                BirthYear = 2019
            };

            Debug.Assert(mike.Age == 10, "Mike is 10.");
        }
    }
}
