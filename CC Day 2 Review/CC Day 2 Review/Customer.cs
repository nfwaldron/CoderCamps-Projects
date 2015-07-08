using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Day_2_Review
{
    class Customer
    {
        // Class Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }

            set {
                if (value < 0)
                {
                    // Checks for a condition; if the condition is false, outputs messages and displays a message box that shows the call stack. 
                    Debug.Assert(value > 0, "Age cannot be less than zero");

                    // Assign the value to the private Class Property _age
                    _age = 0;

                    // Output the new age
                    Console.WriteLine("Age is {0}", _age);

                }

                else
	            {
                    // If the value entered is greater than zero, assign the value in 'value' to _age = value
                    _age = value;
	            }
            
            }
        }

        // Class Methods

        public void ShowData()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Age: {2}", this.FirstName, this.LastName, this.Age);
        }
        
        
    }
}
