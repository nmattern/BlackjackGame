using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlackJackApplication
{
    class Card
    {
        private string cardValue;
        private string cardSuit;
        private Image cardImage;
        private bool hidden;

        public Card(string suit, string value, Image image)
        {
            cardValue = value;
            cardSuit = suit;
            cardImage = image;
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

        public Image CardImage
        {
            get { return cardImage; }
            set { cardImage = value; }
        }
        
        public bool Hidden
        {
            get { return hidden;}
            set { hidden = value; }
        }
    }
}
