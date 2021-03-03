using BreadSales.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BreadSales.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {

    public void Dispose()
    {
      Bread.ClearAll();
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void TotalBreadCost_BuyTwoGetOneFree_Int()
    {
      Bread newBread = new Bread();
      newBread.TotalBreadCost(3);
      Assert.AreEqual(1, Bread.FreeBread);
    }

    [TestMethod]
    public void TotalBreadCost_BuyTwoGetOneFreePlusOneForFive_Int()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(15, newBread.TotalBreadCost(4));
    }
    [TestMethod]
    public void TotalCost_TotalCostIncrements_Int()
    {
      Bread newBread = new Bread();
      newBread.TotalBreadCost(3);
      Assert.AreEqual(10, Bread.TotalCost);
    }
  }
}