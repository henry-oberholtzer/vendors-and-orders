namespace VendorTracker.Models;

public class Order {
  public string Title { get; set; }
  public string Description { get; set; }
  public int Price { get; set; }

  public int? VendorId { get; set; }
  public int Id { get; }
  private static List<Order> _instances = new (){};
  public Order(string title, int price, string description = "No description available.")
  {
    Title = title;
    Description = description;
    Price = price;
    VendorId = null;
    Id = _instances.Count == 0 ? 1 : _instances[^1].Id + 1;
    _instances.Add(this);
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
    return _instances.Find(order => order.Id == id);
  }

  public static IEnumerable<Order> FindByTitle(string query)
  {
    IEnumerable<Order> results = _instances.Where(instance => instance.Title == query);
    return results;
  }

    public static void Delete(int id)
  {
    Order orderToRemove = _instances.Find(order => order.Id == id);
    _instances.Remove(orderToRemove);
  }
}
