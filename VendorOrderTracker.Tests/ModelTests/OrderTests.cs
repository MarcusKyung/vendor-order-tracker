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
      Order newOrder = new Order("10 croissants", 12, "2023-05-12");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string title = "10 croissants";
      //Act
      Order newOrder = new Order(title, 12, "2023-05-12");
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetsOrderTitle_String()
    {
      //Arrange
      string title = "10 croissants";
      Order newOrder = new Order(title, 12, "2023-05-12");
      //Act
      string updatedTitle = "10 Pastries";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      //Arrange
      int price = 12;
      //Act
      Order newOrder = new Order("10 croissants", price, "2023-05-12");
      int result = newOrder.Price;
      //Assert
      Assert.AreEqual(price, result);
    }

    public void SetOrderPrice_SetsOrderPrice_Int()
    {
      //Arrange
      int price = 12;
      Order newOrder = new Order("10 pasteries", price, "2023-05-12");
      //Act
      int updatedPrice = 24;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      //Assert
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      //Arrange
      string date = "2023-05-12";
      //Act
      Order newOrder = new Order("10 croissants", 12, date);
      string result = newOrder.Date;
      //Assert
      Assert.AreEqual(date, result);
    }
  }
}