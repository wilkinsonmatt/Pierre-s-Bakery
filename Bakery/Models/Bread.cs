using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public bool IsQuantityGreaterThanZero()
    {
      if(this.Quantity >= 0)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

    public int GetPriceOfBreadOrder()
    {
      int totalPrice = 0;
      
      return totalPrice;
    }

  }
}