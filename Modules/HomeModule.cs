using Nancy;
using System.Collections.Generic;
using Contact;

namespace Contact
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
      Post["/contacts/created"] = _ => {
        Contact newContact = new Contact (Request.Form["new-contact"], Request.Form["new-phone"], Request.Form["new-address"]);
        newContact.Save();
        return View["created.cshtml", newContact];
      };
      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
