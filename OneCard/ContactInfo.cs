using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class ContactInfo
    {
        public string address { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string contactNumber { get; set; }

        public ContactInfo(string Address, string Country, string Email, string Number)
        {
            address = Address;
            country = Country;
            email = Email;
            contactNumber = Number;
        }

        public static ContactInfo GenerateContactDemo()
        {
            ContactInfo contact = new ContactInfo("Ha'atzmaoot 5, Tel-Aviv", "Israel", "somebody@gmail.com", "054-4445550");
            return contact;
        }
    }
}
