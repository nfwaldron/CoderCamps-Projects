using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a new Visual Studio Console Application named OrgChart.
 * Imagine that you have the following org chart:
 * Bill reports to nobody
 * Sam, Fred, and Jane report to Bill
 * Alice reports to Fred
 * Model this org chart with Employee classes. Also, add a property to each Employee 
 * that represents the ReportsCount (the number of employees that report to the current employee)
 * Remember to use Debug.Assert() to verify the behavior of your code.
 */

namespace OrgChart
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Employees
            var bill = new Employee("Bill Gates", "Senior Developer", 4);
            var sam = new Employee("Sam", "Mid-Level Developer", 0);
            var fred = new Employee("Fred", "Mid-Level Developer", 1);
            var jane = new Employee("Jane", "Mid-Level Developer", 0);
            var alice = new Employee("Alice", "Junior-Level Developer", 0);

            //Create collection List to hold employees
            var employeeList = new List<Employee>();

            //I had to comment out my constructor w/ parameter in order for this to work. Is there a way to 
            // initialize an object here without commenting out the constructor with parameter in the class .cs file?

            // Add Employee objects to the collection list
            employeeList.Add(bill);
            employeeList.Add(sam);
            employeeList.Add(fred);
            employeeList.Add(jane);
            employeeList.Add(alice);

            // The for each item (Employee object) in the strongly typed List employee list, perform the .Log() function on the item  
            //
            foreach (var item in employeeList)
            {
                // Every item in the list, perform the .Log() method. 
                item.Log();
            }


        }
    }
}
