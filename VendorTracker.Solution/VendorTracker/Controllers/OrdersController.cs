using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers;

public class OrdersController : Controller
{

  [HttpGet("/vendors/{id}/orders/new")]
  public ActionResult New(string id)
  {
    Dictionary<string, string> Model = new()
    {
        { "Id", id }
    };
    return View(Model);
  }
}


