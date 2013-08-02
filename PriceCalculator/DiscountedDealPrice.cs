using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
    public class DiscountedDealPrice
    {
        public IItemPrice ItemPrice { get; set; }

        public decimal DealPrice { get; set; }
    }

}
