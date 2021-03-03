using System;
using System.Collections.Generic;
using BreadSales.Models;
using PastrySales.Models;

namespace Main
{
  public class Program
  {

    public static void Main()
    {
      Random randnum = new Random();
      int num = randnum.Next(7);
      string[] frenchPhrases = { "Dis-moi ce que tu manges, je te dirai qui tu es.", "Un bon repa doit commencer par la faim.", "Chaque cuisinier a sa sauce!", "Quand le vin est tiré, il faut le boire.", "Un bon repas adoucit l'esprit et régénère le corps.", "Aprés bon vin, bon coussin..." };
      string[] frenchPhrasesTranslated = { "Tell me what you eat, and I'll tell you who you are.", "A good meal starts with hunger", "Each cook has his own sauce!", "When the wine is poured, it must be drunk.", "A good meal softens the mind and regenerates the body.", "After a good wine, a good pillow..." };
      Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("         Welcome to Pierre's Bakery!");
      Console.ResetColor();
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
      Console.WriteLine($"Pierre: {frenchPhrases[num]}");
      Console.WriteLine($"({frenchPhrasesTranslated[num]})");
      Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Bread: $5; Current sale: Buy 2, get 1 free!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
      Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Pastry: $2; Current sale: Buy 3 for $5!");
      Console.ResetColor();
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
      Bread newBread = new Bread();
      int totalBreadCost = newBread.TotalBreadCost(breadNum);
      Console.WriteLine($"{breadNum} bread? Alright! That will cost ${totalBreadCost}. Looks like you got yourself {newBread.FreeBread} free bread!");
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