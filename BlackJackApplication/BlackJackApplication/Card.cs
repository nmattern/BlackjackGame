using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class Card
    {
        private string cardValue;
        private string cardSuit;

        public Card(string suit, string value)
        {
            cardValue = value;
            cardSuit = suit;
        }
        public string Value
        {
            get { return cardValue;  }
            set { cardValue = value;  }
        }
        public string Suit
        {
            get { return cardSuit; }
            set { cardSuit = value; }
        }
    }
}
