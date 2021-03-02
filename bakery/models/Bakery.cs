using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Bread
    {
    int breadCounter { get; set; }
    int breadCost { get; set; }

  public static int BreadCost(int num) {
    int result = (num / 2) >= 1 ? (int)(num / 2) : 0;
    return result;
  } 
}
}