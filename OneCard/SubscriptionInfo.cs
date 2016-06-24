using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class SubscriptionInfo
    {
        public string description { get; set; }
        public string type { get; set; }
        public DateTime expiryDate { get; set; }
        public DateTime lastUse { get; set; }
        public int numOfTagsAllowed { get; set; }
        public int numOfTagsInUse { get; set; }

        public SubscriptionInfo()
        {

        }
    }
}
