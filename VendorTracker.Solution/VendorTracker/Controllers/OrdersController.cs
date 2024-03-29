using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers;

public class OrdersController : Controller
{

  [HttpGet("/vendors/{id}/orders/new")]
  public ActionResult New(int id)
  {
    Vendor target = Vendor.Find(id);
    return View(target);
  }

  [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
  public ActionResult Show(int vendorId, int orderId)
  {
    Order order = Order.Find(orderId);
    Vendor vendor = Vendor.Find(vendorId);
    Dictionary<string, object> model = new()
    {
      {"order", order},
      {"vendor", vendor},
    };
    return View(model);
  }

  [HttpPost("/vendors/{vendorId}/orders/{orderId}/delete")]
  public ActionResult Delete(int vendorId, int orderId)
  {
    Vendor.Find(vendorId).DeleteOrder(orderId);
    return RedirectPermanent("/vendors");
  }


};


