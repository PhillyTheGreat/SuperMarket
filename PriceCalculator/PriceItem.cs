using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
    public class ItemPrice : IItemPrice
    {
        public int AmoundOfItems { get; set; }

        public int ItemInterval { get; set; }

        public decimal PricePerItem { get; set; }

        public PriceType ItemPriceType { get; set; }

    }
}
