namespace VendorTracker.Models;

public class Order {
  public string Title { get; set; }
  public string Description { get; set; }
  public int Price { get; set; }
  public Order(string title, int price, string description = "No description available.")
  {
    Title = title;
    Description = description;
    Price = price;
  }
}
