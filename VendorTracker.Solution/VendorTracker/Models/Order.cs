namespace VendorTracker.Models;

public class Order {
  public string Title { get; set; }
  public string Description { get; set; }
  public int Price { get; set; }

  public string Id { get; }
  private static List<Order> _instances = new (){};
  public Order(string title, int price, string description = "No description available.")
  {
    Title = title;
    Description = description;
    Price = price;
    _instances.Add(this);
    Id = Guid.NewGuid().ToString();
  }
  public static List<Order> GetAll()
  {
    return _instances;
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }

  public static Order Find(string id)
  {
    return _instances.Single(order => order.Id == id);
  }

  public static IEnumerable<Order> FindByTitle(string query)
  {
    IEnumerable<Order> results = _instances.Where(instance => instance.Title == query);
    return results;
  }

    public static void Delete(string id)
  {
    Order orderToRemove = _instances.Single(order => order.Id == id);
    _instances.Remove(orderToRemove);
  }
}
