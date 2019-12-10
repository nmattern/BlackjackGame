using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlackJackApplication
{
    class GamePlayer
    {
        private string username;
        private int playerAmountOfMoney;
        private int playerBet;
        private int playerHandValue;
        private Point location;
        private List<Card> playerHand = new List<Card>();
        

        public string Username { get => username; set => username = value; }
        public int PlayerAmountOfMoney { get => playerAmountOfMoney; set => playerAmountOfMoney = value; }
        public int PlayerBet { get => playerBet; set => playerBet = value; }
        public int PlayerHandValue { get => playerHandValue; set => playerHandValue = value; }
        public List<Card> PlayerHand { get => playerHand; set => playerHand = value; }
        public Point Location { get => location; set => location = value; }
    }
}
