using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_ConstructAnInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod]
    public void IsOnlyPositiveNumberCharacters_ChecksIfInputIsOfNumberChars_False()
    {
      Bread newBread = new Bread(-1);
      Assert.AreEqual(false, newBread.IsOnlyPositiveNumberCharacters());
    }

    [TestMethod]
    public void TotalBreadPrice_ReturnsBreadTotalToUser_10()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(10, newBread.TotalBreadPrice());  
    }  
  }
}
