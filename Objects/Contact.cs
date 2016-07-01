using System.Collections.Generic;

namespace Contact
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}
