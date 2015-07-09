using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{
    // Create Parent Class Employee 
    class Employee
    {
        // Class Properties
        public string Name { get; set; }
        public string Position { get; set; }
        public int ReportCount { get; set; }

        // Class Methods

        // This constructor with parameters ensures that objects of the class Employee cannot be created without providing
        // the necessary information upon onject instantiation.
        public Employee(string name, string position, int reportcount)
        {
            this.Name = name;
            this.Position = position;
            this.ReportCount = reportcount;
        }

        public void Log()
        {
            Console.WriteLine("Employee Name: {0}, Employee Position: {1} Employees Overseen: {2}", this.Name, this.Position, this.ReportCount);
        }

    }
}
