using System;
using BakerySales.Models;
namespace PastrySales.Models
{
  public class Pastry : Bakery
  {
    public int PastryCost(int num)
    {
      Pastry.Quantity += num;
      Counter = num;
      CurrentCost = (Counter % 3) == 0 ? (Counter / 3) * 5
        : Counter > 3 ? (Counter / 3) * 5 + (Counter % 3) * 2
          : Counter * 2;
      Pastry.TotalCost += CurrentCost;
      return CurrentCost;
    }
    public static void ClearAll()
    {
      Pastry.TotalCost = 0;
      Pastry.Quantity = 0;
    }
  }
}