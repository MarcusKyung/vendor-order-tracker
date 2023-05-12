using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Price { get; set; }

    public string Date { get; set; }
    public Order(string title, int price, string date)
    {
      Title = title;
      Price = price;
      Date = date;
    }
  }
}