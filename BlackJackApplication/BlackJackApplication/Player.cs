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

        public int playerChoice()
        {
            // return a value (possible enum) for player action
            return ((int)playerChoiceValues.Stand);
        }
    }
}
