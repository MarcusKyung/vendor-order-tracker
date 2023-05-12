using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
    }
  }
}
