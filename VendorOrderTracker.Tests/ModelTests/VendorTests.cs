using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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
      string vendorName = "Suzie's Cafe";
      Vendor newVendor = new Vendor(vendorName);
      //Act
      string updatedVendorName = "Suzie's Pastries";
      newVendor.VendorName = updatedVendorName;
      string result = newVendor.VendorName;
      //Assert
      Assert.AreEqual(updatedVendorName, result);
    }

    [TestMethod]
    public void GetVendorId_ReturnsVendorId_Int()
    {
      //Arrange
      string vendorName = "Test Category";
      Vendor newVendor = new Vendor(vendorName);
      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string vendorName01 = "12 croissants";
      string vendorName02 = "4 cookies";
      Vendor newVendor1 = new Vendor(vendorName01);
      Vendor newVendor2 = new Vendor(vendorName02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}