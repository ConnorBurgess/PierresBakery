using System;
using BakerySales.Models;
namespace BreadSales.Models
{
  public class Bread : Bakery
  {
    public int TotalBreadCost(int num)
    {
      Bread newBread = new Bread();
      newBread.Counter = num;
      Bread.FreeBread = (newBread.Counter / 3) >= 1 ? newBread.Counter / 3 : 0;
      return newBread.CurrentCost = (newBread.Counter - Bread.FreeBread) * 5;
    }
  }
}