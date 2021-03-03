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
      for (int i = 0; i < 30; i++) { Console.WriteLine(""); }
      Random randnum = new Random();
      int num = randnum.Next(6);
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
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Would you like to make a new bread or pastry purchase? (type: 'bread,' 'pastry,', 'settle', or 'au revoir' to exit) \n");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Red;
      string menuInput = Console.ReadLine();
      Console.ResetColor();
      switch (menuInput.ToLower())
      {
        case "bread":
          BreadMenu();
          break;

        case "pastry":
          PastryMenu();
          break;

        case "settle":
          Pastry.ClearAll();
          Bread.ClearAll();
          Console.WriteLine($"\nAll settled up! You have {Pastry.PastryQuantity} pastries and {Bread.BreadQuantity} bread in your cart. \n");
          Menu();
          break;

        case "au revoir":
          Console.WriteLine("Pierre: Au revoir!");
          break;

        default:
          Console.WriteLine("Pierre only understands 'bread,' 'pastry', 'settle', or 'au revoir.'");
          Menu();
          break;
      }
    }
    public static void BreadMenu()
    {
      Console.WriteLine("\nPierre: How many bread would you like to purchase? Un pain: $5; Current sale: Buy 2, get 1 free! Très beau! \n");
      Console.ForegroundColor = ConsoleColor.Red;
      int breadNum = int.Parse(Console.ReadLine());
      Console.ResetColor();
      Bread newBread = new Bread();
      int totalBreadCost = newBread.TotalBreadCost(breadNum);
      Console.WriteLine($"\nPierre: {breadNum} bread? Alright! That will cost ${totalBreadCost}. Looks like you got yourself {Bread.FreeBread} free bread! Ouah!");
      Console.WriteLine($"\nPierre: You have {Pastry.PastryQuantity} pâtisserie and {Bread.BreadQuantity} pane. The total for everything is ${Pastry.TotalCost}. Exquis! \n");
      Menu();
    }
    public static void PastryMenu()
    {
      Console.WriteLine("\nPierre: How many pastries would you like to purchase? Une pâtisserie: $2; Current sale: Buy 3 for $5! \n");
      Console.ForegroundColor = ConsoleColor.Red;
      int pastryNum = int.Parse(Console.ReadLine());
      Console.ResetColor();
      double totalPastryCost = Pastry.PastryCost(pastryNum);
      Console.WriteLine($"\nPierre: {pastryNum} pâtisserie? Alright! That will cost ${totalPastryCost}.");
      Console.WriteLine($"\nPierre: You have {Pastry.PastryQuantity} pâtisserie and {Bread.BreadQuantity} pane. The total for everything is ${Pastry.TotalCost}. Exquis! \n");
      Menu();
    }
  }
}