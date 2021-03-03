using System;
namespace Bakery.Models
{
  public class Bread
  {
    public static int breadCounter { get; private set; }
    public static int breadCost { get; private set; }
    public static int freeBread { get; private set; }

    public static int TotalBreadCost(int num)
    {
      breadCounter = num;
      freeBread = (breadCounter / 3) >= 1 ? breadCounter / 3 : 0;
      return breadCost = (breadCounter - freeBread) * 5;
    }
  }
  public class Pastry
  {
    public static double pastryCost { get; private set; }
    public static double pastryCounter { get; private set; }
    public static double PastryCost(double num)
    {
      pastryCounter = num;
      pastryCost = (pastryCounter % 3) == 0 ? (pastryCounter / 3) * 5
        : pastryCounter > 3 ? Math.Floor(pastryCounter / 3) * 5 + (pastryCounter % 3) * 2
          : pastryCounter * 2;

      return pastryCost;
    }
  }
}