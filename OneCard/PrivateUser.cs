using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class PrivateUser
    {
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string cellNumber { get; set; }
        public string password { get; set; }
        public string securityQ { get; set; }
        public string securityA { get; set; }
        public string country { get; set; }
        public string address { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool isUpdated { get; set; }
        public SortedSet<CardCategory> cardCategories { get; set; }
        //public SortedSet<NfcTags> nfcTags { get; set; }
        public string passcode { get; set; }
        public Uri photoPath { get; set; }

        public PrivateUser(string username, string password)
        {
            this.username = username;
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.emailAddress = string.Empty;
            this.cellNumber = string.Empty;
            this.password = password;
            this.securityQ = string.Empty;
            this.securityA = string.Empty;
            this.country = string.Empty;
            this.address = string.Empty;
            this.dateOfBirth = DateTime.Now;
            this.isUpdated = false;
            this.cardCategories = null;
            //this.nfcTags = null;
            this.passcode = string.Empty;
            this.photoPath = null;

        }
    }
}
