using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJackApplication
{
    class Turn
    {
        private Table turnTable;
        private Player turnPlayer;
        private Dealer turnDealer;
        private Deck turnDeck;
        private string turnMoney;
        private string turnBet;
        private bool gameEnd = false;
        tableForm turnForm = new tableForm();
        

        public Turn(tableForm currentForm = null, Deck deck = null, Table table = null, Player player = null, Dealer dealer = null)
        {
            turnForm = currentForm;
            turnTable = table;
            turnPlayer = player;
            turnDealer = dealer;
            turnDeck = deck;
        }

        // Handle adding images to the flowlayoutpanel depending on the user passed in
        public void addImage(Image image, string player)
        { 
            if (player == "player")
            {
                // Adds a picture box with the parameters specified
                turnForm.playerHandFlowLayoutPanel.Controls.Add(new PictureBox()
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(120, 150)
                });
            } else if (player == "dealer")
            {
                turnForm.dealerHandFlowLayoutPanel.Controls.Add(new PictureBox()
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(120, 150)
                });
            }
        }

        // Handles initilization of the table state
        public void beginTurn()
        {
            string turnBet = turnForm.betLabel.Text;
            string turnMoney = turnForm.currentMoneyLabel.Text;
            Console.WriteLine((Convert.ToInt64(turnMoney) - Convert.ToInt64(turnBet)).ToString());
            turnForm.currentMoneyLabel.Text = (Convert.ToInt64(turnMoney) - Convert.ToInt64(turnBet)).ToString();
            turnMoney = turnForm.currentMoneyLabel.Text;

            turnDealer.dealCard(turnPlayer, turnDeck, 2);
            turnDealer.dealCard(turnDealer, turnDeck, 2);

            // Generate the hand for the player and dealer
            foreach (Card card in turnPlayer.currentPlayerHand)
            {
                addImage(card.CardImage, "player");
            }
            foreach (Card card in turnDealer.currentPlayerHand)
            {
                addImage(card.CardImage, "dealer");
            }

            // Set the intial values of the player and dealer totallabels
            turnForm.dealerTotalLabel.Text = turnDealer.ValueOfHand.ToString();
            turnForm.playerTotalLabel.Text = turnPlayer.ValueOfHand.ToString();

            // Handle cases where the dealer immeditately needs to stand or wins the game
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

        public void hitButtonClick()
        {
            // Deal player a new card then update the card images and playerTotalLabel
            turnDealer.dealCard(turnPlayer, turnDeck);
            addImage(turnPlayer.currentPlayerHand[turnPlayer.currentPlayerHand.Count - 1].CardImage, "player");
            turnForm.playerTotalLabel.Text = turnPlayer.ValueOfHand.ToString();

            // Check if player has busted or has 21 after hitting
            if (turnPlayer.ValueOfHand >= 21)
            {
                endTurn();
            }
        }

        // If user stands then the only thing that needs to be handle is the endTurn method
        public void standButtonClick()
        {
            endTurn();
        }

        public void continueButtonClick()
        {
            resetTableTurn();
            beginTurn();
        }

        public void resetTableTurn()
        {
            turnPlayer.currentPlayerHand.Clear();
            turnDealer.currentPlayerHand.Clear();
            turnForm.dealerHandFlowLayoutPanel.Controls.Clear();
            turnForm.playerHandFlowLayoutPanel.Controls.Clear();
            turnBet = turnForm.betLabel.Text;
            turnPlayer.ValueOfHand = 0;
            turnDealer.ValueOfHand = 0;
            turnDeck = new Deck();
        }

        public void endTurn()
        {
            turnForm.continueButton.Enabled = true;
            if (turnPlayer.ValueOfHand > 21)
            {
                turnForm.hitButton.Enabled = false;
                turnForm.standButton.Enabled = false;
                turnForm.endLabel.Text = "You Bust!"; 
            }
            else if (turnPlayer.ValueOfHand > turnDealer.ValueOfHand && turnPlayer.ValueOfHand < 22)
            {
                //player wins
                turnMoney = Convert.ToString(Convert.ToInt64(turnMoney) + (Convert.ToInt64(turnBet) * 2));
            }
            else if (turnDealer.ValueOfHand > turnPlayer.ValueOfHand)
            {
                //dealer wins
                turnForm.endLabel.Text = "Dealer wins!";
            }
            else
            {
                //tie condition return player's bet
                turnMoney = Convert.ToString(Convert.ToInt64(turnMoney) + (Convert.ToInt64(turnBet)));
                turnForm.endLabel.Text = "It's a tie";
            }
            turnForm.currentMoneyLabel.Text = turnMoney;
        }
    }
}
