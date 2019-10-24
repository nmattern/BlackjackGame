using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApplication
{
    class Player
    {
        private int currentValueOfHand;
        private int currentAmountofMoney;
        private int currentPlayerBet;
        private List<Card> playerHand = new List<Card>();

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

        public List<Card> currentPlayerHand
        {
            get { return playerHand; }
            set { playerHand = value; }
        }

        public int playerChoice()
        {
            // return a value (possible enum) for player action
            return ((int)playerChoiceValues.Stand);
        }
        public void changeMoneyValue(int newValue)
        {
            currentAmountofMoney = newValue;
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
