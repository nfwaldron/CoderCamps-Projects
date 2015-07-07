using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Classes
{
    class Customer
    {

        // Class Properties
        public string Name { get; set; }
        public Account SavingAccount { get; set; }
        public Account CheckingAccount { get; set; }

        // Class Methods

        // Constructor that contains instances of the Account Class
        public Customer()
        {
            // Creating istances of the account object, and assigning it to a property
            this.CheckingAccount = new Account();
            this.SavingAccount = new Account();
        }

        public void Transfer(decimal transferAmount)
        {
            this.Log(transferAmount);
            CheckingAccount.Amount -= transferAmount;
            SavingAccount.Amount += transferAmount;
            this.Log(transferAmount);
        }

        public void Log(decimal transAmount)
        {
            Console.WriteLine("Checking Account: {0:c}, Saving Account: {1:c}, Transfer Amount: {2:c}", CheckingAccount.Amount, SavingAccount.Amount, transAmount);

        }
    }
}
