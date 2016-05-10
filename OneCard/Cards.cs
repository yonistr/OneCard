using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    public class CardCategory
    {
        public string name { get; set; }
        public SortedSet<Card> cards { get; set; }

        public CardCategory(string category)
        {
            this.name = category;
            this.cards = null;
        }
    }

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

        public PrivateUser GenerateUser()
        {
            PrivateUser demoUser = new PrivateUser("demoUser", "1234");
            demoUser.firstName = "Demonastration";
            demoUser.lastName = "User";
            SortedSet<CardCategory> categories = new SortedSet<CardCategory>();

            CardCategory creditCards = new CardCategory("credit cards");
            SortedSet<Card> creditCardsSet = new SortedSet<Card>();
            Card leumiCreditCard = new Card("Leumi credit card");
            Card poalimCreditCard = new Card("Hapoalim credit card");
            creditCardsSet.Add(leumiCreditCard);
            creditCardsSet.Add(poalimCreditCard);
            creditCards.cards = creditCardsSet;

            CardCategory loialtyCards = new CardCategory("Loialty cards");
            SortedSet<Card> loialtyCardsSet = new SortedSet<Card>();
            Card lametayel = new Card("Lametayel");
            Card rikushet = new Card("Rikushet");
            Card victoriasSecret = new Card("Victoria's Secret");
            loialtyCardsSet.Add(lametayel);
            loialtyCardsSet.Add(rikushet);
            loialtyCardsSet.Add(victoriasSecret);
            loialtyCards.cards = loialtyCardsSet;

            CardCategory gymCards = new CardCategory("Gym Cards");
            SortedSet<Card> gymCardsSet = new SortedSet<Card>();
            Card holmesPlace = new Card("Holme's Place");
            Card shape = new Card("Shape");
            gymCardsSet.Add(holmesPlace);
            gymCardsSet.Add(shape);
            gymCards.cards = gymCardsSet;

            CardCategory moviesShowsTickets = new CardCategory("Movies, Shows, Game Tickets");
            SortedSet<Card> ticketSet = new SortedSet<Card>();
            Card cinemaCityTickets = new Card("Cinema City");
            Card maccabi = new Card("Maccabi - Bloomfield");
            ticketSet.Add(cinemaCityTickets);
            ticketSet.Add(maccabi);
            moviesShowsTickets.cards = ticketSet;

            categories.Add(creditCards);
            categories.Add(loialtyCards);
            categories.Add(gymCards);
            categories.Add(moviesShowsTickets);

            demoUser.cardCategories = categories;
            return demoUser;
        }
    }
}
