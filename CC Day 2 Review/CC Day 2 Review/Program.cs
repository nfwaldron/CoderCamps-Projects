using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Day_2_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            var mike = new Customer
            {
                FirstName = "Michael",
                LastName = "Smith",
                BirthYear = 1988,
                Age = 50
            };

            var sandy = new Customer
            {
                FirstName = "Sandy",
                LastName = "Smith",
                BirthYear = 1989,
                Age = 23
            };
            mike.ShowData();
            sandy.ShowData();
            Console.ReadLine();
        }
    }
}
