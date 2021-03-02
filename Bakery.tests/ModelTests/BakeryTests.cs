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
      Assert.AreEqual(1, Bread.BreadCost(2));
    }

  }
}