using System;

namespace Bakery.Models
{
  public class PastryOrder
  {
    public int Price { get; set; }
    
    public int NumberOfPastries { get; set; }
    
    public PastryOrder(int numberOfPastries)
    {
      Price = 3;
      NumberOfPastries = numberOfPastries;
    }
    
    public bool IsOnlyPositiveNumberCharacters2()
    {
      if (NumberOfPastries > 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    
    public int GetPastryTotal()
    {
      int newPastryTotal = Price * NumberOfPastries;
      if (NumberOfPastries > 2)
      {
        newPastryTotal -= ((NumberOfPastries/3) * 1);
      }
      return newPastryTotal;
    }
  }
}
  