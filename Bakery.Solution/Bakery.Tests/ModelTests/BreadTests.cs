using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

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
    public void GetPrice_ReturnsPrice_Int()
    {
      int testPrice = 5;
      Bread newBread = new Bread(2);
      int result = newBread.Price;
      Assert.AreEqual(testPrice, result);
    }
    [TestMethod]
    public void GetNumberOfLoaves_ReturnNumberOfLoaves_Int()
    {
      int testLoaves = 2;
      Bread newBread = new Bread(testLoaves);
      int result = newBread.NumberOfLoaves;
      Assert.AreEqual(testLoaves, result);
    }
    [TestMethod]
    public void TotalBreadPrice_ReturnsPriceBasedOnNumberOfLoaves_Int()
    {
      int testLoaves = 2;
      int testPrice = 10;
      Bread newBread = new Bread(testLoaves);
      newBread.TotalBreadPrice();
      int result = newBread.Price;
      Assert.AreEqual(testPrice, result);
    }
  }
}