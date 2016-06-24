using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class Business
    {
        //list of all customers names
        //public SortedSet<string> allCustomers { get; set; }
        //login name
        public string username { get; set; }
        //login password
        public string password { get; set; }
        public string securityQ { get; set; }
        public string securityA { get; set; }
        public string businessName { get; set; }
        //public string email { get; set; }
        //public string cellphoneNumber { get; set; }
        //public string phoneNumber { get; set; }
        //public string primaryaddress { get; set; }
        //public string country { get; set; }
        public ContactInfo contactInfo { get; set; } 
        public string description { get; set; }
        public Uri logoPath { get; set; }

        public string currentCustomerFirstName { get; set; }
        public string currentCustomerLastName { get; set; }
        public string currentCustomerEmail { get; set; }
        public string currentCustomerPhoneNo { get; set; }
        public string currentCustomerAddress { get; set; }
        public string currentCustomerCountry { get; set; }
        public DateTime currentCustomerBirthDate { get; set; }
        public DateTime currentCustomerAccountExpiry { get; set; }
        public int currentCustomerAmountOfTags { get; set; }
    }
}
