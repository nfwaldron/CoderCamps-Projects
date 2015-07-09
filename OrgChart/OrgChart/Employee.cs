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

        // You could create a list of Employees to represent the relationship between employees
        public List<Employee> Report { get; set; }

        // Read Only Property. Setter, and private property removed
        public int ReportCount
        {
            get { return this.Report.Count; }     
        }

        public Employee()
        {
            this.Report = new List<Employee>();
        }

       
    }
}
