using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers;

public class VendorsController : Controller
{
  [HttpGet("/vendors")]
  public ActionResult Index()
  {
    List<Vendor> model = Vendor.GetAll();
    return View(model);
  }
  [HttpGet("/vendors/new")]
  public ActionResult New()
  {
  return View();
  }

  [HttpPost("/vendors")]
  public ActionResult Create(string name, string description)
  {

    Vendor newVendor = new(name, description);
    RouteValueDictionary route = new(){{"id", newVendor.Id}};
    return RedirectToAction("Show", route);  
  }

  [HttpGet("/vendors/{id}")]
  public ActionResult Show(string id)
  {
    Vendor target = Vendor.Find(id);
    return View(target);
  }

  [HttpPost("/vendors/{id}/delete")]
  public ActionResult Delete(string id)
  {
    Vendor.Delete(id);
    return RedirectToAction("Index");
  }

  [HttpGet("/vendors/{id}/orders/new")]
  {

  }
  [HttpPost("/vendors/{id}/orders")]
  public ActionResult CreateOrder(string id, string title, int price, string description)
  {
    Order newOrder = new(title, price, description);
    Vendor.AddOrder(newOrder);
    RouteValueDictionary route = new(){{"id", newVendor.Id}};
    return RedirectToAction("Show", route); 
  }
}
