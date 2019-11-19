using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackApplication
{
    class Player
    {
        private int FBID;
        private string username;
        private string password;
        private string recovQ;
        private string recovA;
        private int creditC;
        private string name;
        private string address;
        private int phone;
        private int currentValueOfHand;
        private int currentAmountofMoney;
        private int currentPlayerBet;
        private List<Card> currentPlayerHand = new List<Card>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public int Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }
        public int CreditC { get => creditC; set => creditC = value; }
        public string RecovA { get => recovA; set => recovA = value; }
        public string RecovQ { get => recovQ; set => recovQ = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public int FBID1 { get => FBID; set => FBID = value; }
        public List<PictureBox> PictureBoxes { get => pictureBoxes; set => pictureBoxes = value; }
        public int CurrentValueOfHand { get => currentValueOfHand; set => currentValueOfHand = value; }
        public int CurrentAmountOfMoney { get => currentAmountofMoney; set => currentAmountofMoney = value; }
        public int CurrentPlayerBet { get => currentPlayerBet; set => currentPlayerBet = value; }
        internal List<Card> CurrentPlayerHand { get => currentPlayerHand; set => currentPlayerHand = value; }

        public void addCardToHand(Card card)
        {
            long cardNumericalValue;
            CurrentPlayerHand.Add(card);
            if (card.Value == "king" || card.Value == "queen" || card.Value == "jack")
            {
                CurrentValueOfHand += 10;
            }
            else if (Int64.TryParse(card.Value, out cardNumericalValue))
            {
                CurrentValueOfHand += (int)cardNumericalValue;
            }
            else
            {
                if (CurrentValueOfHand + 11 > 21)
                {
                    CurrentValueOfHand += 1;
                }
                else
                {
                    CurrentValueOfHand += 11;
                }
            }
            
        }
    }
}
