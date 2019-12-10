using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BlackJackApplication
{
    class LocalTurn
    {
        private Player player;
        private Dealer dealer;
        private Deck deck;
        private frmGameBoard gameBoard;
        const int IMAGE_DISTANCE_Y = 20;
        const int IMAGE_DISTANCE_X = 20;
        public Point dealerLocation = new Point(16, 54);
        public int turnCounter = 0;
        public int hand = 0;
        public int valueOfFirstHand = 0;
        public int valueOfSecondHand = 0;
        Card secondHand;

        public LocalTurn(Player aPlayer, Dealer deal, Deck deckarg, frmGameBoard game)
        {
            player = aPlayer;
            dealer = deal;
            deck = deckarg;
            gameBoard = game;
            player.ALocalGame.PlayerList[turnCounter].hasSplit = false;
        }

        public void addImage(Image image, string player)
        {

        }

        public void addPlayerCard(Card card, GamePlayer aplayer)
        {
            // add picture box
            for (int cardNum = 0; cardNum < aplayer.PlayerHand.Count; cardNum++)
            {
                Point newPosition = new Point(aplayer.Location.X + IMAGE_DISTANCE_X * cardNum, aplayer.Location.Y + IMAGE_DISTANCE_Y * cardNum);
                if (aplayer.PlayerHand[cardNum].CardImage == card.CardImage)
                {
                    PictureBox pictureBox = new PictureBox()
                    {
                        Image = card.CardImage,
                        BackColor = Color.White,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(120, 150),
                        Location = newPosition
                    };
                    gameBoard.Controls.Add(pictureBox);
                    player.PictureBoxes.Add(pictureBox);
                    pictureBox.BringToFront();
                }
            }
        }

        public void addPlayerCard(Card card, GamePlayer aplayer, int numHand)
        {
            if (numHand == 0)
            {
                for (int cardNum = 0; cardNum < aplayer.PlayerHand.Count; cardNum++)
                {
                    Point newPosition = new Point(aplayer.Location.X + IMAGE_DISTANCE_X * cardNum, aplayer.Location.Y + IMAGE_DISTANCE_Y * cardNum);
                    if (aplayer.PlayerHand[cardNum].CardImage == card.CardImage)
                    {
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = card.CardImage,
                            BackColor = Color.White,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(120, 150),
                            Location = newPosition
                        };
                        gameBoard.Controls.Add(pictureBox);
                        player.PictureBoxes.Add(pictureBox);
                        pictureBox.BringToFront();
                    }
                }
            } else
            {
                for (int cardNum = 0; cardNum < aplayer.PlayerHand.Count; cardNum++)
                {
                    Point newPosition = new Point(30 + aplayer.Location.X + IMAGE_DISTANCE_X * cardNum, aplayer.Location.Y + IMAGE_DISTANCE_Y * cardNum);
                    if (aplayer.PlayerHand[cardNum].CardImage == card.CardImage)
                    {
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = card.CardImage,
                            BackColor = Color.White,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(120, 150),
                            Location = newPosition
                        };
                        gameBoard.Controls.Add(pictureBox);
                        player.PictureBoxes.Add(pictureBox);
                        pictureBox.BringToFront();
                    }
                }
            }
        }

        public void addDealerCard(Card card, Dealer deal)
        {
            dealer = deal;
            for (int cardNum = 0; cardNum < dealer.CurrentPlayerHand.Count; cardNum++)
            {
                Point newPosition = new Point(dealerLocation.X + IMAGE_DISTANCE_X * cardNum, dealerLocation.Y + IMAGE_DISTANCE_Y * cardNum);
                if (dealer.CurrentPlayerHand[cardNum].CardImage == card.CardImage)
                {
                    PictureBox pictureBox = new PictureBox()
                    {
                        Image = card.CardImage,
                        BackColor = Color.White,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(120, 150),
                        Location = newPosition
                    };
                    gameBoard.Controls.Add(pictureBox);
                    dealer.PictureBoxes.Add(pictureBox);
                    pictureBox.BringToFront();
                }
            }
        }

        public void betButtonClick()
        {
            int number;
            bool betContainsOnlyDigits = Int32.TryParse(Regex.Replace(gameBoard.betTextBox.Text, "[A-Za-z :]", ""), out number);
            // Validate if the user bet an integer, if not loop until they enter one
            if (betContainsOnlyDigits)
            {

                player.ALocalGame.PlayerList[turnCounter].PlayerBet = Convert.ToInt32(Regex.Replace(gameBoard.betTextBox.Text, "[A-Za-z :]", ""));
                player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney = Convert.ToInt32(Regex.Replace(gameBoard.currentMoneyLabels[turnCounter].Text, "[A-Za-z :]", ""));
                if (player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney - player.ALocalGame.PlayerList[turnCounter].PlayerBet >= 0)
                {
                    gameBoard.currentMoneyLabels[turnCounter].Text = "Current Money: " + (player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney
                        - player.ALocalGame.PlayerList[turnCounter].PlayerBet).ToString();
                    player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney = Convert.ToInt32(Regex.Replace(gameBoard.currentMoneyLabels[turnCounter].Text, "[A-Za-z :]", ""));
                    gameBoard.betButton.Enabled = false;
                    gameBoard.betTextBox.ReadOnly = true;
                    gameBoard.hitButton.Visible = true;
                    gameBoard.standButton.Visible = true;
                    beginTurn();
                }
                else
                {
                    gameBoard.currentBetLabels[turnCounter].Text = "Current Bet: Bet too large";
                }
            }
            else
            {
                gameBoard.currentBetLabels[turnCounter].Text = "Current Bet: Enter a Value";
            }
        }

        public void adjustMoneyButtonClick()
        {
            player.ALocalGame.PlayerList[turnCounter].PlayerAmountOfMoney = Convert.ToInt32(gameBoard.adjustMoneyTextBox.Text);
            gameBoard.currentMoneyLabels[turnCounter].Text = gameBoard.adjustMoneyTextBox.Text;
        }

        // Handles initialization of table state
        public void beginTurn()
        {
            int j;
            for(j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                dealer.dealCard(player.ALocalGame.PlayerList[j], deck, 2);
            }
            dealer.dealSelf(dealer, deck, 2);
            dealer.CurrentPlayerHand[0].Hidden = true;

            // Generates the hand for the players
            for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                foreach(Card card in player.ALocalGame.PlayerList[j].PlayerHand)
                {
                    addPlayerCard(card, player.ALocalGame.PlayerList[j]);
                }
            }

            // Generates the hand for the dealer
            foreach (Card card in dealer.CurrentPlayerHand)
            {
                addDealerCard(card, dealer);
            }

            // Set the intial values of the player and dealer total labels
            // First we have to validate the value of the hidden card in case it is a string
            int valueOfFirstCard = 0;
            int number;

            string firstCardValue = (dealer.CurrentPlayerHand[0].Value);
            if (firstCardValue == "king" || firstCardValue == "queen" || firstCardValue == "jack")
            {
                valueOfFirstCard = 10;
            }
            else if (Int32.TryParse(firstCardValue, out number))
            {
                valueOfFirstCard = (int)number;
            }

            // set the new labels for the dealer and each player
            gameBoard.dealerVisableTotalLabel.Text = (dealer.CurrentValueOfHand - valueOfFirstCard).ToString();
            for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                gameBoard.currentTotalLabels[j].Text = player.ALocalGame.PlayerList[j].PlayerHandValue.ToString();
            }

            // Handle cases where the player or dealer immeditately wins the game
            for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                if (player.ALocalGame.PlayerList[j].PlayerHandValue == 21)
                {
                    if (dealer.CurrentValueOfHand != 21)
                    {
                        playerBlackjack(player.ALocalGame.PlayerList[j]);
                    }
                }
                else if (dealer.CurrentValueOfHand == 21)
                {
                    if (player.ALocalGame.PlayerList[j].PlayerHandValue != 21)
                    {
                        dealerWins();
                    }
                } else if (player.ALocalGame.PlayerList[j].PlayerHand[0].Value == player.ALocalGame.PlayerList[j].PlayerHand[1].Value)
                {
                    gameBoard.controlsGroupBox.Size = new Size(197, 460);
                    gameBoard.splitButton.Visible = true;
                }
            }
        }

        public void hitButtonClick()
        {
            
            dealer.dealCard(player.ALocalGame.PlayerList[turnCounter], deck);

            Card card = player.ALocalGame.PlayerList[turnCounter].PlayerHand[player.ALocalGame.PlayerList[turnCounter].PlayerHand.Count - 1];
            if (player.ALocalGame.PlayerList[turnCounter].hasSplit)
            {
                addPlayerCard(card, player.ALocalGame.PlayerList[turnCounter], hand);
            }
            else
            {
                addPlayerCard(card, player.ALocalGame.PlayerList[turnCounter]);
            }
            if (player.ALocalGame.PlayerList[turnCounter].PlayerHand[player.ALocalGame.PlayerList[turnCounter].PlayerHand.Count - 1].Value == "ace")
            {
                if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue > 21)
                {
                    player.ALocalGame.PlayerList[turnCounter].PlayerHandValue -= 10;
                }
            }
            gameBoard.currentTotalLabels[turnCounter].Text = "Current Total: " + (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue).ToString();
            if (!player.ALocalGame.PlayerList[turnCounter].hasSplit)
            {
                if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue > 21)
                {
                    playerBusts(player.ALocalGame.PlayerList[turnCounter]);
                }
                else if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue == 21)
                {
                    standButtonClick();
                }
            } else
            {
                if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue > 21 || player.ALocalGame.PlayerList[turnCounter].PlayerHandValue == 21)
                {
                    standButtonClick();
                }
            }
            
        }

        public void standButtonClick()
        {
            int j;
            GamePlayer winner = null;
            if (!player.ALocalGame.PlayerList[turnCounter].hasSplit)
            {
                if (turnCounter == 3)
                {
                    while (dealer.CurrentValueOfHand < 17)
                    {
                        dealer.dealSelf(dealer, deck);
                        Card card = dealer.CurrentPlayerHand[dealer.CurrentPlayerHand.Count - 1];
                        addDealerCard(card, dealer);
                        gameBoard.dealerVisableTotalLabel.Text = (dealer.CurrentValueOfHand).ToString();
                    }

                    int currTop = 0;
                    int loses = 0;
                    for (j = 0; j < player.ALocalGame.PlayerList.Count; j++)
                    {
                        if (player.ALocalGame.PlayerList[j].PlayerHandValue == 21)
                        {
                            winner = player.ALocalGame.PlayerList[j];
                            break;
                        }
                        else if (player.ALocalGame.PlayerList[j].PlayerHandValue < 21 && player.ALocalGame.PlayerList[j].PlayerHandValue > currTop)
                        {
                            currTop = player.ALocalGame.PlayerList[j].PlayerHandValue;
                            winner = player.ALocalGame.PlayerList[j];
                        }
                        else
                        {
                            loses++;
                            if (loses > 2)
                            {
                                dealerWins();
                            }
                        }
                    }
                    if (loses < 3)
                    {
                        playerWins(winner);
                    }
                }
                else
                {
                    turnCounter++;
                }
            } else if (hand == 0)
            {
                if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue == 21)
                {
                    // Blackjack!
                }
                else if (player.ALocalGame.PlayerList[turnCounter].PlayerHandValue > 21)
                {
                    // Bust!
                }
                valueOfFirstHand = player.ALocalGame.PlayerList[turnCounter].PlayerHandValue;
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue = 0;
                player.ALocalGame.PlayerList[turnCounter].PlayerHand.Clear();
                player.ALocalGame.PlayerList[turnCounter].PlayerHand.Add(secondHand);
                hand = 1;
            }
        }

        public void continueButtonClick()
        {
            resetTableTurn();
        }

        public void splitButtonClick()
        {
            player.ALocalGame.PlayerList[turnCounter].hasSplit = true;
            foreach (PictureBox picture in gameBoard.Controls)
            {
                gameBoard.Controls.Remove(picture);
            }

            for (int j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (player.ALocalGame.PlayerList[j].hasSplit)
                    {
                        addPlayerCard(player.ALocalGame.PlayerList[j].PlayerHand[i], player.ALocalGame.PlayerList[j], i);
                    }
                    else
                    {
                        addPlayerCard(player.ALocalGame.PlayerList[j].PlayerHand[i], player.ALocalGame.PlayerList[j]);
                    }
                }
            }

            // Generates the hand for the dealer
            foreach (Card card in dealer.CurrentPlayerHand)
            {
                addDealerCard(card, dealer);
            }

            if (player.ALocalGame.PlayerList[turnCounter].PlayerHand[0].Value == "ace")
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue = 11;
            }
            else
            {
                player.ALocalGame.PlayerList[turnCounter].PlayerHandValue /= 2;
            }

            secondHand = player.ALocalGame.PlayerList[turnCounter].PlayerHand[1];

            hand = 0;
        }

        public void resetTableTurn()
        {
            int j;
            for(j = 0; j < player.ALocalGame.PlayerList.Count; j++)
            {
                player.ALocalGame.PlayerList[j].PlayerHand.Clear();
                player.ALocalGame.PlayerList[j].PlayerHandValue = 0;
                gameBoard.currentBetLabels[j].Text = "Current Bet: ";
                gameBoard.currentTotalLabels[j].Text = "Current Total: ";
            }
            dealer.CurrentPlayerHand.Clear();
            dealer.CurrentValueOfHand = 0;
            gameBoard.resultLabel.Text = "";
            gameBoard.dealerVisableTotalLabel.Text = "Dealer Visable Total: ";
            deck = new Deck();
            gameBoard.hitButton.Visible = false;
            gameBoard.standButton.Visible = false;
            gameBoard.betButton.Enabled = true;
            gameBoard.betTextBox.ReadOnly = false;
        }
        

        public void playerWins(GamePlayer play)
        {

        }

        public void playerBlackjack(GamePlayer play)
        {

        }

        public void dealerWins()
        {

        }

        public void playerBusts(GamePlayer play)
        {

        }

        

        

    }
}
