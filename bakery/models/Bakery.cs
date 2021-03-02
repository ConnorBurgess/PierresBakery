using System;
namespace Bakery.Models
{
  public class Bread
  {
    public static int breadCounter { get; set; }
    public static int breadCost { get; set; }
    public static int freeBread { get; set; }

    public static int TotalBreadCost(int num)
    {
      Bread.breadCounter = num;
      Bread.freeBread = (breadCounter / 2) >= 1 && (breadCounter % 2 != 0) ? (int)(breadCounter / 2) 
        : (breadCounter / 2) >= 1 && (breadCounter % 2 == 0) ? (breadCounter / 2) - 1
          : 0;
      return (breadCounter - freeBread) * 5;
    }
  }
  public class Pastry
  {
    public static double pastryCost { get; set; }
    public static double pastryCounter { get; set; }
    public static double PastryCost(double num)
    {
      Pastry.pastryCounter = num;
      Pastry.pastryCost = (pastryCounter % 3) == 0 ? (pastryCounter / 3) * 5
        : pastryCounter > 3 ? Math.Floor(pastryCounter / 3) * 5 + (pastryCounter % 3) * 2
          : pastryCounter * 2;

      return Pastry.pastryCost;
    }
  }
}