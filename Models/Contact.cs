using System.Collections.Generic;

namespace Contacts.Models
{
  public class Contact
  {
    private string _contactName;
    private string _phoneNumber;
    private string _address;
    private static List<Contact> _contactList = new List<Contact> ();

    public Contact(string contactName, string phoneNumber, string address)
    {
      _contactName = contactName;
      _phoneNumber = phoneNumber;
      _address = address;
      _contactList.Add(this);
    }

    public string GetContactName()
    {
      return _contactName;
    }
    public void SetContactName(string contactName)
    {
      _contactName = contactName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string phoneNumber)
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
      return _contactList;
    }
    public static void ClearAll()
    {
      _contactList.Clear();
    }
  }
}
