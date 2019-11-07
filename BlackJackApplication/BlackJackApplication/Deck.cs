using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlackJackApplication
{
    class Deck
    {
        private List<Card> cardsInDeck = new List<Card>();
        private List<string> possibleSuits = new List<string>();
        private List<string> possibleValues = new List<string>();

        public Deck()
        {
            // List of possible suits of cards in string format
            possibleSuits.Add("diamonds");
            possibleSuits.Add("hearts");
            possibleSuits.Add("spades");
            possibleSuits.Add("clubs");

            // List of possible values of cards in string format
            possibleValues.Add("ace");
            possibleValues.Add("2");
            possibleValues.Add("3");
            possibleValues.Add("4");
            possibleValues.Add("5");
            possibleValues.Add("6");
            possibleValues.Add("7");
            possibleValues.Add("8");
            possibleValues.Add("9");
            possibleValues.Add("10");
            possibleValues.Add("jack");
            possibleValues.Add("queen");
            possibleValues.Add("king");

            // Iterate through the values and suits of the cards so all 
            // variations of cards are added
            foreach( string suit in possibleSuits)
            {
                foreach( string value in possibleValues)
                {
                    // create a string to store location of image
                    string imgLocation = "";
                    // verify is value is an integer (integers have extra underscore in front)
                    if (value.All(char.IsDigit) )
                    {
                        imgLocation = "_" + value + "_of_" + suit;
                    } else
                    {
                        imgLocation = value + "_of_" + suit;
                    }
                    // Set an object to the value from resource manager for the image
                    object imgResource = Properties.Resources.ResourceManager.GetObject(imgLocation);
                    // Set the image by grabbing the image type from the object
                    Image image = imgResource as Image;

                    addCardToDeck(new Card(suit, value, image));
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
                // x will be a value from 0-52 (Number of cards in deck)
                int x = rnd.Next(0, 52);
                Card temp = cardsInDeck[x];
                cardsInDeck[x] = cardsInDeck[i];
                cardsInDeck[i] = temp;
            }   
        }
    }
}
