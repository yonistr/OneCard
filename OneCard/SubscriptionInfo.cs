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

        private string _tagsInUseOfAllowed;
        public string TagsInUseOfAllowed
        {
            get
            {
                _tagsInUseOfAllowed = numOfTagsInUse + "/" + numOfTagsAllowed;
                return _tagsInUseOfAllowed;
            }
        }

        public SubscriptionInfo()
        {
            description = string.Empty;
            type = string.Empty;
            _tagsInUseOfAllowed = string.Empty;

            numOfTagsAllowed = 0;
            numOfTagsInUse = 0;
        }

        public static SubscriptionInfo GenerateSubscriptionDemo()
        {
            SubscriptionInfo subscription = new SubscriptionInfo();
            subscription.description = "10% discount and many points";
            subscription.type = "one year adult subscription";
            subscription.expiryDate = new DateTime(2017, 5, 1);
            subscription.lastUse = new DateTime(2016, 7, 5);
            subscription.numOfTagsAllowed = 5;
            subscription.numOfTagsInUse = 3;
            return subscription;
        }
    }
}
