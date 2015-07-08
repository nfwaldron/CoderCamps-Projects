using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee
            {
                Name = "Conner Rhoden",
                StartDate = DateTime.Parse("07/08/2015"),
                EndDate = null
            };
        }
    }
}
