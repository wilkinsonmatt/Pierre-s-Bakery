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
      Console.WriteLine("\n\n~~~~~~ Welcome to Pierre's Bakery ~~~~~~");
      Shop();
    }

    public static void Shop()
    {
      Console.WriteLine("\n\n\n***Bread: $5.00 a loaf (Buy 2, get 1 free)***\n\n");
      Console.WriteLine("***Pastry: Buy 1 for $2.00 or 3 for $5.00***\n\n\n");

      Console.WriteLine("How many loafs of bread would you like to buy?");
      int breadQuantity = int.Parse(Console.ReadLine());
      Bread userBreadOrder = new Bread(breadQuantity); 

      Console.WriteLine("How many Pastries would you like to buy?");
      int pastryQuantity = int.Parse(Console.ReadLine());
      Pastry userPastryOrder = new Pastry(pastryQuantity); 

      Console.WriteLine("\n\nFor " + breadQuantity + " loafs of bread it will be $" + userBreadOrder.GetPriceOfBreadOrder());
      Console.WriteLine("For " + pastryQuantity + " Pastries it will be $" + userPastryOrder.GetPriceOfPastryOrder());
      Console.WriteLine("Total Cost: $" + (userPastryOrder.GetPriceOfPastryOrder() + userBreadOrder.GetPriceOfBreadOrder()));

      while(true)
      {
        Console.WriteLine("\n\nDo you want to shop again?");
        Console.WriteLine("1:Yes  2:No");
        int response = int.Parse(Console.ReadLine());

        switch(response)
        {
          case 1:
            Shop();
            break;
          case 2:
            End();
            break;
          default:
            Console.WriteLine("Error: that wasn't a 1 or 2. Try again");
            break;
        }
      }
    }

    public static void End()
    {
      Console.WriteLine("Have a great day. Goodbye!");
    }
  }
}