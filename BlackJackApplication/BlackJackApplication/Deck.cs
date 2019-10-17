using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class Deck
    {
        private List<Card> cardsInDeck = new List<Card>();

        public List<Card> Cards
        {
            get { return cardsInDeck; }
            set { cardsInDeck = value; }
        }

        public void addCardToDeck(Card card)
        {
            cardsInDeck.Add(card);
        }

        public void shuffleCards()
        {

        }
    }
}
