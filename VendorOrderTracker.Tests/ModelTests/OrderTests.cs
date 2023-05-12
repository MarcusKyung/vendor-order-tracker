using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("10 croissants");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string title = "10 croissants";
      //Act
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetsOrderTitle_String()
    {
      //Arrange
      string title = "10 croissants";
      Order newOrder = new Order(title);
      //Act
      string updatedTitle = "10 Pastries";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(updatedTitle, result);
    }
  }
}