using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalculator;

namespace TestPriceCalculator
{
    [TestClass]
    public class TestPriceCalculator
    {
        [TestMethod]
        public void FreeItems()
        {
            FreeItemsDealPrice freeItemsDeal = new FreeItemsDealPrice();
            freeItemsDeal.ItemPrice = new ItemPrice();

            freeItemsDeal.AmountOfFreeItems = 2;
            freeItemsDeal.ItemPrice.PricePerItem = (decimal)2.5;
            freeItemsDeal.ItemPrice.ItemInterval = 5;
            freeItemsDeal.ItemPrice.AmoundOfItems = 8;

            IPriceCalculator priceCalculator = new PriceCalc();

            decimal price = priceCalculator.CalculatePriceForFreeItemsDeal(freeItemsDeal);

            Assert.AreEqual(15, price);
        }

        [TestMethod]
        public void DiscountedItemDealEightItems()
        {
            DiscountedDealPrice discountedDeal = new DiscountedDealPrice();
            discountedDeal.DealPrice = 5;
            discountedDeal.ItemPrice = new ItemPrice();
            discountedDeal.ItemPrice.AmoundOfItems = 8;
            discountedDeal.ItemPrice.ItemInterval = 5;
            discountedDeal.ItemPrice.PricePerItem = (decimal)2.5;

            IPriceCalculator priceManager = new PriceCalc();
            decimal priceToBePaid = priceManager.CalculatePriceForDiscountDeal(discountedDeal);

            Assert.AreEqual((decimal)12.5, priceToBePaid);
        }

        [TestMethod]
        public void DiscountedItemDealSixteenItems()
        {
            DiscountedDealPrice discountedDeal = new DiscountedDealPrice();
            discountedDeal.DealPrice = 5;
            discountedDeal.ItemPrice = new ItemPrice();
            discountedDeal.ItemPrice.AmoundOfItems = 16;
            discountedDeal.ItemPrice.ItemInterval = 5;
            discountedDeal.ItemPrice.PricePerItem = (decimal)2.5;

            IPriceCalculator priceManager = new PriceCalc();
            decimal priceToBePaid = priceManager.CalculatePriceForDiscountDeal(discountedDeal);

            Assert.AreEqual((decimal)17.5, priceToBePaid);
        }
    }


}
