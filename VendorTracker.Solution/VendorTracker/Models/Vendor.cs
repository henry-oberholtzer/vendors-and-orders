namespace VendorTracker.Models;

public class Vendor
{
  public string Name { get; set; }
  public string Description { get; set; }

  public int Id { get; }
  private static List<Vendor> _instances = new(){};
  public Vendor (string name, string description = "No description available.")
  {
    Name = name;
    Description = description;
    _instances.Add(this);
    Id = _instances.Count;
  }

  public static List<Vendor> GetAll()
  {
    return _instances;
  }
  public static void ClearAll()
  {
    _instances.Clear();
  }
}
