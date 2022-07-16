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
      int price = 5;
      //Removes the cost of every 3 bread from the total
      int totalPrice = (this.Quantity*price)-(price*(this.Quantity/3));
      
      return totalPrice;
    }

  }
}