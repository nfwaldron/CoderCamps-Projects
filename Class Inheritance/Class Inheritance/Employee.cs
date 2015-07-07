using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance
{
    abstract class Employee
    {
        // Class Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Class Methods

        public string ShowFullName()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}", FirstName, LastName);

            return FirstName + " " + LastName ;     
        }
    }

    class FullTimeEmployee: Employee
    {
        // Class Properties
        public int YearsEmployed { get; set; }
    }

    class ContractEmployee: Employee
    {
        // Class Property
        public int MonthsEmployed { get; set; }
    }
}
