using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Each customer in the bank can have multiple accounts with the following properties:
 * Id - A unique identifier for the account.
 * Type - An account can be a Checking or Savings account.
 * Amount - An account can have a certain amount of money.
 * IsOpen - A boolean property which represents whether the account is open or closed.
 * Create a customer named Alice that has two accounts:
 * A checking account with $100.00 that is open.
 * A savings account with $0.00 that is closed.
 * Extra Credit: Create a method on the Customer class named Transfer() that enables you to transfer money 
 * from one account to another.
*/ 


namespace Complex_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an new object of the Customer class and name it 'alice'.
            // Assign values to all of the properties.
            var alice = new Customer
            {
                Name = "Alice",

                // when we assing values to the properties they must correspond to the properties of the accoutn class
                CheckingAccount =
                {
                    Id = "12345",
                    Type = "Checkings",
                    Amount = 100.00m,
                    IsOpen = true
                },

                SavingAccount =
                {
                    Id = "67890",
                    Type = "Savings",
                    Amount = 0.00m,
                    IsOpen = false

                }

            };

            alice.Transfer(10.00m);
            Console.ReadLine();
           

        }
    }
}
