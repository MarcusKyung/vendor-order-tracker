using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    // [HttpGet("/orders")]
    // public ActionResult Index()
    // {
    //   List<Order> allOrders = Order.GetAll();
    //   return View(allOrders);
    // }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorID)
    {
      Vendor vendor = Vendor.Find(vendorID);
      return View(vendor);
    }



    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}
