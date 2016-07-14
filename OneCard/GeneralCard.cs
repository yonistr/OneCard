using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class GeneralCard
    {
        public string name { get; set; }
        public bool isLocationAvailable { get; set; }
        public bool autoWriteLocation { get; set; }
        public string securityType { get; set; }
        public Uri logoPath { get; set; }
        public string demoLogo { get; set; }//need to delete
        public bool isFavourite { get; set; }
        //public string subscriptionInfo { get; set; }
        //public string description { get; set; }

        public GeneralCard(string name)
        {
            this.name = name;
            this.isLocationAvailable = false;
            this.autoWriteLocation = false;
            this.securityType = string.Empty;
            this.logoPath = null;
            this.isFavourite = false;
            //this.subscriptionInfo = string.Empty;
            //this.description = string.Empty;
        }
        // generate an example of cards list for a user
        public static ObservableCollection<CardCategory> GenerateCategory()
        {
            ObservableCollection<CardCategory> categories = new ObservableCollection<CardCategory>();

            CardCategory creditCards = new CardCategory();
            creditCards.name = "credit cards";
            creditCards.Add(new GeneralCard("Leumi credit card"));
            creditCards.Add(new GeneralCard("Hapoalim credit card"));

            CardCategory loialtyCards = new CardCategory();
            loialtyCards.name = "Loialty cards";
            loialtyCards.Add(new GeneralCard("Lametayel"));
            loialtyCards.Add(new GeneralCard("Rikushet"));
            loialtyCards.Add(new GeneralCard("Victoria's Secret"));


            CardCategory gymCards = new CardCategory();
            gymCards.name = "Gym Cards";
            gymCards.Add(new GeneralCard("Holme's Place"));
            gymCards.Add(new GeneralCard("Shape"));


            CardCategory moviesShowsTickets = new CardCategory();
            moviesShowsTickets.name = "Movies, Shows, Game Tickets";
            moviesShowsTickets.Add(new GeneralCard("Cinema City"));
            moviesShowsTickets.Add(new GeneralCard("Maccabi - Bloomfield"));

            categories.Add(creditCards);
            categories.Add(loialtyCards);
            categories.Add(gymCards);
            categories.Add(moviesShowsTickets);

            return categories;
        }
    }
}
