using PastrySales.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PastrySales.Tests
{
  [TestClass]
  public class PastryTests
  {

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