using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BlackJackTests")]
namespace BlackJackApplication
{
    public class Card
    {
        private string cardValue;
        private string cardSuit;
        private bool hidden;

        public Card(string suit, string value)
        {
            cardValue = value;
            cardSuit = suit;
        }
        public string Value
        {
            get { return cardValue; }
            set { cardValue = value; }
        }
        public string Suit
        {
            get { return cardSuit; }
            set { cardSuit = value; }
        }

        public bool Hidden
        {
            get { return hidden; }
            set { hidden = value; }
        }

        public int NumericValue()
        {
            if (cardValue == "king" || cardValue == "queen" || cardValue == "jack")
                return 10;
            else if (cardValue == "ace")
                return 11;
            else
                return Int32.Parse(cardValue);
        }
    }
}
