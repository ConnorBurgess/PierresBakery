using System;
using BakerySales.Models;
namespace PastrySales.Models
{
  public class Pastry : Bakery
  {
    public static int PastryCost(int num)
    {
      Pastry newPastry = new Pastry();
      Pastry.PastryQuantity += num;
      newPastry.Counter = num;
      newPastry.CurrentCost = (newPastry.Counter % 3) == 0 ? (newPastry.Counter / 3) * 5
        : newPastry.Counter > 3 ? (newPastry.Counter / 3) * 5 + (newPastry.Counter % 3) * 2
          : newPastry.Counter * 2;
      Pastry.TotalCost += newPastry.CurrentCost;
      return newPastry.CurrentCost;
    }
    public static void ClearAll()
    {
      Pastry.TotalCost = 0;
      Pastry.PastryQuantity = 0;
    }
  }
}