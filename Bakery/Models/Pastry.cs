using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public Pastry(int quantity)
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

    public int GetPriceOfPastryOrder()
    {
      int price = 2;
      int totalPrice = 0;

      if(IsQuantityGreaterThanZero())
      {
        //Removes a dollar from the total for every 3 parties bought
        totalPrice = (this.Quantity*price)-(this.Quantity/3);
      }
      
      return totalPrice;
    }

  }
}