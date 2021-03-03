using System;
namespace BakerySales.Models
{
  public abstract class Bakery
  {
    public int CurrentCost { get; set; }
    public int TotalCost { get; set; }
    public static int FreeBread { get; set; }
    public int Counter { get; set; }
  }
}