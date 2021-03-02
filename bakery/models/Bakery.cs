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
      int result = (breadCounter / 2) >= 1 ? (int)(breadCounter / 2) : 0;
      return result;
    }
  }
}