using System;
using BakerySales.Models;
namespace BreadSales.Models
{
  public class Bread : Bakery
  {
    public int TotalBreadCost(int num)
    {
      Bread newBread = new Bread();
      Bread.BreadQuantity += num;
      newBread.Counter = num;
      Bread.FreeBread = (newBread.Counter / 3) >= 1 ? newBread.Counter / 3 : 0;
      newBread.CurrentCost = (newBread.Counter - Bread.FreeBread) * 5;
      Bread.TotalCost += newBread.CurrentCost;
      return newBread.CurrentCost;
    }
    public static void ClearAll()
    {
      Bread.TotalCost = 0;
      Bread.BreadQuantity = 0;
      Bread.FreeBread = 0;
      
    }
  }
}