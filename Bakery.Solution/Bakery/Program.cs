using System;
using System.Collections.Generic;
//using System.Linq;
using Bakery.Models;

namespace BakeryShop
{ 
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Our loaves of bread are $5 or choose 3 for $10. Our pastries are $2 each or 3 for $5");
      Start();
    }
    
    public static void Start()
    {
      Console.WriteLine("How many loaves would you like?");
      Bread newBread = new Bread(int.Parse(Console.ReadLine()));

      if (newBread.IsOnlyPositiveNumberCharacters())
      {
        Console.WriteLine("Here is your bread order total: $" + (newBread.TotalBreadPrice()));
      }
      else
      {
        Console.WriteLine("Please enter a positive number");
        Start();
      }
    
      Console.WriteLine("How many pastries would you like?");
      PastryOrder newPastryOrder = new PastryOrder(int.Parse(Console.ReadLine()));

      if (newPastryOrder.IsOnlyPositiveNumberCharacters2())
      {
        Console.WriteLine("Here is your pastry order total: $" + (newPastryOrder.GetPastryTotal()));
      }
      else
      {
        Console.WriteLine("Please enter a positive number");
        Start();
      }
    
      Console.WriteLine("Here is your grand total: $" + (newBread.GetTotalBreadPrice() + newPastryOrder.GetPastryTotal()));
    }
  }
}
  

