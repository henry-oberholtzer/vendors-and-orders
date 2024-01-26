using VendorTracker.Models;

namespace VendorTracker.Tests;

[TestClass]
public class VendorTests : IDisposable
{
  public void Dispose()
  {
    Vendor.ClearAll();
  }
  
  [TestMethod]
  public void Vendor_ShouldCreateAnInstanceOfVendor_Vendor()
  {
    Vendor one = new("one", "jkl");
    Assert.AreEqual(one.GetType(), typeof(Vendor));
  }
  [TestMethod]
  public void Vendor_GetName_String()
  {
    string expected = "two";
    Vendor two = new(expected, "ghi");
    Assert.AreEqual(two.Name, expected);
  }
  [TestMethod]
  public void Vendor_SetName_Void()
  {
    Vendor three = new("two", "def");
    string expected = "three";
    three.Name = expected;
    Assert.AreEqual(three.Name, expected);
  }
  [TestMethod]
  public void Vendor_GetDescription_String()
  {
    string expected = "abc";
    Vendor four = new("four", expected);
    Assert.AreEqual(four.Description, expected);
  }
  [TestMethod]
  public void Vendor_GetDescriptionDefault_String()
  {
    string expected = "No description available.";
    Vendor five = new("five");
    Assert.AreEqual(five.Description, expected);
  }
  [TestMethod]
  public void Vendor_GetAll_ListVendor()
  {
    Vendor six = new("six");
    Vendor seven = new("seven");
    List<Vendor> expected = new(){ six, seven };
    CollectionAssert.AreEqual(expected, Vendor.GetAll());
  }
}
