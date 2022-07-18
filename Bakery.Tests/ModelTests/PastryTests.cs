using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void IsQuantityGreaterThanZero_PostiveQuantity_True()
    {
      int pastryQuantity = 1;
      Pastry testOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(true, testOrder.IsQuantityGreaterThanZero());
    }
    [TestMethod]
    public void IsQuantityGreaterThanZero_NegativeQuantity_False()
    {
      int pastryQuantity = -1;
      Pastry testOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(false, testOrder.IsQuantityGreaterThanZero());
    }


    [TestMethod]
    public void GetPriceOfPastryOrder_PriceOfOnePastry_Int()
    {
      int pastryQuantity = 1;
      int totalCostOfPastry = 2;
      Pastry testOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(totalCostOfPastry, testOrder.GetPriceOfPastryOrder());
    }
    [TestMethod]
    public void GetPriceOfPastryOrder_PriceOfOnePastries_Int()
    {
      int pastryQuantity = 3;
      int totalCostOfPastry = 5;
      Pastry testOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(totalCostOfPastry, testOrder.GetPriceOfPastryOrder());
    }
    [TestMethod]
    public void GetPriceOfPastryOrder_PriceOfFourPastries_Int()
    {
      int pastryQuantity = 4;
      int totalCostOfPastry = 7;
      Pastry testOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(totalCostOfPastry, testOrder.GetPriceOfPastryOrder());
    }
    [TestMethod]
    public void GetPriceOfPastryOrder_PriceOfNegtivePastries_Int()
    {
      int pastryQuantity = -1;
      int totalCostOfPastry = 0;
      Pastry testOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(totalCostOfPastry, testOrder.GetPriceOfPastryOrder());
    }

  }
}