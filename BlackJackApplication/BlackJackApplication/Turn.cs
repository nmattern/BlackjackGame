using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class Turn
    {
        private Table turnTable;
        private Player turnPlayer;
        private Dealer turnDealer;
        private Deck turnDeck;
        private int turnMoney;
        private int turnBet;
        private bool gameEnd = false;
        tableForm tableForm = new tableForm();
        

        public Turn(tableForm currentForm, Deck deck, Table table, Player player, Dealer dealer, int money, int bet)
        {
            tableForm = currentForm;
            turnTable = table;
            turnPlayer = player;
            turnDealer = dealer;
            turnDeck = deck;
            turnMoney = money;
            turnBet = bet;
        }


        public void beginTurn()
        {
            string bet = tableForm.betLabel.Text;
            turnDealer.dealCard(turnPlayer, turnDeck, 2);
            turnDealer.dealCard(turnDealer, turnDeck, 2);
            if (turnDealer.ValueOfHand >= 17)
            {
                if (turnDealer.ValueOfHand == 21 && turnPlayer.ValueOfHand != 21)
                {
                    //dealer blackjack end turn
                }
                // Dealer waits
            }
            else
            {
                //dealer hits
            }
            if (turnPlayer.ValueOfHand == 21)
            {
                // player wins
            }
        }

        public void runTurn()
        {
            
        }

        public void endTurn()
        {

        }
    }
}
