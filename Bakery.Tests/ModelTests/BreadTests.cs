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
    public void  BreadCost_CostOneCupNoDiscount_Int()
    {
      //Arrange
      int coffeeQuantity = 1;
      double coffeeCost = 5;
      //Act
      Coffee coffeeOrder = new Coffee(coffeeQuantity);
      //Assert
      Assert.AreEqual(coffeeCost, coffeeOrder.CoffeeCost());
    }
  }
}