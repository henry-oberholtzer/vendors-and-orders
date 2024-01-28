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
    RouteValueDictionary route = new() { { "vendorId", newVendor.Id } };
    return RedirectToAction("Show", route);
  }

  [HttpGet("/vendors/{vendorId}")]
  public ActionResult Show(int vendorId)
  {
    Vendor target = Vendor.Find(vendorId);
    return View(target);
  }

  [HttpPost("/vendors/{vendorId}/delete")]
  public ActionResult Delete(int vendorId)
  {
    Vendor.Delete(vendorId);
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
