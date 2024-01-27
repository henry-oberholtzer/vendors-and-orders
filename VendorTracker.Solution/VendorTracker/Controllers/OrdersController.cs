using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers;

public class OrdersController : Controller
{
  [HttpGet("/vendors/{vendorId}/orders")]
    public ActionResult Index(string vendorId)
  {
    Vendor target = Vendor.Find(vendorId);
    return View(target);
  }

  [HttpGet("/vendors/{id}/orders/new")]
  public ActionResult New(string id)
  {
    Vendor target = Vendor.Find(id);
    return View(target);
  }
  [HttpPost("/vendors/{vendorId}/orders")]
  public ActionResult Create(string vendorId, string title, string price, string description)
  {
    string titleClean = title.Trim();
    if(int.TryParse(price, out int priceNum) && titleClean.Length > 0)
    {
          Order newOrder = new(titleClean, priceNum, description);
          Vendor.Find(vendorId).AddOrder(newOrder);
          RouteValueDictionary route = new(){
            {"id", vendorId},
            { "orderId", newOrder.Id}
            };
          return RedirectToAction("Show", route);
    }
    else
    {
      RouteValueDictionary route = new(){
        {"id", vendorId},
      };
      return RedirectToAction("New", route);
    }
  }

  [HttpGet("/vendors/{id}/orders/{orderId}")]
  public ActionResult Show(string id, string orderId)
  {
    Order targetOrder = Order.Find(orderId);
    return View(targetOrder);
  }

};


