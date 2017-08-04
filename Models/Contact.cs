using System.Collections.Generic;

namespace Contacts.Models
{
  public class Contact
  {
    private string _contactName;
    private int _phoneNumber;
    private string _address;
    private static List<Contact> contactList = new List<Contact> ();

    public Contact(string contactName, int phoneNumber, string address)
    {
      _contactName = contactName;
      _phoneNumber = phoneNumber;
      _address = address;
      contactList.Add(this);
    }

    public string GetContactName()
    {
      return _contactName;
    }
    public void SetContactName(string contactName)
    {
      _contactName = contactName;
    }
    public int GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(int phoneNumber)
    {
      _phoneNumber = phoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string address)
    {
      _address = address;
    }
    public static List<Contact> GetAllContacts()
    {
      return contactList;
    }
  }
}
