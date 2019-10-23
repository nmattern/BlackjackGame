using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class Table
    {
        private List<Card> playerHand = new List<Card>();
        private List<Card> dealerHand = new List<Card>();
        private int playerBet;
        private int playerMoney;

        public List<Card> playerHandState
        {
            set { playerHand = value; }
        }

        public List<Card> dealerHandState
        {
            set { dealerHand = value; }
        }

        public int playerBetState
        {
            set { playerBet = value; }
        }

        public int playerMoneyState
        {
            set { playerMoney = value; }
        }


    }
}
