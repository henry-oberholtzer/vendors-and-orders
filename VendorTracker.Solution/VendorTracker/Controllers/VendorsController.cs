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
    RouteValueDictionary route = new() { { "id", newVendor.Id } };
    return RedirectToAction("Show", route);
  }

  [HttpGet("/vendors/{id}")]
  public ActionResult Show(int id)
  {
    Vendor target = Vendor.Find(id);
    return View(target);
  }

  [HttpPost("/vendors/{id}/delete")]
  public ActionResult Delete(int id)
  {
    Vendor.Delete(id);
    return RedirectToAction("Index");
  }

  [HttpPost("/vendors/{vendorId}/orders")]
  public ActionResult Create(int vendorId, string title, string price, string description)
  {
    Order newOrder = new(title, int.Parse(price), description);
    Vendor target = Vendor.Find(vendorId);
    target.AddOrder(newOrder);
    return View("Show", target);
  }
}
