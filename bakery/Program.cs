using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Main
{
  public class Program
  {
    public static void Main(){
      Console.Write("Welcome to Pierre's Bakery!");
      Menu();
    }

    public static void Menu(){
      Console.WriteLine("Would you like to make a new bread or pastry purchase? (type: bread, pastry, or exit");
    }
  }
}