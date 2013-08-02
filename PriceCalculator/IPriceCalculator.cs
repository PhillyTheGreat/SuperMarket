using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriceCalculator
{
    public interface IPriceCalculator
    {
        decimal CalculatePriceForFreeItemsDeal(FreeItemsDealPrice itemPrice);

        decimal CalculatePriceForDiscountDeal(DiscountedDealPrice itemPrice);
    }


    public enum PriceType
    {
        FreeItems,

        DiscountedPriceForAmount,

        Straight
    }
}
