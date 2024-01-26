namespace VendorTracker.Models;

public class Vendor
{
  public string Name { get; set; }
  public string Description { get; set; }
  public List<Order> Orders { get; set; }
  public string Id { get; }
  private static List<Vendor> _instances = new(){};
  public Vendor (string name, string description = "No description available.")
  {
    Name = name;
    Description = description;
    _instances.Add(this);
    Orders = new List<Order>{};
    Id = Guid.NewGuid().ToString();
  }
  public void AddOrder(Order order)
  {
    Orders.Add(order);
  }

  public static List<Vendor> GetAll()
  {
    return _instances;
  }
  public static void ClearAll()
  {
    _instances.Clear();
  }
  public static Vendor Find(string id)
  {
    return _instances.Single(vendor => vendor.Id == id);
  }
  public static IEnumerable<Vendor> FindByName(string query)
  {
    IEnumerable<Vendor> results = _instances.Where(instance => instance.Name == query);
    return results;
  }
    public static IEnumerable<Vendor> FindByDescription(string query)
  {
    IEnumerable<Vendor> results = _instances.Where(instance => instance.Description == query);
    return results;
  }

  public static void Delete(string id)
  {
    Vendor vendorToRemove = _instances.Single(vendor => vendor.Id == id);
    _instances.Remove(vendorToRemove);
  }
}
