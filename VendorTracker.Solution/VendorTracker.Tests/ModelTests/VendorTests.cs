using VendorTracker.Models;

namespace VendorTracker.Tests;

[TestClass]
public class VendorTests
{
  [TestMethod]
  public void Vendor_ShouldCreateAnInstanceOfVendor_Vendor()
  {
    Vendor one = new("one");
    Assert.AreEqual(one.GetType(), typeof(Vendor));
  }
  [TestMethod]
  public void Vendor_GetName_String()
  {
    string expected = "two";
    Vendor two = new(expected);
    Assert.AreEqual(two.Name, expected);
  }
}
