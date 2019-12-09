using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class Dealer : Player
    {
        private int currentVisibleValueOfHand;

        public int VisibleValueOfHand
        {
            get { return currentVisibleValueOfHand; }
            set { currentVisibleValueOfHand = value; }
        }
        public void dealCard(GamePlayer player, Deck deck, int numOfCards = 1)
        {
            while (numOfCards > 0)
            {
                Card temp = deck.Cards[0];
                deck.Cards.RemoveAt(0);
                //player.addCardToHand(temp);
                player.PlayerHand.Add(temp);
                numOfCards--;
            }
        }

        public void dealSelf(Dealer dealer, Deck deck, int numOfCards = 1)
        {
            while (numOfCards > 0)
            {
                Card temp = deck.Cards[0];
                deck.Cards.RemoveAt(0);
                dealer.CurrentPlayerHand.Add(temp);
                numOfCards--;
            }
        }
    }
}
