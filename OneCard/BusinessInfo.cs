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
        public List<string> openingHours { get; set; }
        public List<string> offersAndSales { get; set; }

        public BusinessInfo()
        {

        }
    }
}
