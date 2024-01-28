namespace VendorTracker.Models;

public class Vendor
{
  public string Name { get; set; }
  public string Description { get; set; }
  public List<Order> Orders { get; set; }
  public int Id { get; }
  private static List<Vendor> _instances = new(){};
  public Vendor (string name, string description = "No description available.")
  {
    Name = name;
    Description = description;
    Orders = new List<Order>{};
    Id = _instances.Count == 0 ? 1 : _instances.Last().Id + 1;
    _instances.Add(this); 
  }
  public void AddOrder(Order order)
  {
    order.VendorId = Id;
    Orders.Add(order);
  }

  public Order FindOrder(int id)
  {
    return Orders.Single(order => order.Id == id);
  }

  public static List<Vendor> GetAll()
  {
    return _instances;
  }
  public static void ClearAll()
  {
    _instances.Clear();
  }
  public static Vendor Find(int id)
  {
    return _instances.Find(vendor => vendor.Id == id);
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

  public static void Delete(int id)
  {
    Vendor vendorToRemove = _instances.Find(vendor => vendor.Id == id);
    _instances.Remove(vendorToRemove);
  }
}
