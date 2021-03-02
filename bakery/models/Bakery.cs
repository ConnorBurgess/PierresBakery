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
    public static int pastryCost { get; set; }
    public static int pastryCounter { get; set; }
    public static int PastryCost(int num)
    {
      Pastry.pastryCost = (pastryCounter % 3) == 0 ? pastryCounter * 2 : 0;
      return Pastry.pastryCost;
    }
  }
}