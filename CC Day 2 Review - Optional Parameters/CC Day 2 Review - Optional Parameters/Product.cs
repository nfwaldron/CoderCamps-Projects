using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Day_2_Review___Optional_Parameters
{
    class Product
    {
        // Name
        public string Name { get; set; }
        // Price
        public decimal Price { get; set; }
        
        public decimal CalculateTotal( decimal taxRate = 0, decimal discount = 0 )
        {
            return this.Price + (this.Price * taxRate) - (this.Price * discount);
        }
    }
}
