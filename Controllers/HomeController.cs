using Microsoft.AspNetCore.Mvc;
using Contacts.Models;
using System.Collections.Generic;

namespace Contacts.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/add_contact")]
    public ActionResult Add_Contact()
    {
      return View();
    }
  }
}
