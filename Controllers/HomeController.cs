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
      List<Contact> addedContacts = Contact.GetAllContacts();
      return View(addedContacts);
    }

    [HttpGet("/contact/add")]
    public ActionResult Add_Contact()
    {
      return View();
    }

    [HttpPost("/contact/new")]
    public ActionResult Recently_Added()
    {
      string nameInput = Request.Form["contact-name"];
      string phoneNumberInput = Request.Form["phone-number"];
      string addressInput = Request.Form["address"];
      Contact newContact = new Contact(nameInput, phoneNumberInput, addressInput);
      return View(newContact);
    }

    [HttpGet("/contact/clear")]
    public ActionResult Contacts_Clear()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
