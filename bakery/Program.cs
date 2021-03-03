using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Main
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("         Welcome to Pierre's Bakery!");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
      Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Bread: $5; Current sale: Buy 2, get 1 free!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
      Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Pastry: $2; Current sale: Buy 3 for $5!");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");



      Menu();
    }

    public static void Menu()
    {
      Console.WriteLine("Would you like to make a new bread or pastry purchase? (type: bread, pastry, or exit");
      string menuInput = Console.ReadLine();
      switch (menuInput)
      {
        case "bread":
          BreadMenu();
          break;

        case "pastry":
          PastryMenu();
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
    public static void BreadMenu()
    {
      Console.WriteLine("How many bread would you like to purchase? Single loaf: $5; Current sale: Buy 2, get 1 free!");
      int breadNum = int.Parse(Console.ReadLine());
      int totalBreadCost = Bread.TotalBreadCost(breadNum);
      Console.WriteLine($"{breadNum} bread? Alright! That will cost ${totalBreadCost}. Looks like you got yourself {Bread.freeBread} free bread!");
      Menu();
    }
    public static void PastryMenu()
    {
      Console.WriteLine("How many pastries would you like to purchase? Single pastry: $2; Current sale: Buy 3 for $5!");
      int pastryNum = int.Parse(Console.ReadLine());
      double totalPastryCost = Pastry.PastryCost(pastryNum);
      Console.WriteLine($"{pastryNum} pastries? Alright! That will cost ${totalPastryCost}.");
      Menu();
    }
  }
}