using System;


namespace PriceCalculator
{
    public class PriceCalc : IPriceCalculator
    {
        /// <summary>
        /// Calculates the prices for the store
        /// </summary>
        /// <param name="priceObject"></param>
        /// <returns></returns>
        public decimal CalculatePriceForFreeItemsDeal(FreeItemsDealPrice priceObject)
        {
            //the amount of times the buyer qualifies for the free items
            var productIterations = GetProductIterations(priceObject);

            //the amount of free items the user will get
            int amountOfFreeItems = productIterations*priceObject.AmountOfFreeItems;

            //subtract the free items from the item count and calculate the price
            return (priceObject.ItemPrice.AmoundOfItems - amountOfFreeItems)*priceObject.ItemPrice.PricePerItem;

        }


        /// <summary>
        /// Calculates the price for a discounted price range deal
        /// </summary>
        /// <param name="itemPrice"></param>
        /// <returns></returns>
        public decimal CalculatePriceForDiscountDeal(DiscountedDealPrice itemPrice)
        {
            var productIterations = GetProductIterations(itemPrice);

            //The price of the items that is fell out of the price discounted deal
            decimal outOfRangeItemsPrice = (itemPrice.ItemPrice.AmoundOfItems -
                                           (productIterations*itemPrice.ItemPrice.ItemInterval))*
                                          itemPrice.ItemPrice.PricePerItem;

            //The price of the items that is fell in the price discounted deal
            decimal inRangeItemsPrice = productIterations*itemPrice.DealPrice;

            decimal totalPrice = outOfRangeItemsPrice + inRangeItemsPrice;

            return totalPrice;
        }


        private int GetProductIterations(FreeItemsDealPrice priceObject)
        {
            int productIterations = (int) Math.Floor(
                                                         (decimal) priceObject.ItemPrice.AmoundOfItems/
                                                         (priceObject.ItemPrice.ItemInterval + priceObject.AmountOfFreeItems)
                                                    );

            return productIterations;
        }


        private int GetProductIterations(DiscountedDealPrice priceObject)
        {
            int productIterations = (int)Math.Floor(
                                                         (decimal)priceObject.ItemPrice.AmoundOfItems /
                                                         (priceObject.ItemPrice.ItemInterval)
                                                    );

            return productIterations;
        }
    }
}
