using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class Customer
    {
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string demoLogo { get; set; }//need to delete

        public Customer(string user, string first, string last)
        {
            userName = user;
            firstName = first;
            lastName = last;
        }

        public static ObservableCollection<CustomerInitials> GenerateCustomersSample()
        {
            ObservableCollection<CustomerInitials> initials = new ObservableCollection<CustomerInitials>();

            CustomerInitials Astart = new CustomerInitials();
            Astart.initial = "A";
            Astart.Add(new Customer("adj", "joni", "Ames"));
            Astart.Add(new Customer("fd", "shir", "Anader"));

            CustomerInitials Bstart = new CustomerInitials();
            Bstart.initial = "B";
            Bstart.Add(new Customer("bd", "miri", "Baker"));
            Bstart.Add(new Customer("baki", "anat", "Bond"));
            Bstart.Add(new Customer("bila", "yosi", "Bilaboom"));

            CustomerInitials Cstart = new CustomerInitials();
            Cstart.initial = "C";
            Cstart.Add(new Customer("rc7", "alon", "Caner"));
            Cstart.Add(new Customer("ee3", "michal", "Coma"));
            Cstart.Add(new Customer("sdf", "david", "Cvalski"));

            CustomerInitials Dstart = new CustomerInitials();
            Dstart.initial = "D";
            Dstart.Add(new Customer("didi", "ron", "Darshovitz"));

            initials.Add(Astart);
            initials.Add(Bstart);
            initials.Add(Cstart);
            initials.Add(Dstart);

            return initials;
        }
    }
}
