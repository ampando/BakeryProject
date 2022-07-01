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
      Console.WriteLine("Our loaves of bread are $5 or choose 3 for #10 and our pastries are $2 each or 3 for $5");
      Start();
    }
    public static void Start()
    {
      Console.WriteLine("How many loaves would you like?");
      Bread newBread = new Bread(int.Parse(Console.ReadLine()));
    }
      }
    }
  

