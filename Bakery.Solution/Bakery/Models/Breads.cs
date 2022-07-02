using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }
    public int Price { get; set; }
    
    public Bread(int numberOfLoaves)
    {
      Price = 5;
      NumberOfLoaves = numberOfLoaves;
    }
    
    public bool IsOnlyPositiveNumberCharacters()
    {
      if (NumberOfLoaves < 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    
    public int TotalBreadPrice()
    {
      int newTotal = Price * NumberOfLoaves;
      if (NumberOfLoaves > 2)
      {
        newTotal -= ((NumberOfLoaves/3)*10);
      }
      return newTotal;
    }
  }
}
