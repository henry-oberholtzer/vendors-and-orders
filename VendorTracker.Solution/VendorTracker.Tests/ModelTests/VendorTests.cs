using VendorTracker.Models;

namespace VendorTracker.Tests;

[TestClass]
public class VendorTests
{
  [TestMethod]
  public void Vendor_ShouldCreateAnInstanceOfVendor_Vendor()
  {
    Vendor one = new();
    Assert.AreEqual(one.GetType(), typeof(Vendor));
  }
}
