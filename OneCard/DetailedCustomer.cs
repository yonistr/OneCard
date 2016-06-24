using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    // A class of more detailed customer to use after picking a customer from the customers list
    // in the AllCustomersPage or while identifying a private user (all above require Business Login). 
    public class DetailedCustomer : Customer
    {
        public DateTime dateOfBirth { get; set; }
        public SubscriptionInfo subscriptionInfo { get; set; }
        public Uri profilePicture { get; set; }
        public ContactInfo contactInfo { get; set; }

        public DetailedCustomer(string user, string first, string last) : base(user, first, last)
        {

        }
    }
}
