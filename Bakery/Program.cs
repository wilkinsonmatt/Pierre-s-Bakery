using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\n\n~~~~~~ Welcome to Pierre's Bakery ~~~~~~\n\n\n");
      Console.WriteLine("Bread: $5.00 a loaf (Buy 2, get 1 free)\n\n");
      Console.WriteLine("Pastry: Buy 1 for $2.00 or 3 for $5.00\n\n\n");
      Console.WriteLine("How many loafs of bread would you like to buy?");
      int breadOder = int.Parse(Console.ReadLine());
      Bread userBreadOrder = new Bread(breadOder); 
      // Console.WriteLine("How many Pastries would you like to buy?");
      // int pastryResponse = int.Parse(Console.ReadLine());
      // Console.WriteLine("For " + userCoffee.Quantity + " loafs of bread it will be $" + userCoffee.CoffeeCost());
      // Console.WriteLine("For " + userCoffee.Quantity + " Pastries it will be $" + userCoffee.CoffeeCost());
      // Console.WriteLine("Total Cost: $" + userCoffee.CoffeeCost());
      // Console.WriteLine("Do you want to purchase more?");
    }
  }
}