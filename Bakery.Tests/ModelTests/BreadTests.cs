using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void IsQuantityGreaterThanZero_PostiveQuantity_True()
    {
      int breadQuantity = 1;
      Bread testOrder = new Bread(breadQuantity);
      Assert.AreEqual(true, testOrder.IsQuantityGreaterThanZero());
    }
    [TestMethod]
    public void IsQuantityGreaterThanZero_NegativeQuantity_False()
    {
      int breadQuantity = -1;
      Bread testOrder = new Bread(breadQuantity);
      Assert.AreEqual(false, testOrder.IsQuantityGreaterThanZero());
    }


    [TestMethod]
    public void GetPriceOfBreadOrder_OneLoafOfBread_Int()
    {
      int breadQuantity = 1;
      int totalCostOfBread = 5;
      Bread testOrder = new Bread(breadQuantity);
      Assert.AreEqual(totalCostOfBread, testOrder.GetPriceOfBreadOrder());
    }
    [TestMethod]
    public void GetPriceOfBreadOrder_MultipleOThreeLoafs_Int()
    {
      int breadQuantity = 3;
      int totalCostOfBread = 10;
      Bread testOrder = new Bread(breadQuantity);
      Assert.AreEqual(totalCostOfBread, testOrder.GetPriceOfBreadOrder());
    }
    [TestMethod]
    public void GetPriceOthfBreadOrder_MoreThanThreeLoafs_Int()
    {
      int breadQuantity = 4;
      int totalCostOfBread = 15;
      Bread testOrder = new Bread(breadQuantity);
      Assert.AreEqual(totalCostOfBread, testOrder.GetPriceOfBreadOrder());
    }

  }
}