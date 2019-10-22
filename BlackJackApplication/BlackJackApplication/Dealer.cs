using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class Dealer : Player
    {
        public void dealCard(Player p, Deck d, int numOfCards = 1)
        {
            while (numOfCards > 0)
            {
                Card temp = d.Cards[0];
                d.Cards.RemoveAt(0);
                p.addCardToHand(temp);
                numOfCards--;
            }
        }
    }
}
