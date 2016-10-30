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

        internal static DetailedCustomer GenerateDetailedCustomerDemo(Customer customer)
        {
            DetailedCustomer detailedCustomer = new DetailedCustomer(customer.userName, customer.firstName, customer.lastName);
            detailedCustomer.subscriptionInfo = SubscriptionInfo.GenerateSubscriptionDemo();
            detailedCustomer.contactInfo = ContactInfo.GenerateContactDemo();
            detailedCustomer.demoLogo = "ms-appx:///Assets/profile image.png";
            detailedCustomer.dateOfBirth = new DateTime(1989, 2, 3);
            return detailedCustomer;
        }
    }
}
