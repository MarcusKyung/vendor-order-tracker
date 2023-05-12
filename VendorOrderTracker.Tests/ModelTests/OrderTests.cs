using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
    
    [TestMethod]
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

    [TestMethod]
    public void SetOrderDate_SetsOrderDate_String()
    {
      //Arrange
      string date = "2023-05-12";
      Order newOrder = new Order("10 pasteries", 12, date);
      //Act
      string updatedDate = "2023-06-21";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      //Assert
      Assert.AreEqual(updatedDate, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };
      // Act
      List<Order> result = Order.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_OrderList()
    {
      //Arrange
      string title01 = "12 croissants";
      string title02 = "4 cookies";
      Order newOrder1 = new Order(title01, 60, "2023-06-24");
      Order newOrder2 = new Order(title02, 8, "2023-05-12");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}