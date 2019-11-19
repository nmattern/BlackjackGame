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
        tableForm turnForm = new tableForm();
        const int IMAGE_DISTANCE_Y = 20;
        const int IMAGE_DISTANCE_X = 20;
        const int PLAYER_IMAGE_Y = 75;
        const int PLAYER_IMAGE_X = 470;
        const int DEALER_IMAGE_Y = 75;
        const int DEALER_IMAGE_X = 40;


        public Turn(tableForm currentForm = null, Deck deck = null, Table table = null, Player player = null, Dealer dealer = null)
        {
            turnForm = currentForm;
            turnTable = table;
            turnPlayer = player;
            turnDealer = dealer;
            turnDeck = deck;
        }

        // Handle adding images to the table depending on the user passed in
        public void addImage(Image image, string player)
        {
            if (player == "player")
            {
                // Adds a picture box with the parameters specified
                for (int cardNum = 0; cardNum < turnPlayer.CurrentPlayerHand.Count; cardNum++)
                {
                    if (turnPlayer.CurrentPlayerHand[cardNum].CardImage == image)
                    {
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = image,
                            BackColor = Color.White,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(120, 150),
                            Location = new Point(PLAYER_IMAGE_X + IMAGE_DISTANCE_X * cardNum, PLAYER_IMAGE_Y + IMAGE_DISTANCE_Y * cardNum)
                        };
                        turnForm.Controls.Add(pictureBox);
                        turnPlayer.PictureBoxes.Add(pictureBox);
                        pictureBox.BringToFront();
                    }
                }
            }
            else if (player == "dealer")
            {
                for (int cardNum = 0; cardNum < turnDealer.CurrentPlayerHand.Count; cardNum++)
                {
                    if (turnDealer.CurrentPlayerHand[cardNum].CardImage == image)
                    {
                        if (turnDealer.CurrentPlayerHand[cardNum].Hidden) { image = Properties.Resources.back; }
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = image,
                            BackColor = Color.White,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(120, 150),
                            Location = new Point(DEALER_IMAGE_X + IMAGE_DISTANCE_X * cardNum, DEALER_IMAGE_Y + IMAGE_DISTANCE_Y * cardNum)
                        };
                        turnForm.Controls.Add(pictureBox);
                        turnDealer.PictureBoxes.Add(pictureBox);
                        pictureBox.BringToFront();
                    }
                }
            }
        }

        public void betButtonClick()
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(turnForm.betTextBox.Text, out number);
            // Validate if the user bet an integer, if not loop until they enter one
            if (betContainsOnlyDigits)
            {
                turnPlayer.CurrentPlayerBet = Convert.ToInt32(turnForm.betTextBox.Text);
                turnPlayer.CurrentAmountOfMoney = Convert.ToInt32(turnForm.currentMoneyLabel.Text);
                if (turnPlayer.CurrentAmountOfMoney - turnPlayer.CurrentPlayerBet >= 0)
                {
                    turnForm.currentMoneyLabel.Text = (turnPlayer.CurrentAmountOfMoney - turnPlayer.CurrentPlayerBet).ToString();
                    turnPlayer.CurrentAmountOfMoney = Convert.ToInt32(turnForm.currentMoneyLabel.Text);
                    turnForm.lockBetButton.Enabled = false;
                    turnForm.betTextBox.ReadOnly = true;
                    turnForm.hitButton.Visible = true;
                    turnForm.standButton.Visible = true;
                    beginTurn();
                } else
                {
                    turnForm.betLabel.Text = "Bet too large";
                }
            } else
            {
                turnForm.betLabel.Text = "Enter a Value";
            }
        }

        public void adjustMoneyButtonClick()
        {
            turnPlayer.CurrentAmountOfMoney = Convert.ToInt32(turnForm.adjustMoneyTextBox.Text);
            turnForm.currentMoneyLabel.Text = turnForm.adjustMoneyTextBox.Text;
        }

        // Handles initilization of the table state
        public void beginTurn()
        {
            turnDealer.dealCard(turnPlayer, turnDeck, 2);
            turnDealer.dealCard(turnDealer, turnDeck, 2);
            turnDealer.CurrentPlayerHand[0].Hidden = true;

            // Generate the hand for the player and dealer
            foreach (Card card in turnPlayer.CurrentPlayerHand)
            {
                addImage(card.CardImage, "player");
            }

            foreach (Card card in turnDealer.CurrentPlayerHand)
            {
                addImage(card.CardImage, "dealer");
            }

            // Set the intial values of the player and dealer total labels
            // First we have to validate the value of the hidden card in case it is a string
            int valueOfFirstCard = 0;
            int number;

            string firstCardValue = (turnDealer.CurrentPlayerHand[0].Value);
            if (firstCardValue == "king" || firstCardValue == "queen" || firstCardValue == "jack")
            {
                valueOfFirstCard = 10;
            }
            else if (Int32.TryParse(firstCardValue, out number))
            {
                valueOfFirstCard = (int)number;
            }

            // Once the card is evaluated we can continue like normal
            turnForm.dealerTotalLabel.Text = (turnDealer.CurrentValueOfHand - valueOfFirstCard).ToString();
            turnForm.playerTotalLabel.Text = turnPlayer.CurrentValueOfHand.ToString();

            // Handle cases where the player or dealer immeditately wins the game
            if (turnPlayer.CurrentValueOfHand == 21)
            {
                if (turnDealer.CurrentValueOfHand != 21)
                {
                    playerBlackjack();
                }
            } else if (turnDealer.CurrentValueOfHand == 21)
            {
                if (turnPlayer.CurrentValueOfHand != 21)
                {
                    dealerWins();
                }
            }
        }

        public void hitButtonClick()
        {
            turnDealer.dealCard(turnPlayer, turnDeck);
            Image image = turnPlayer.CurrentPlayerHand[turnPlayer.CurrentPlayerHand.Count - 1].CardImage;
            addImage(image, "player");
            if (turnPlayer.CurrentPlayerHand[turnPlayer.CurrentPlayerHand.Count - 1].Value == "ace")
            {
                if (turnPlayer.CurrentValueOfHand > 21)
                {
                    turnPlayer.CurrentValueOfHand -= 10;
                }
            }
            turnForm.playerTotalLabel.Text = (turnPlayer.CurrentValueOfHand).ToString();
            if (turnPlayer.CurrentValueOfHand > 21)
            {
                playerBusts();
            }
            else if (turnPlayer.CurrentValueOfHand == 21)
            {
                standButtonClick();
            }
        } 

        // If user stands then the only thing that needs to be handle is the endTurn method
        public void standButtonClick()
        {
            while (turnDealer.CurrentValueOfHand < 17 )
            {
                turnDealer.dealCard(turnDealer, turnDeck);
                Image image = turnDealer.CurrentPlayerHand[turnDealer.CurrentPlayerHand.Count - 1].CardImage;
                addImage(image, "dealer");
                turnForm.dealerTotalLabel.Text = (turnDealer.CurrentValueOfHand).ToString();
            }
            if (turnDealer.CurrentValueOfHand > 21)
            {
                playerWins();
            }
            else if (turnPlayer.CurrentValueOfHand > turnDealer.CurrentValueOfHand)
            {
                playerWins();
            }
            else if (turnDealer.CurrentValueOfHand > turnPlayer.CurrentValueOfHand)
            {
                dealerWins();
            }
            else if (turnPlayer.CurrentValueOfHand == turnDealer.CurrentValueOfHand)
            {
                playerTies();
            } else
            {
                endTurn();
            }
        }

        public void continueButtonClick()
        {
            resetTableTurn();
        }

        public void resetTableTurn()
        {
            // Reset all values on the form, player, and dealer for a new turn
            turnPlayer.CurrentPlayerHand.Clear();
            turnDealer.CurrentPlayerHand.Clear();
            turnPlayer.CurrentValueOfHand = 0;
            turnDealer.CurrentValueOfHand = 0;
            turnForm.endLabel.Text = "";
            turnForm.dealerBetDescriptionLabel.Text = "Current Visible Total";
            turnForm.dealerTotalLabel.Text = "";
            turnForm.playerTotalLabel.Text = "";
            turnDeck = new Deck();
            turnForm.hitButton.Visible = false;
            turnForm.standButton.Visible = false;
            turnForm.lockBetButton.Enabled = true;
            turnForm.betTextBox.ReadOnly = false;
            foreach (PictureBox pictureBox in turnPlayer.PictureBoxes)
            {
                turnForm.Controls.Remove(pictureBox);
            }
            foreach (PictureBox pictureBox in turnDealer.PictureBoxes)
            {
                turnForm.Controls.Remove(pictureBox);
            }
        }

        public void playerBusts()
        { 
            turnForm.endLabel.Text = "You Bust!";
            endTurn();
        }

        public void playerWins()
        {
            turnPlayer.CurrentAmountOfMoney = (turnPlayer.CurrentAmountOfMoney + (turnPlayer.CurrentPlayerBet * 2));
            turnForm.endLabel.Text = "You win!";
            endTurn();
        }

        public void playerBlackjack()
        {
            turnPlayer.CurrentAmountOfMoney = (turnPlayer.CurrentAmountOfMoney + (turnPlayer.CurrentPlayerBet * 2));
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
            turnPlayer.CurrentAmountOfMoney = (turnPlayer.CurrentAmountOfMoney + turnPlayer.CurrentPlayerBet);
            turnForm.endLabel.Text = "It's a tie";
            endTurn();
        }


        public void endTurn()
        {
            // Show all of the cards the dealers hand actually contains at end of turn
            turnDealer.CurrentPlayerHand[0].Hidden = false;
            foreach (Card card in turnDealer.CurrentPlayerHand)
            {
                addImage(card.CardImage, "dealer");
            }
            turnForm.dealerBetDescriptionLabel.Text = "Current Total";
            turnForm.dealerTotalLabel.Text = turnDealer.CurrentValueOfHand.ToString();
            turnForm.hitButton.Visible = false;
            turnForm.standButton.Visible = false;
            turnForm.continueButton.Visible = true;
            turnForm.currentMoneyLabel.Text = (turnPlayer.CurrentAmountOfMoney).ToString();
        }
    }
}
