using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class Card
    {
        private int cardValue;
        private string cardSuit;

        public int Value
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
