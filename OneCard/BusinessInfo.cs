using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class BusinessInfo
    {
        public ContactInfo contactInfo { get; set; }
        public string openingHours { get; set; }
        public string offersAndSales { get; set; }

        public BusinessInfo(ContactInfo contact)
        {
            contactInfo = contact;
            openingHours = string.Empty;
            offersAndSales = string.Empty;
        }

        public static BusinessInfo GenerateBusinessInfoDemo()
        {
            BusinessInfo business = new BusinessInfo(ContactInfo.GenerateContactDemo());
            business.offersAndSales = "Today in this department a 50% sale.\r\nWin a havennly weekend by participatig\r\nNo refund!!!";
            business.openingHours = "Sun-Tus: 09:00-20:00\r\nWen-The: 09:00-23:00\r\nFri-Sat: 12:00-Last customer!";
            return business;
        }
    }
}
