using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace OneCard
{
    public class FullCard : GeneralCard
    {
        public SubscriptionInfo subscriptionInfo { get; set; }
        public BusinessInfo businessInfo { get; set; }

        public FullCard(string name) : base(name)
        {
             
        }

        public static FullCard GenerateFullCardDemo(string name)
        {
            FullCard fullCard = new FullCard(name);
            fullCard.subscriptionInfo = SubscriptionInfo.GenerateSubscriptionDemo();
            fullCard.businessInfo = BusinessInfo.GenerateBusinessInfoDemo();
            fullCard.demoLogo = "ms-appx:///Assets/OneCard_logo.png";
            return fullCard;
        }

        //for debug purpose
        private static async void debug_msg(string msg)
        {
            MessageDialog dialog = new MessageDialog(msg);

            await dialog.ShowAsync();
            return;
        }
    }
}
