using System;
namespace BakerySales.Models
{
  public abstract class Bakery
  {
    public int Counter { get; set; }
    public int CurrentCost { get; set; }
    public static int FreeBread { get; set; }
    public static int TotalCost { get; set; }
  }
}