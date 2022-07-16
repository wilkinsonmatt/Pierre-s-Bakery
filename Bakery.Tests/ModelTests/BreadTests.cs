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
    public void IsQuantityGreaterThanZero_SeesIfNumberIsNotNegitive_True()
    {
      int breadQuantity = 1;
      Bread testOrder = new Bread(breadQuantity);
      Assert.AreEqual(true, testOrder.IsQuantityGreaterThanZero());
    }
    [TestMethod]
    public void IsQuantityGreaterThanZero_SeesIfNumberIsNotNegitive_False()
    {
      int breadQuantity = -1;
      Bread testOrder = new Bread(breadQuantity);
      Assert.AreEqual(false, testOrder.IsQuantityGreaterThanZero());
    }


    [TestMethod]
    public void GetPriceOfBreadOrder_SeesIfNumberIsNotNegitive_Int()
    {
      int breadQuantity = 1;
      int totalCostOfBread = 2;
      Bread testOrder = new Bread(breadQuantity);
      Assert.AreEqual(totalCostOfBread, testOrder.GetPriceOfBreadOrder());
    }

  }
}