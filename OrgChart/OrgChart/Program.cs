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
        static void DisplayOrgChart(Employee employee, int level = 0)
        {
            //indent
            for (var i = 0; i < level; i++)
            {
                Console.Write("---");
            }

            //SHow Name and report count
            Console.WriteLine("{0} has the following {1} reports:", employee.Name, employee.ReportCount);

            //Show reports
            level++;

            foreach (var report in employee.Report)
            {
                DisplayOrgChart(report, level);
            }

        }


        static void Main(string[] args)
        {
            //Create Employees
            var bill = new Employee
            {
                Name = "Bill Gates",
                Report = new List<Employee>{
                    new Employee {Name = "Sam"},
                    new Employee {Name = "Fred",
                                  Report = new List<Employee>{
                                      new Employee{Name = "Alice"}
                                  }
                                  },
                    new Employee {Name = "Jane"}
                }
            };

            DisplayOrgChart(bill);
            Console.ReadLine();

        }
    }
}
