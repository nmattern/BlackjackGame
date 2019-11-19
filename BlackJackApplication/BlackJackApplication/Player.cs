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
        private int currentValueOfHand;
        private int currentAmountofMoney;
        private int currentPlayerBet;
        private int currentInsuranceBet;
        public int playerWins { get; set; }
        public int playerLosses { get; set; }
        private List<Card> playerHand = new List<Card>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        enum playerChoiceValues
        {
            Stand = 1,
            Hit = 2,
            Reset = 3
        }
        public int ValueOfHand
        {
            get { return currentValueOfHand; }
            set { currentValueOfHand = value; }
        }

        public int AmountOfMoney
        {
            get { return currentAmountofMoney; }
            set { currentAmountofMoney = value; }
        }

        public int PlayerBet
        {
            get { return currentPlayerBet; }
            set { currentPlayerBet = value; }
        }

        public int InsuranceBet
        {
            get { return currentInsuranceBet; }
            set { currentInsuranceBet = value; }
        }

        public List<Card> currentPlayerHand
        {
            get { return playerHand; }
            set { playerHand = value; }
        }
        public List<PictureBox> PictureBoxes
        {
            get { return pictureBoxes; }
            set { pictureBoxes = value; }
        }

        public int playerChoice()
        {
            // return a value (possible enum) for player action
            return ((int)playerChoiceValues.Stand);
        }

        public void addCardToHand(Card card)
        {
            long cardNumericalValue;
            playerHand.Add(card);
            if (card.Value == "king" || card.Value == "queen" || card.Value == "jack")
            {
                currentValueOfHand += 10;
            }
            else if (Int64.TryParse(card.Value, out cardNumericalValue))
            {
                currentValueOfHand += (int)cardNumericalValue;
            }
            else
            {
                if (currentValueOfHand + 11 > 21)
                {
                    currentValueOfHand += 1;
                }
                else
                {
                    currentValueOfHand += 11;
                }
            }
            
        }
    }
}
