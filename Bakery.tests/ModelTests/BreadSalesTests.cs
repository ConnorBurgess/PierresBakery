using BreadSales.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BreadSales.Tests
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
      newBread.TotalBreadCost(3);
      Assert.AreEqual(1, Bread.FreeBread);
    }

  }
}