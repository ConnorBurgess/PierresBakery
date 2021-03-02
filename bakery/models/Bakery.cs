using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Bread
  {
    public static int breadCounter { get; set; }
    public static int breadCost { get; set; }

    public static int BreadCost(int num)
    {
      Bread.breadCost = (breadCounter / 2) >= 1 ? (int)(breadCounter / 2) : 0;
      return Bread.breadCost;
    }
  }
  public class Pastry
  {
    public static double pastryCost { get; set; }
    public static double pastryCounter { get; set; }
    public static double PastryCost(double num)
    {
      Pastry.pastryCost = (pastryCounter % 3) == 0 ? (pastryCounter / 3) * 5
        : pastryCounter > 3 ? Math.Floor(pastryCounter / 3)* 5 + (pastryCounter % 3) * 2
          : pastryCounter * 2;
      return Pastry.pastryCost;
    }
  }
}