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
  [TestMethod]
  public void Vendor_SetName_Void()
  {
    Vendor three = new("two");
    string expected = "three";
    three.Name = expected;
    Assert.AreEqual(three.Name, expected);
  }
}
