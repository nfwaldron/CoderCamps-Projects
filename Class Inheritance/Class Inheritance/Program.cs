using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bill = new FullTimeEmployee()
            {
                FirstName = "Bill",
                LastName = "Gates",
                YearsEmployed = 5
            };

            var steve = new ContractEmployee()
            {
                FirstName = "Steve",
                LastName = "Jobs",
                MonthsEmployed = 2
            };

            string result = bill.ShowFullName();
            Console.WriteLine(result);
            Console.ReadLine();
            Debug.Assert(result == "Bill Gates");
        }
    }
}
