using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Main
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
      Menu();
    }

    public static void Menu()
    {
      Console.WriteLine("Would you like to make a new bread or pastry purchase? (type: bread, pastry, or exit");
      string menuInput = Console.ReadLine();
      switch (menuInput)
      {
        case "bread":
          Bread();
          break;

        case "exit":
          Console.WriteLine("Goodbye!");
          break;

        default:
          Console.WriteLine("Please input valid choice (bread, pastry, or exit)");
          Menu();
          break;
      }
    }
    public static void Bread()
    {
      Console.WriteLine("How many bread would you like to purchase? Single loaf: $5; Current sale: Buy 2, get 1 free!");
      string breadNum = Console.ReadLine();
      int totalBreadCost = Bread.TotalBreadCost(int.Parse(breadNum));
      // Console.WriteLine($"That will cost {Bread.BreadCost(breadNum)} ");
    }
  }
}