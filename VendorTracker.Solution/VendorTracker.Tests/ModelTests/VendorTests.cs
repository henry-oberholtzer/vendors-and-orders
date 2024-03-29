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
    public void Vendor_SetDescription_Void()
  {
    Vendor three = new("two", "def");
    string expected = "boing";
    three.Description = expected;
    Assert.AreEqual(three.Description, expected);
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
  [TestMethod]
    public void Vendor_ClearAll_Void()
  {
    Vendor six = new("six");
    Vendor seven = new("seven");
    List<Vendor> expected = new(){};
    Vendor.ClearAll();
    CollectionAssert.AreEqual(expected, Vendor.GetAll());
  }
  [TestMethod]
  public void Vendor_GetId_Int()
  {
    _ = new Vendor("one");
    Vendor two = new("two");
    int expected = 2;
    Assert.AreEqual(expected, two.Id);
  }
  [TestMethod]
  public void Vendor_FindById_Vendor()
  {
      _ = new Vendor("one");
      _ = new Vendor("two");
      Vendor three = new("three");
      Assert.AreEqual(Vendor.Find(3), three);

  }
  [TestMethod]
  public void Vendor_Delete_Void()
  {
      Vendor one = new("one");
      Vendor two = new("two");
      Vendor three = new("three");
      int idToDelete = 1;
      List<Vendor> expected = new(){ two, three };
      Vendor.Delete(idToDelete);
      CollectionAssert.AreEqual(Vendor.GetAll(), expected);
  }
  [TestMethod]
  public void Vendor_DeleteAndFind_Vendor()
  {
        _ = new Vendor("one");
        _ = new Vendor("two");
        Vendor three = new("three");
      int id = 1;
      Vendor.Delete(id);
      Assert.AreEqual(Vendor.Find(3), three);
  }
  [TestMethod]
  public void Vendor_DeleteAddGetAll_VendorList()
  {
      Vendor one = new("one");
      Vendor two = new("two");
      Vendor three = new("three");
      Vendor.Delete(2);
      Vendor four = new("four");
      Vendor.Delete(4);
      List<Vendor> expected = new(){one, three };
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
  }
  [TestMethod]
  public void Vendor_FindByName_IEnumerable()
  {
    string query = "look for me";
    Vendor result = new(query);
    Vendor two = new("two", "i am not the one");
    IEnumerable<Vendor> results = Vendor.FindByName(query);
    Assert.AreEqual(results.First(), result);
  }
  [TestMethod]
    public void Vendor_FindByDescription_IEnumerable()
  {
    string query = "look for me";
    Vendor result = new("one", query);
    Vendor two = new("two", "i am not the one");
    IEnumerable<Vendor> results = Vendor.FindByDescription(query);
    Assert.AreEqual(results.First(), result);
  }

  [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
  {
    Order five = new("five", 10);
    List<Order> expected = new(){ five };
    Vendor six = new("six");
    six.AddOrder(five);
    List<Order> result = six.Orders;
    CollectionAssert.AreEqual(expected, result);
  }

}
