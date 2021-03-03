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
    public void TotalBreadCost_BuyTwoGetOneFree_True()
    {
      Bread newBread = new Bread();
      Bread.TotalBreadCost(3);
      Assert.AreEqual(1, Bread.freeBread);
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
    public void PastryCost_BuyThreeForFiveDollars_True()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(10, Pastry.PastryCost(6));
    }
    [TestMethod]
    public void PastryCost_ThreeForFivePlusOneForTwo_True()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(12, Pastry.PastryCost(7));
    }
  }
}