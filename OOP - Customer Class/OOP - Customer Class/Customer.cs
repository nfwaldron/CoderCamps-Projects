using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Customer_Class
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // Use input validation to ensure that the user cannot set an age that is less than zero for instances of the Customer class.
        // Private variables are usually named _propertyName
        private int _age;

        public int Age
        {
            get { return _age; }

            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                { _age = value; }
            }
        }
        
        public int BirthYear { get; set; }

    }
}
