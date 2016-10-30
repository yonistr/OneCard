using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class NfcTag
    {
        public string tagId { get; set; }
        public string businessName { get; set; }
        public string tagOwner { get; set; }
        public DateTime tagExpiryDate { get; set; }
        public int usageLeft { get; set; }

        public NfcTag(string id, string business, string owner, DateTime expiryDate, int usages)
        {
            this.tagId = id;
            this.businessName = business;
            this.tagOwner = owner;
            this.tagExpiryDate = expiryDate;
            this.usageLeft = usages;
        }



        // generate an example of cards list for a user
        public static ObservableCollection<NfcTag> GenerateTagsDemo()
        {
            ObservableCollection<NfcTag> tags = new ObservableCollection<NfcTag>();

            tags.Add(new NfcTag("A2E5", "Go Active", "Hadar", new DateTime(2017, 5, 20), 5));
            tags.Add(new NfcTag("4SD3", "Shufersal", "Shir", new DateTime(2016, 12, 10), 1));
            tags.Add(new NfcTag("GN49", "Lalin", "Hillel", new DateTime(2016, 10, 1), 10));
            tags.Add(new NfcTag("DHY8", "Shufersal", "Yoni", new DateTime(2017, 1, 27), 3));
            tags.Add(new NfcTag("WE23", "Golf & Co", "Mike", new DateTime(2017, 3, 12), 2));
    
            return tags;
        }
    }

}
