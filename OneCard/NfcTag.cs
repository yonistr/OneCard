using System;
using System.Collections.Generic;
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
    }
}
