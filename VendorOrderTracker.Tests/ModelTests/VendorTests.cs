using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsName_String()
    {
      //Arrange
      string vendorName = "Suzie's Cafe";
      Vendor newVendor = new Vendor(vendorName);

      //Act
      string result = newVendor.VendorName;

      //Assert
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetName_SetsVendorName_String()
    {
      //Arrange
      string title = "Suzie's Cafe";
      Vendor newVendor = new Vendor(title);
      //Act
      string updatedVendorName = "Suzie's Pastries";
      newVendor.VendorName = updatedVendorName;
      string result = newVendor.VendorName;
      //Assert
      Assert.AreEqual(updatedVendorName, result);
    }
  }
}