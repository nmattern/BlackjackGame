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
        private Player turnPlayer;
        private Dealer turnDealer;
        private Deck turnDeck;
        private bool gameEnd = false;
        const int IMAGE_STARTING_LOCATION_X = 192;
        const int IMAGE_DISTANCE_X = 30;
        const int PLAYER_IMAGE_Y = 500;
        const int DEALER_IMAGE_Y = 15;
        tableForm turnForm = new tableForm();


        public Turn(tableForm currentForm = null, Deck deck = null, Player player = null, Dealer dealer = null)
        {
            turnForm = currentForm;
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
                for (int cardNum = 0; cardNum < turnPlayer.currentPlayerHand.Count; cardNum++)
                {
                    if (turnPlayer.currentPlayerHand[cardNum].CardImage == image)
                    {
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = image,
                            BackColor = Color.White,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(120, 150),
                            Location = new Point(IMAGE_STARTING_LOCATION_X + IMAGE_DISTANCE_X * cardNum, PLAYER_IMAGE_Y)
                        };
                        turnForm.Controls.Add(pictureBox);
                        turnPlayer.PictureBoxes.Add(pictureBox);
                        pictureBox.BringToFront();
                    }
                }
            }
            else if (player == "dealer")
            {
                for (int cardNum = 0; cardNum < turnDealer.currentPlayerHand.Count; cardNum++)
                {
                    if (turnDealer.currentPlayerHand[cardNum].CardImage == image)
                    {
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = image,
                            BackColor = Color.White,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(120, 150),
                            Location = new Point(IMAGE_STARTING_LOCATION_X + IMAGE_DISTANCE_X * cardNum, DEALER_IMAGE_Y)
                        };
                        turnForm.Controls.Add(pictureBox);
                        turnDealer.PictureBoxes.Add(pictureBox);
                        pictureBox.BringToFront();
                    }
                }
            }
        }

        // Handles initilization of the table state
        public void beginTurn()
        {
            turnPlayer.PlayerBet = Convert.ToInt32(turnForm.betLabel.Text);
            turnPlayer.AmountOfMoney = Convert.ToInt32(turnForm.currentMoneyLabel.Text);
            turnForm.currentMoneyLabel.Text = (turnPlayer.AmountOfMoney - turnPlayer.PlayerBet).ToString();
            turnPlayer.AmountOfMoney = Convert.ToInt32(turnForm.currentMoneyLabel.Text);

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

            // Handle cases where the player or dealer immeditately wins the game
            if (turnPlayer.ValueOfHand == 21)
            {
                if (turnDealer.ValueOfHand != 21)
                {
                    playerBlackjack();
                }
            }
            else if (turnDealer.ValueOfHand == 21)
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
            while (turnDealer.ValueOfHand < 17)
            {
                turnDealer.dealCard(turnDealer, turnDeck);
                Image image = turnDealer.currentPlayerHand[turnDealer.currentPlayerHand.Count - 1].CardImage;
                addImage(image, "dealer");
                turnForm.dealerTotalLabel.Text = (turnDealer.ValueOfHand).ToString();
            }
            if (turnDealer.ValueOfHand > 21)
            {
                playerWins();
            }
            else if (turnPlayer.ValueOfHand > turnDealer.ValueOfHand)
            {
                playerWins();
            }
            else if (turnDealer.ValueOfHand > turnPlayer.ValueOfHand)
            {
                dealerWins();
            }
            else if (turnPlayer.ValueOfHand == turnDealer.ValueOfHand)
            {
                playerTies();
            }
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
            turnPlayer.PlayerBet = Convert.ToInt32(turnForm.betLabel.Text);
            turnPlayer.ValueOfHand = 0;
            turnDealer.ValueOfHand = 0;
            turnForm.endLabel.Text = "";
            turnDeck = new Deck();
            foreach(PictureBox pictureBox in turnPlayer.PictureBoxes)
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
            turnForm.hitButton.Enabled = false;
            turnForm.standButton.Enabled = false;
            turnForm.continueButton.Enabled = true;
            turnForm.currentMoneyLabel.Text = (turnPlayer.AmountOfMoney).ToString();
        }
    }
}
