namespace VendorTracker.Models;

public class Order {
  public string Title { get; set; }
  public string Description { get; set; }
  public int Price { get; set; }

  public int Id { get; }
  private static List<Order> _instances = new (){};
  public Order(string title, int price, string description = "No description available.")
  {
    Title = title;
    Description = description;
    Price = price;
    _instances.Add(this);
    Id = _instances.Count;
  }
  public static List<Order> GetAll()
  {
    return _instances;
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }

  public static Order Find(int id)
  {
    return _instances[id - 1];
  }
}
