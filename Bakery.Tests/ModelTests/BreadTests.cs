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
      int testNum = 1;
      Bread testOrder = new Bread(testNum);
      Assert.AreEqual(true, testOrder.IsQuantityGreaterThanZero());
    }
  }
}