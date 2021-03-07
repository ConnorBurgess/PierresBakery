using System;
namespace BakerySales.Models
{
  public abstract class Bakery
  {
    public int Counter { get; protected set; }
    public int CurrentCost { get; protected set; }
    public static int FreeBread { get; protected set; }
    public static int TotalCost { get; protected set; }
    public static int Quantity { get; protected set; }
  }
}