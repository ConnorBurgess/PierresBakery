using System;
namespace PastrySales.Models
{
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