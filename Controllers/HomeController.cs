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

    [HttpPost("/recent_added_contact")]
    public ActionResult Recently_Added()
    {
      string nameInput = Request.Form["contact-name"];
      string phoneNumberInput = Request.Form["phone-number"];
      string addressInput = Request.Form["address"];
      Contact newContact = new Contact(nameInput, phoneNumberInput, addressInput);
      return View(newContact);
    }
  }
}
