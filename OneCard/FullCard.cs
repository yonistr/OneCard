using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class FullCard : GeneralCard
    {
        public SubscriptionInfo subscriptionInfo { get; set; }
        public BusinessInfo businessInfo { get; set; }

        public FullCard(string name) : base(name)
        {
             
        }
    }
}
