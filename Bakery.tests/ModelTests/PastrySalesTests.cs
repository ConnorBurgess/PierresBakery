using PastrySales.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PastrySales.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryCost_BuyThreeForFiveDollars_True()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(10, newPastry.PastryCost(6));
    }

    [TestMethod]
    public void PastryCost_ThreeForFivePlusOneForTwo_True()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(12, newPastry.PastryCost(7));
    }

    [TestMethod]
    public void TotalCost_TotalCostIncrements_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.PastryCost(3);
      Assert.AreEqual(5, Pastry.TotalCost);
    }
  }
}