using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatingArguements
{
    class Product
    {
        private decimal _price;

        public decimal Price
        {
            get { return _price; }

            set
            {
                if (_price < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("Price must be greater than zero");
                }

                _price = value; }
        }
        
        public string Name { get; set; }

        public decimal CalculateTotalPriceWithTax(decimal taxRate = 0.0m)
        {
            if (taxRate > 0.10m || taxRate < 0.0m)
            {
                throw new ArgumentOutOfRangeException("Value is outside of the acceptable range");
            }
                return this.Price + (this.Price * taxRate);
            
        }

    }
}
