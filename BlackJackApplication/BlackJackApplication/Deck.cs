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
        private List<string> possibleSuits = new List<string>();
        private List<string> possibleValues = new List<string>();

        public Deck()
        {
            possibleSuits.Add("Diamond");
            possibleSuits.Add("Hearts");
            possibleSuits.Add("Spades");
            possibleSuits.Add("Clubs");

            possibleValues.Add("A");
            possibleValues.Add("2");
            possibleValues.Add("3");
            possibleValues.Add("4");
            possibleValues.Add("5");
            possibleValues.Add("6");
            possibleValues.Add("7");
            possibleValues.Add("8");
            possibleValues.Add("9");
            possibleValues.Add("10");
            possibleValues.Add("J");
            possibleValues.Add("Q");
            possibleValues.Add("K");

            foreach( string s in possibleSuits)
            {
                foreach( string v in possibleValues)
                {
                    addCardToDeck(new Card(s, v));
                }
            }
            shuffleCards();
        }
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
            Random rnd = new Random();
            for(int i = 0; i < cardsInDeck.Count; i++)
            {
                int x = rnd.Next(0, 51);
                Card temp = cardsInDeck[x];
                cardsInDeck[x] = cardsInDeck[i];
                cardsInDeck[i] = temp;
            }   
        }
    }
}
