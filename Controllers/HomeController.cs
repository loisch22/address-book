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
    public ActionResult ContactAdd()
    {
      return View();
    }

    [HttpPost("/contact/new")]
    public ActionResult ContactNew()
    {
      string nameInput = Request.Form["contact-name"];
      string phoneNumberInput = Request.Form["phone-number"];
      string addressInput = Request.Form["address"];
      Contact newContact = new Contact(nameInput, phoneNumberInput, addressInput);
      return View(newContact);
    }

    [HttpGet("/contact/{id}")]
    public ActionResult ContactDetail(int id)
    {
      Contact contact = Contact.Find(id);
      return View(contact);

    }

    [HttpGet("/contact/delete")]
    public ActionResult ContactDelete()
    {
      Contact contactDelete = Contact.GetId();
      
    }

    [HttpGet("/contact/clear")]
    public ActionResult ContactsClear()
    {
      Contact.ClearAll();
      return View();
    }

  }
}
