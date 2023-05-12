using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Price { get; }
    public Order(string title, int price)
    {
      Title = title;
      Price = price;
    }
  }
}