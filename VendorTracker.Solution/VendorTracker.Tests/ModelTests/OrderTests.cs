using VendorTracker.Models;

namespace VendorTracker.Tests;

[TestClass]
public class OrderTests : IDisposable
{
  public void Dispose()
  {
    Order.ClearAll();
  }
  [TestMethod]
  public void Order_CreateAnInstanceOfOrder_Order()
  {
    Order one = new("one", 10);
    Assert.AreEqual(one.GetType(), typeof(Order));
  }
  [TestMethod]
  public void Order_GetTitle_String()
  {
    string expected = "two";
    Order two = new(expected, 10);
    Assert.AreEqual(two.Title, expected);
  }
  [TestMethod]
  public void Order_SetTitle_Void()
  {
    Order three = new("two", 10);
    string expected = "three";
    three.Title = expected;
    Assert.AreEqual(three.Title, expected);
  }
  [TestMethod]
  public void Order_GetDescription_String()
  {
    string expected = "abc";
    Order four = new("four", 0, expected);
    Assert.AreEqual(four.Description, expected);
  }
  [TestMethod]
  public void Order_SetDescription_Void()
  {
    Order three = new("two", 0, "def");
    string expected = "boing";
    three.Description = expected;
    Assert.AreEqual(three.Description, expected);
  }
    [TestMethod]
  public void Order_GetDescriptionDefault_String()
  {
    string expected = "No description available.";
    Order five = new("five", 2);
    Assert.AreEqual(five.Description, expected);
  }
  [TestMethod]
  public void Order_GetPrice_Int()
  {
    int expected = 5;
    Order six = new("six", expected);
    Assert.AreEqual(six.Price, expected);
  }
  [TestMethod]
  public void Order_SetPrice_Void()
  {
    int expected = 5;
    Order seven = new("seven", 2);
    seven.Price = expected;
    Assert.AreEqual(seven.Price, expected);
  }

  [TestMethod]
  public void Order_GetId_Order()
  {
        _ = new Order("one", 1);
    Order two = new("two", 2);
    int expected = 2;
    Assert.AreEqual(two.Id, expected);
  }
  [TestMethod]
  public void Order_FindById_Order()
  {
          _ = new Order("one", 1);
      _ = new Order("two", 2);
      Order three = new("three", 3);
      Assert.AreEqual(Order.Find(3), three);
  }
  [TestMethod]
  public void Order_ClearAll_Void()
  {
    Order six = new("six", 6);
    Order seven = new("seven", 7);
    List<Order> expected = new(){};
    Order.ClearAll();
    CollectionAssert.AreEqual(expected, Order.GetAll());
  }
  [TestMethod]
  public void Order_Delete_Void()
  {

  }
  [TestMethod]
  public void Order_FindByName_Order()
  {

  }
}
