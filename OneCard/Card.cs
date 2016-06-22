using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class Card
    {
        public string name { get; set; }
        public bool isLocationAvailable { get; set; }
        public bool autoWriteLocation { get; set; }
        public string securityType { get; set; }
        public Uri logoPath { get; set; }
        public bool isFavourite { get; set; }
        public string subscriptionInfo { get; set; }
        public string description { get; set; }

        public Card(string name)
        {
            this.name = name;
            this.isLocationAvailable = false;
            this.autoWriteLocation = false;
            this.securityType = string.Empty;
            this.logoPath = null;
            this.isFavourite = false;
            this.subscriptionInfo = string.Empty;
            this.description = string.Empty;
        }
        // generate an example of cards list for a user
        public static ObservableCollection<CardCategory> GenerateCategory()
        {
            ObservableCollection<CardCategory> categories = new ObservableCollection<CardCategory>();

            CardCategory creditCards = new CardCategory();
            creditCards.name = "credit cards";
            creditCards.Add(new Card("Leumi credit card"));
            creditCards.Add(new Card("Hapoalim credit card"));

            CardCategory loialtyCards = new CardCategory();
            loialtyCards.name = "Loialty cards";
            loialtyCards.Add(new Card("Lametayel"));
            loialtyCards.Add(new Card("Rikushet"));
            loialtyCards.Add(new Card("Victoria's Secret"));


            CardCategory gymCards = new CardCategory();
            gymCards.name = "Gym Cards";
            gymCards.Add(new Card("Holme's Place"));
            gymCards.Add(new Card("Shape"));


            CardCategory moviesShowsTickets = new CardCategory();
            moviesShowsTickets.name = "Movies, Shows, Game Tickets";
            moviesShowsTickets.Add(new Card("Cinema City"));
            moviesShowsTickets.Add(new Card("Maccabi - Bloomfield"));

            categories.Add(creditCards);
            categories.Add(loialtyCards);
            categories.Add(gymCards);
            categories.Add(moviesShowsTickets);

            return categories;
        }
    }
}
