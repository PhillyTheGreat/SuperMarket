using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
    public interface IItemPrice
    {
        int AmoundOfItems { get; set; }

        int ItemInterval { get; set; }

        decimal PricePerItem { get; set; }

        PriceType ItemPriceType { get; set; }
    }
}
