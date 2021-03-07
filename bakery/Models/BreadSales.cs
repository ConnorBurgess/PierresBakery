using System;
using BakerySales.Models;
namespace BreadSales.Models
{
  public class Bread : Bakery
  {
    public int TotalBreadCost(int num)
    {
      Bread.Quantity += num;
      Counter = num;
      Bread.FreeBread = (Counter / 3) >= 1 ? Counter / 3 : 0;
      CurrentCost = (Counter - Bread.FreeBread) * 5;
      Bread.TotalCost += CurrentCost;
      return CurrentCost;
    }
    public static void ClearAll()
    {
      Bread.TotalCost = 0;
      Bread.Quantity = 0;
      Bread.FreeBread = 0;
      
    }
  }
}