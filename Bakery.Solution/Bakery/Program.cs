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
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Our loaves of bread are $5 each."); 
      Console.WriteLine("Our pastries are $2 each.");
      Console.WriteLine("Pierre is offering the following specials today:");
      Console.WriteLine("Loaves: Buy 2, Get One Free."); 
      Console.WriteLine("Pastries: 3 for $5");
      Start();
    }
    
    public static void Start()
    {
      Console.WriteLine("How many loaves would you like?");
      Bread newBread = new Bread(int.Parse(Console.ReadLine()));

      if (newBread.IsOnlyPositiveNumberCharacters())
      {
        Console.WriteLine("Your bread order total is: $" + (newBread.TotalBreadPrice()));
      }
      else
      {
        Console.WriteLine("Please enter a positive number.");
        Start();
      }
    
      Console.WriteLine("How many pastries would you like?");
      PastryOrder newPastryOrder = new PastryOrder(int.Parse(Console.ReadLine()));

      if (newPastryOrder.IsOnlyPositiveNumberCharacters2())
      {
        Console.WriteLine("Your pastry order total is: $" + (newPastryOrder.GetPastryTotal()));
      }
      else
      {
        Console.WriteLine("Please enter a positive number.");
        Start();
      }
      Console.WriteLine("Order Complete! Thank you for shopping at Pierre's Bakery.");
      Console.WriteLine("Your Grand Total is: $" + (newBread.TotalBreadPrice() + newPastryOrder.GetPastryTotal()));
    }
  }
}
  

