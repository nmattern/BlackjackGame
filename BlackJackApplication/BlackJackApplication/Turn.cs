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

        public void betButtonClick()
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(turnForm.betTextBox.Text, out number);
            // Validate if the user bet an integer, if not loop until they enter one
            if (betContainsOnlyDigits)
            {
                turnPlayer.PlayerBet = Convert.ToInt32(turnForm.betTextBox.Text);
                turnPlayer.AmountOfMoney = Convert.ToInt32(turnForm.currentMoneyLabel.Text);
                turnForm.currentMoneyLabel.Text = (turnPlayer.AmountOfMoney - turnPlayer.PlayerBet).ToString();
                turnPlayer.AmountOfMoney = Convert.ToInt32(turnForm.currentMoneyLabel.Text);
                turnForm.lockBetButton.Enabled = false;
                turnForm.betTextBox.ReadOnly = true;
                turnForm.hitButton.Enabled = true;
                turnForm.standButton.Enabled = true;
                beginTurn();
            } else
            {
                turnForm.betLabel.Text = "Enter a Value";
            }
        }

        // Handles initilization of the table state
        public void beginTurn()
        {
            turnDealer.dealCard(turnPlayer, turnDeck, 2);
            turnDealer.dealCard(turnDealer, turnDeck, 2);

            // Generate the hand for the player and dealer
            foreach (Card card in turnPlayer.currentPlayerHand)
            {
                addImage(card.CardImage, "player");
            }

            // First card of dealers hand will be the back of the card
            addImage(Properties.Resources.back, "dealer");
            addImage(turnDealer.currentPlayerHand[turnDealer.currentPlayerHand.Count - 1].CardImage, "dealer");

            // Set the intial values of the player and dealer total labels
            // First we have to validate the value of the hidden card in case it is a string
            int valueOfFirstCard = 0;
            int number;
            string firstCardValue = (turnDealer.currentPlayerHand[0].Value);
            if (firstCardValue == "king" || firstCardValue == "queen" || firstCardValue == "jack")
            {
                valueOfFirstCard = 10;
            }
            else if (Int32.TryParse(firstCardValue, out number))
            {
                valueOfFirstCard = (int)number;
            }
            // Once the card is evaluated we can continue like normal
            turnForm.dealerTotalLabel.Text = (turnDealer.ValueOfHand - valueOfFirstCard).ToString();
            turnForm.playerTotalLabel.Text = turnPlayer.ValueOfHand.ToString();

            // Handle cases where the player or dealer immeditately wins the game
            if (turnPlayer.ValueOfHand == 21)
            {
                if (turnDealer.ValueOfHand != 21)
                {
                    playerBlackjack();
                }
            } else if (turnDealer.ValueOfHand == 21)
            {
                if (turnPlayer.ValueOfHand != 21)
                {
                    dealerWins();
                }
            }
        }

        public void hitButtonClick()
        {
            turnDealer.dealCard(turnPlayer, turnDeck);
            Image image = turnPlayer.currentPlayerHand[turnPlayer.currentPlayerHand.Count - 1].CardImage;
            addImage(image, "player");
            turnForm.playerTotalLabel.Text = (turnPlayer.ValueOfHand).ToString();
            turnForm.dealerTotalLabel.Text = (turnDealer.ValueOfHand).ToString();
            if (turnPlayer.ValueOfHand > 21)
            {
                playerBusts();
            }
        } 

        // If user stands then the only thing that needs to be handle is the endTurn method
        public void standButtonClick()
        {
            while (turnDealer.ValueOfHand < 17 )
            {
                turnDealer.dealCard(turnDealer, turnDeck);
                Image image = turnDealer.currentPlayerHand[turnDealer.currentPlayerHand.Count - 1].CardImage;
                addImage(image, "dealer");
                turnForm.dealerTotalLabel.Text = (turnDealer.ValueOfHand).ToString();
            }
            if (turnDealer.ValueOfHand > 21)
            {
                playerWins();
            } else if (turnPlayer.ValueOfHand > turnDealer.ValueOfHand)
            {
                playerWins();
            } else if (turnDealer.ValueOfHand > turnPlayer.ValueOfHand)
            {
                dealerWins();
            } else if (turnPlayer.ValueOfHand == turnDealer.ValueOfHand)
            {
                playerTies();
            }
            endTurn();
        }

        public void continueButtonClick()
        {
            resetTableTurn();
        }

        public void resetTableTurn()
        {
            // Reset all values on the form, player, and dealer for a new turn
            turnPlayer.currentPlayerHand.Clear();
            turnDealer.currentPlayerHand.Clear();
            turnForm.dealerHandFlowLayoutPanel.Controls.Clear();
            turnForm.playerHandFlowLayoutPanel.Controls.Clear();
            turnPlayer.ValueOfHand = 0;
            turnDealer.ValueOfHand = 0;
            turnForm.endLabel.Text = "";
            turnForm.dealerBetDescriptionLabel.Text = "Current Visible Total";
            turnForm.dealerTotalLabel.Text = "";
            turnForm.playerTotalLabel.Text = "";
            turnDeck = new Deck();
            turnForm.hitButton.Enabled = false;
            turnForm.standButton.Enabled = false;
            turnForm.lockBetButton.Enabled = true;
            turnForm.betTextBox.ReadOnly = false;
        }

        public void playerBusts()
        { 
            turnForm.endLabel.Text = "You Bust!";
            endTurn();
        }

        public void playerWins()
        {
            turnPlayer.AmountOfMoney = (turnPlayer.AmountOfMoney + (turnPlayer.PlayerBet * 2));
            turnForm.endLabel.Text = "You win!";
            endTurn();
        }

        public void playerBlackjack()
        {
            turnPlayer.AmountOfMoney = (turnPlayer.AmountOfMoney + (turnPlayer.PlayerBet * 2));
            turnForm.endLabel.Text = "Blackjack! You Win";
            endTurn();
        }

        public void dealerWins()
        {
            turnForm.endLabel.Text = "Dealer wins!";
            endTurn();
        }

        public void playerTies()
        {
            turnPlayer.AmountOfMoney = (turnPlayer.AmountOfMoney + turnPlayer.PlayerBet);
            turnForm.endLabel.Text = "It's a tie";
            endTurn();
        }


        public void endTurn()
        {
            // Show all of the cards the dealers hand actually contains at end of turn
            turnForm.dealerHandFlowLayoutPanel.Controls.Clear();
            foreach (Card card in turnDealer.currentPlayerHand)
            {
                addImage(card.CardImage, "dealer");
            }
            turnForm.dealerBetDescriptionLabel.Text = "Current Total";
            turnForm.dealerTotalLabel.Text = turnDealer.ValueOfHand.ToString();
            turnForm.hitButton.Enabled = false;
            turnForm.standButton.Enabled = false;
            turnForm.continueButton.Enabled = true;
            turnForm.currentMoneyLabel.Text = (turnPlayer.AmountOfMoney).ToString();
        }
    }
}
