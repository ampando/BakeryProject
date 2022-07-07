using System;
using System.Collections.Generic;
using Bakery.Models;

namespace BakeryShop
{ 
  public class Program
  {
    public static void Main()
    {
          ConsoleColor blue = ConsoleColor.Blue;  
          ConsoleColor cyan = ConsoleColor.Cyan;
          
      Console.ForegroundColor = blue;
      Console.WriteLine("            ~---------- WELCOME TO PIERRE'S BAKERY ----------~");
      Console.ResetColor();
      Console.WriteLine("");
      Console.ForegroundColor = cyan;
      Console.WriteLine("Our loaves of bread are $5 each."); 
      Console.WriteLine("Our pastries are $2 each.");
      Console.ResetColor();
      Console.WriteLine("");
      Console.ForegroundColor = blue;
      Console.WriteLine("Pierre is offering the following specials today:");
      Console.WriteLine("");
      Console.ResetColor();
      Console.ForegroundColor = cyan;
      Console.WriteLine("Loaves: Buy 2, Get 1 Free."); 
      Console.WriteLine("Pastries: 3 for $5, 4 for $7, 5 for $9 & 6 for $10");
      Console.ResetColor();
      Console.WriteLine("");
      Start();
    }
    
    public static void Start()
    { 
      ConsoleColor green = ConsoleColor.Green;
      ConsoleColor magenta = ConsoleColor.Magenta;    
      ConsoleColor blue = ConsoleColor.Blue;  

      Console.ForegroundColor = green;
      Console.WriteLine("How many loaves would you like?");
      Bread newBread = new Bread(int.Parse(Console.ReadLine()));

      if (newBread.IsOnlyPositiveNumberCharacters())
      {
        Console.WriteLine("Your bread order total is: $" + (newBread.TotalBreadPrice()));
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine("Please enter a positive number.");
        Start();
      }
      Console.ForegroundColor = magenta;
      Console.WriteLine("");
      Console.WriteLine("How many pastries would you like?");
      PastryOrder newPastryOrder = new PastryOrder(int.Parse(Console.ReadLine()));

      if (newPastryOrder.IsOnlyPositiveNumberCharacters2())
      {
        Console.WriteLine("Your pastry order total is: $" + (newPastryOrder.GetPastryTotal()));
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine("Please enter a positive number.");
        Start();
      }
      Console.ForegroundColor = blue;
      Console.WriteLine("Order Complete! Thank you for shopping at Pierre's Bakery.");
      Console.WriteLine("");
      Console.WriteLine("Your Grand Total is: $" + (newBread.TotalBreadPrice() + newPastryOrder.GetPastryTotal()));
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("");
      Console.ResetColor();
      Console.ForegroundColor = green;
      Console.WriteLine("If you'd like to shop again, enter dotnet run on the command line.");
      Console.WriteLine("");
    }
  }
}
  

