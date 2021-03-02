using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadCost_BuyTwoGetOneFree_True()
    {
      Bread newBread = new Bread();
      Bread.breadCounter = 2;
      Assert.AreEqual(1, Bread.BreadCost(Bread.breadCounter));
    }

  }
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfBread_Bread()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PastryCost_BuyThreeTwoDollarsEach_True()
    {
      Pastry newPastry = new Pastry();
      Pastry.pastryCounter = 6;
      Assert.AreEqual(12, Pastry.PastryCost(Pastry.pastryCounter));
    }
  }
}